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

namespace Практическая_1
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
            if (!Double.TryParse(TextBox1.Text, out double a))
            { MessageBox.Show("Поле только для чисел"); }

            if (!Double.TryParse(TextBox2.Text, out double b))
            { MessageBox.Show("Поле только для чисел"); }

            if (!Double.TryParse(TextBox3.Text, out double c))
            { MessageBox.Show("Поле только для чисел"); }
            double V;
            V = a * b * c;
            double S;
            S = 2 * (a * b + b * c + a * c);
            Answer.Text += "Объем равен " + V + "\n";
            Answer.Text += "Площадь равна " + S;
        
        }
    }
}

