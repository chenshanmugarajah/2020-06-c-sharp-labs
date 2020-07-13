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

namespace InterfaceCalculator
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

        public double ans = 0;

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            ans = CalculatorLib.StaticCalculator.add(Int32.Parse(Input1.Text), Int32.Parse(Input2.Text));
            LabelAnswer.Content = ans;
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            ans = CalculatorLib.StaticCalculator.subtract(Int32.Parse(Input1.Text), Int32.Parse(Input2.Text));
            LabelAnswer.Content = ans;
        }

        private void ButtonModular_Click(object sender, RoutedEventArgs e)
        {
            ans = CalculatorLib.StaticCalculator.modulus(Int32.Parse(Input1.Text), Int32.Parse(Input2.Text));
            LabelAnswer.Content = ans;
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            ans = CalculatorLib.StaticCalculator.multiply(Int32.Parse(Input1.Text), Int32.Parse(Input2.Text));
            LabelAnswer.Content = ans;
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            ans = CalculatorLib.StaticCalculator.divide(Int32.Parse(Input1.Text), Int32.Parse(Input2.Text));
            LabelAnswer.Content = ans;
        }

        private void ButtonMemory_Click(object sender, RoutedEventArgs e)
        {
            LabelAnswer.Content = ans;
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            Input1.Text = ""; Input2.Text = ""; LabelAnswer.Content = "";
        }
    }
}
