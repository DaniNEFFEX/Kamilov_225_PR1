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

namespace Задание4
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
            if (!Double.TryParse(Textx.Text, out double x))
            { MessageBox.Show("Поле только для чисел"); }
            if (!Double.TryParse(Textb.Text, out double b))
            { MessageBox.Show("Поле только для чисел"); }
            double a, z;
            z = Math.Pow(x, 2) + Math.Pow(b, 2);
            a = Math.Pow(x, 6) + Math.Pow(z * Math.Pow(x, 4) + Math.Cos(x + z), 1 / 3) / Math.Log(Math.Abs(x + z));
            TextAnswer.Text += ("" + a);

        }
    }
}
