using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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

namespace lab_04_wpf_core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // windows command
            InitializeComponent();
            LabelDisplay.Content = "";
        }

        static int firstNumber = 0;
        static int secondNumber1 = 0;
        static string operation = "";

        int getAnswer()
        {
            switch (operation)
            {
                case "*": return firstNumber * secondNumber1;
                case "/": return firstNumber / secondNumber1;
                case "+": return firstNumber + secondNumber1;
                case "-": return firstNumber - secondNumber1;
                default: return 69;
            }
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button01.Content;
        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button02.Content;
        }

        private void Button03_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button03.Content;
        }

        private void Button04_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button04.Content;
        }

        private void Button05_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button05.Content;
        }

        private void Button06_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button06.Content;
        }

        private void Button07_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button07.Content;
        }

        private void Button08_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button08.Content;
        }

        private void Button09_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button09.Content;
        }

        private void Button00_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += (string)Button00.Content;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            firstNumber = Convert.ToInt32(LabelDisplay.Content);
            LabelDisplay.Content = "";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            firstNumber = Convert.ToInt32(LabelDisplay.Content);
            LabelDisplay.Content = "";
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            firstNumber = Convert.ToInt32(LabelDisplay.Content);
            LabelDisplay.Content = "";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            firstNumber = Convert.ToInt32(LabelDisplay.Content);
            LabelDisplay.Content = "";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            secondNumber1 = Convert.ToInt32(LabelDisplay.Content);
            int ans = getAnswer();
            string answer = ans.ToString();
            LabelDisplay.Content = firstNumber + operation + secondNumber1 + " = " + answer;

            firstNumber = 0;
            secondNumber1 = 0;
            operation = "";
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber1 = 0;
            LabelDisplay.Content = "";
        }
    }
}
