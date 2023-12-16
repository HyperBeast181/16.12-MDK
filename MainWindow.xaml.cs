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

namespace _16._12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddElementButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add($"Барашек {listBox.Items.Count + 1}");
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение чисел из текстовых полей
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                // Сложение чисел и вывод результата
                double sum = num1 + num2;
                resultTextBlock.Text = $"Результат: {sum}";
            }
            catch (FormatException)
            {
                resultTextBlock.Text = "Ошибка ввода чисел";
            }
        }
    }
}
