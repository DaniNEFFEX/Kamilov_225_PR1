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

namespace Задание3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out double a))
            { MessageBox.Show("Поле только для чисел"); }
            if (!double.TryParse(TextBox2.Text, out double b))
            { MessageBox.Show("Поле только для чисел"); }
            double A;
            double B;
            double Z;
            A = a;
            B = b;
            Z = A - B;
            Answer.Text += "Стоимость 1кг шоколадных конфет " + A + "\n";
            Answer.Text += "Стоимость 1кг ирисок " + B + "\n";
            Answer.Text += "Разность " + Z;
        }
    }
}
