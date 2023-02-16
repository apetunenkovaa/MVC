using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVC
{
    class Models
    {
        public static string firstOperand;
        public static string secondOperand;
        public static List<string> dataListDisplay = new List<string>() { "Сложение", "Вычитание", "Умножение", "Деление" }; // Список для выбора из comboBox
        public static List<string> dataListValue = new List<string>() { "+", "-", "*", "/" }; // Список для вывода в textBox

        
        public static TextBlock tbSelectOperation;
        public static TextBox tbResult;

        // блок с бизнес-логикой
        public static int ArithmeticOperation  // свойтсво для отображения знака арифметической операции
        {
            set
            {
                tbSelectOperation.Text = dataListValue[value];
            }
        }
        public static int CalculationResult // свойтсво для отображения результата
        {
            set
            {
                try
                {
                    double firstNumber = 0;
                    double secondNumber = 0;
                    if (firstOperand != "")
                    {
                        firstNumber = Convert.ToDouble(firstOperand);
                    }
                    if (secondOperand != "")
                    {
                        secondNumber = Convert.ToDouble(secondOperand);
                    }
                    switch (value)
                    {
                        case 0:
                            tbResult.Text = Convert.ToString(firstNumber + secondNumber);
                            break;
                        case 1:
                            tbResult.Text = Convert.ToString(firstNumber - secondNumber);
                            break;
                        case 2:
                            tbResult.Text = Convert.ToString(firstNumber * secondNumber);
                            break;
                        case 3:
                            if (secondNumber == 0)
                            {
                                tbResult.Text = "Деление на 0";
                                MessageBox.Show("Невозможно делить на 0");
                            }
                            else
                            {
                                tbResult.Text = Convert.ToString(firstNumber / secondNumber);
                            }
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("При вычисление арифметической операции возникла ошибка");
                }
            }
        }
    }
}
