using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    public partial class MainWindow : Window
    {
        int countOfQuestionMarks = 0;
        int countOfExclamationMarks = 0;
        int countOfSymbols = 0;
        int countOfWords = 0;
        int countOfSentences = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task(Func);
            task.Start();
        }

        void Func()
        {
            foreach (var item in textTB.Text.ToString())
            {
                if (item == '?')
                    countOfQuestionMarks++;

                if (item == '!')
                    countOfExclamationMarks++;

                if (item != ' ')
                    countOfSymbols++;

                if (item == '.')
                    countOfSentences++;

                if (item == ' ' || item == ',' || item == '.' || item == '!' || item == '?')
                    countOfWords++;
            }


            resTb.Text = $"CountOfWords: {countOfWords};\nCountOfSymbols: {countOfSymbols};\nCountOfSentences: {countOfSentences};\nCountOfExclamationMarks: {countOfExclamationMarks};\nCountOfQuestionMarks: {countOfQuestionMarks}\n";
        }
    }
}
