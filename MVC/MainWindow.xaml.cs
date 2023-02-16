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

namespace MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Models.tbResult = tbResult;
            Models.tbSelectOperation = tbSelectOperation;
            cbSelectOperation.ItemsSource = Models.dataListDisplay;
            cbSelectOperation.SelectedIndex = 0;
        }

        private void SelectOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Models.ArithmeticOperation = cbSelectOperation.SelectedIndex;
        }

        private void Calcul_Click(object sender, RoutedEventArgs e)
        {
            Models.firstOperand = tbFirstOperand.Text;
            Models.secondOperand = tbSecondOperand.Text;
            Models.CalculationResult = cbSelectOperation.SelectedIndex;
        }
    }
}
