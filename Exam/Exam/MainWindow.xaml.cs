using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam
{
    public partial class MainWindow : Window
    {
        ObservableCollection<FileCopyInfo> threads = new ObservableCollection<FileCopyInfo>();
        Mutex mutex = new Mutex(false, "MyApplication");

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (!mutex.WaitOne(500, false))
            {
                System.Windows.MessageBox.Show("Same application's copy is working!", "Error");
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void CopyFile(object obj)
        {
            try
            {
                FileCopyInfo info = obj as FileCopyInfo;

                if (info == null)
                    return;

                string name = System.IO.Path.GetFileName(info.FileName);
                string destPath = System.IO.Path.Combine(info.FolderName, name);

                int bufferSize = 4096;
                using (FileStream fileStream = new FileStream(destPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
                {
                    FileStream fs = new FileStream(info.FileName, FileMode.Open, FileAccess.ReadWrite);
                    fileStream.SetLength(fs.Length);
                    int bytesRead = -1;
                    byte[] bytes = new byte[bufferSize];

                    while ((bytesRead = fs.Read(bytes, 0, bufferSize)) > 0)
                    {
                        fileStream.Write(bytes, 0, bytesRead);
                        info.Progress = 100;
                        Thread.Sleep(50);
                    }
                    fs.Close();

                    this.Dispatcher.Invoke(() =>
                    {
                        progress.Value = info.Progress;
                    });
                }

                this.Dispatcher.Invoke(() =>
                {
                    ThreadPool.QueueUserWorkItem(ReplaceProhibitedWords, destPath);
                });
            }
            catch { }
        }

        private void openFileBtn_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                openFileTb.Text = FBD.SelectedPath;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var directory = Directory.GetFiles(openFileTb.Text, "*.txt");

            ThreadPool.QueueUserWorkItem(Find, directory);
        }

        private void ReplaceProhibitedWords(object obj)
        {
            string path = obj as string;
            string text;
            //string prohibitedWords;

            //using (FileStream fstream = File.OpenRead("Words.txt"))
            //{
            //    byte[] array = new byte[fstream.Length];

            //    fstream.Read(array, 0, array.Length);

            //    prohibitedWords = System.Text.Encoding.Default.GetString(array);
            //}

            using (FileStream fstream = File.OpenRead(path))
            {
                byte[] array = new byte[fstream.Length];

                fstream.Read(array, 0, array.Length);

                text = System.Text.Encoding.Default.GetString(array);
            }

            this.Dispatcher.Invoke(() =>
            {
                text = text.Replace(forbWordsTB.Text, "*******");
            });

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                file.Write(text);
            }
        }

        private void Find(object obj)
        {
            var dirs = obj as string[];
            string text;
            //string prohibitedWords;

            //using (FileStream fstream = File.OpenRead("Words.txt"))
            //{
            //    byte[] array = new byte[fstream.Length];

            //    fstream.Read(array, 0, array.Length);

            //    prohibitedWords = System.Text.Encoding.Default.GetString(array);
            //}

            //var splitWords = prohibitedWords.Split(' ', ',', '.', '?', '!', '\n');

            foreach (var dir in dirs)
            {
                using (FileStream fstream = File.OpenRead(dir))
                {
                    byte[] array = new byte[fstream.Length];

                    fstream.Read(array, 0, array.Length);

                    text = System.Text.Encoding.Default.GetString(array);
                }

                var words = text.Split(' ', ',', '.', '?', '!', '\n');

                int counter = 0;

                foreach (var word in words)
                {
                    //System.Windows.MessageBox.Show(splitWords[i]);

                    this.Dispatcher.Invoke(() =>
                    {
                        if (forbWordsTB.Text == word)
                        {
                            counter++;

                            this.Dispatcher.Invoke(() =>
                            {
                                ThreadPool.QueueUserWorkItem(CopyFile, new FileCopyInfo() { FolderName = copyDirTb.Text, FileName = dir, Progress = 100 });
                            });
                        }
                    });
                }

                this.Dispatcher.Invoke(() =>
                {
                    listBox.Items.Add(dir);
                });


                string text2 = $"Dir: {dir} _______ Count: {counter}";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("res.txt", true, System.Text.Encoding.Default))
                {
                    file.Write(text2 + '\n');
                }

                //foreach (var word in words)
                //{
                //    foreach (var item in splitWords)
                //    {
                //        if (splitWords[i] == word)
                //            this.Dispatcher.Invoke(() =>
                //            {
                //                ThreadPool.QueueUserWorkItem(CopyFile, new FileCopyInfo() { FolderName = copyDirTb.Text, FileName = dir, Progress = 100 });
                //            });
                //    }
                //    i++;
                //}
            }

            System.Windows.MessageBox.Show("Copy success");
        }

        private void OpenFolderBtn_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                copyDirTb.Text = FBD.SelectedPath;
        }

        private void addForbWordsBTN_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Words.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(forbWordsTB.Text);
            }
        }
    }
}
