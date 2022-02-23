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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResultText.Text = String.Empty;
            CurrentOperationText.Text = String.Empty;
        }

        private void ButtonSubstract_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOperationText.Text.Contains("+") || CurrentOperationText.Text.Contains("-")|| CurrentOperationText.Text.Contains("*")|| CurrentOperationText.Text.Contains("/"))
            {
                String oper = CurrentOperationText.Text;
                CurrentOperationText.Text = CalculateResult(oper).ToString();
            }
            CurrentOperationText.Text += "-";
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOperationText.Text.Contains("+") || CurrentOperationText.Text.Contains("-") || CurrentOperationText.Text.Contains("*") || CurrentOperationText.Text.Contains("/"))
            {
                String oper = CurrentOperationText.Text;
                CurrentOperationText.Text = CalculateResult(oper).ToString();
            }
            CurrentOperationText.Text += "+";
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOperationText.Text.Contains("+") || CurrentOperationText.Text.Contains("-") || CurrentOperationText.Text.Contains("*") || CurrentOperationText.Text.Contains("/"))
            {
                String oper = CurrentOperationText.Text;
                CurrentOperationText.Text = CalculateResult(oper).ToString();
            }
            CurrentOperationText.Text += "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOperationText.Text.Contains("+") || CurrentOperationText.Text.Contains("-") || CurrentOperationText.Text.Contains("*") || CurrentOperationText.Text.Contains("/"))
            {
                String oper = CurrentOperationText.Text;
                CurrentOperationText.Text = CalculateResult(oper).ToString();
            }
            CurrentOperationText.Text += "/";
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            String operation = CurrentOperationText.Text;
            ResultText.Text = CalculateResult(operation).ToString();

            CurrentOperationText.Text = String.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = String.Empty;
            Button button = sender as Button;
            CurrentOperationText.Text += button.Name[button.Name.Length-1];
        }

        private int CalculateResult(string operation)
        {
            if (operation.Contains("+"))
            {
                var elements = operation.Split('+');
                return int.Parse(elements[0]) + int.Parse(elements[1]);                
            }
            if (operation.Contains("-"))
            {
                var elements = operation.Split('-');
                return int.Parse(elements[0]) - int.Parse(elements[1]);                
            }
            if (operation.Contains("*"))
            {
                var elements = operation.Split('*');
                return int.Parse(elements[0]) * int.Parse(elements[1]);                
            }
            if (operation.Contains("/"))
            {
                var elements = operation.Split('/');
                return int.Parse(elements[0]) / int.Parse(elements[1]);                
            }

            return default;
        }
    }
}
