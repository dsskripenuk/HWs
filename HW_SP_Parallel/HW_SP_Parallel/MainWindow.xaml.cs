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

namespace HW_SP_Parallel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Parallel.Invoke(Func);
        }

        void Func()
        {
            var directory = Directory.GetFiles(openFileTb.Text, ".txt");

            foreach (var item in directory)
                listBox.Items.Add(item);
        }

        private void openFileBtn_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                openFileTb.Text = FBD.SelectedPath;
        }
    }
}
