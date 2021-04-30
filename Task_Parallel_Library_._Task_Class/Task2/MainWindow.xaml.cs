using System;
using System.Collections.Generic;
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

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                openFileTb.Text = FBD.SelectedPath;
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task(Func);
            task.Start();
        }

        void Func()
        {
            List<string> directory = new List<string>(Directory.GetFiles(openFileTb.Text, ".txt"));
            List<string> newDir = new List<string>(directory.Distinct());

            count = directory.Count - newDir.Count;
        }
    }
}
