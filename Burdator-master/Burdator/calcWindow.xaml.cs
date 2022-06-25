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
using System.Windows.Shapes;

namespace Burdator
{
    /// <summary>
    /// Логика взаимодействия для calcWindow.xaml
    /// </summary>
    public partial class calcWindow : Window
    {
        public calcWindow()
        {
            InitializeComponent();
        }
        public string ss = "";
        public double some = 0, zn = 0, zn1 = 0, csl = 0, zpk = 0;
        public bool znak = false, zp = false;
        private void _0_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '0';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a = a + '1';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '2';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '3';

            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '4';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '5';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '6';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '7';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '8';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            a += '9';
            znak = false;
            ss = a;
            _t.Text = a;
        }

        private void _eq_Click(object sender, RoutedEventArgs e)
        {
            int n = 5;
            string[] f;
            string a = _t.Text;
            foreach (char i in a)
            {
                if (i == '+')
                {
                    n = 0;
                }
                else if (i == '-')
                {
                    n = 1;
                }
                else if (i == '/')
                {
                    n = 2;
                }
                else if (i == '*')
                {
                    n = 3;
                }
                else if (i == '^')
                {
                    n = 4;
                }
                else if (i == '√')
                {
                    n = 5;
                }
            }
            if (n == 0)
            {
                if (a[a.Length - 2] == ',')
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    f = a.Split('+');
                    some = float.Parse(f[0]) + float.Parse(f[1]);
                    _t.Text = some.ToString();
                }
            }
            if (n == 1)
            {
                f = a.Split('-');
                some = float.Parse(f[0]) - float.Parse(f[1]);
                _t.Text = some.ToString();
            }
            if (n == 2)
            {
                f = a.Split('/');
                try
                {
                    some = Double.Parse(f[0]) / Double.Parse(f[1]);
                    _t.Text = some.ToString();
                }
                catch (DivideByZeroException)
                {
                    _t.Text = "Нельзя делить на 0";
                }
            }
            if (n == 3)
            {
                f = a.Split('*');
                some = Double.Parse(f[0]) * Double.Parse(f[1]);
                _t.Text = some.ToString();
            }
            if (n == 4)
            {
                f = a.Split('^');
                double nn = Math.Pow(Double.Parse(f[0]), Double.Parse(f[1]));
                _t.Text = nn.ToString();
            }
            if (n == 5)
            {
                f = a.Split('√');
                double nn = Math.Pow(Double.Parse(f[1]), (1 / Double.Parse(f[0])));
                _t.Text = nn.ToString();
            }
            zp = false;

        }
        private void _C_Click_1(object sender, RoutedEventArgs e)
        {
            _t.Text = "";
        }

        private void _pro_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            _t.Text = (float.Parse(a) / 100).ToString();
        }

        private void _1_x_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            decimal n = decimal.Parse(a);
            decimal p = 1, f = 0;
            try
            {
                p /= n;
            }
            catch (DivideByZeroException)
            {
                f = 1;
            }
            if (f == 0)
                _t.Text = p.ToString();
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void _vos_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (Int32.Parse(a) < 0)
            {
                MessageBox.Show("Ошибка");
            }
            else if (Int32.Parse(a) == 0)
            {
                _t.Text = 1.ToString();
            }
            else
            {
                double n = Double.Parse(a), x = 1;
                for (Double i = 1; i <= n; i++)
                {
                    x *= i;
                }
                _t.Text = x.ToString();
            }
        }
        private void _log_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                if (Double.Parse(a) <= 0)
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    double b = Math.Log10(Double.Parse(a));
                    _t.Text = b.ToString();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                if (Double.Parse(a) <= 0)
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    double b = Math.Sqrt(Double.Parse(a));
                    _t.Text = b.ToString();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                double b = Math.Pow(Double.Parse(a), 2);
                _t.Text = b.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (znak == false)
            {
                a += '^';
                if (zn == 0)
                {
                    zn++;

                }
            }

            _t.Text = a;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                if (Double.Parse(a) <= 0)
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    double b = Math.Log(Double.Parse(a));
                    _t.Text = b.ToString();
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                double b = Math.Pow(10, Double.Parse(a));
                _t.Text = b.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                double b = Math.Abs(float.Parse(a));
                _t.Text = b.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                double b = Math.Pow(Math.E, Double.Parse(a));
                _t.Text = b.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                double b = Math.Pow(2, Double.Parse(a));
                _t.Text = b.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                double b = Math.Pow(Double.Parse(a), 3);
                _t.Text = b.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a.Length == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                double b = Math.Pow(Double.Parse(a), Math.Pow(3, -1));
                _t.Text = b.ToString();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (znak == false)
            {
                a += '√';
                if (zn == 0)
                {
                    zn++;
                    znak = true;
                }
            }

            _t.Text = a;
        }

        private void _pl_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (znak == false)
            {
                a += '+';
                if (zn == 0)
                {
                    zn++;
                    znak = true;
                    zp = false;
                }
            }

            _t.Text = a;
        }

        private void _min_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a != "")
                if (znak == false)
                {
                    a += '-';
                    znak = true;
                    zp = false;
                }
            _t.Text = a;
        }

        private void _del_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a != "")
                if (znak == false)
                {
                    a += '/';
                    znak = true;
                    zp = false;
                }

            _t.Text = a;
        }

        private void _um_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (a != "")
                if (znak == false)
                {
                    a += "*";
                    znak = true;
                    zp = false;
                }

            _t.Text = a;
        }
        private void _zp_Click(object sender, RoutedEventArgs e)
        {
            string a = _t.Text;
            if (zp == false)
            {
                a += ',';
                _t.Text = a;
                zp = true;
            }
        }
    }
}
