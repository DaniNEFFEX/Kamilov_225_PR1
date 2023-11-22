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

namespace Задание2
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
            if (!double.TryParse(TextBox1.Text, out double x1))
            { MessageBox.Show("Поле только для чисел"); }
            if (!double.TryParse(TextBox2.Text, out double x2))
            { MessageBox.Show("Поле только для чисел"); }
            if (!double.TryParse(TextBox3.Text, out double y1))
            { MessageBox.Show("Поле только для чисел"); }
            if (!double.TryParse(TextBox4.Text, out double y2))
            { MessageBox.Show("Поле только для чисел"); }
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);
            double S;
            double P;
            S = a * b;
            P = 2 * (a + b);
            Answer.Text += "Площадь равна " + P + "\n";
            Answer.Text += "Периметр равен " + S;
        }
    }
}
