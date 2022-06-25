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
    /// Логика взаимодействия для grafikWindow.xaml
    /// </summary>
    public partial class grafikWindow : Window
    {
        public grafikWindow()
        {
            InitializeComponent();
            Line vertL = new Line();
            vertL.X1 = 400;
            vertL.Y1 = 350;
            vertL.X2 = 400;
            vertL.Y2 = 10;
            vertL.Stroke = Brushes.Black;
            grid1.Children.Add(vertL);
            Line horL = new Line();
            horL.X1 = 700;
            horL.X2 = 150;
            horL.Y1 = 160;
            horL.Y2 = 160;
            horL.Stroke = Brushes.Black;
            grid1.Children.Add(horL);
            for (int i = 150; i <= 700; i += 25)
            {
                Line a = new Line();
                a.X1 = i;
                a.X2 = i;
                a.Y1 = 165;
                a.Y2 = 155;
                a.Stroke = Brushes.Black;
                grid1.Children.Add(a);
            }
            for (int i = 10; i <= 350; i += 25)
            {
                Line a = new Line();
                a.X1 = 395;
                a.X2 = 405;
                a.Y1 = i;
                a.Y2 = i;
                a.Stroke = Brushes.Black;
                grid1.Children.Add(a);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                grid2.Children.Clear();
                Polyline parabola = new Polyline();
                parabola.Points = new PointCollection();
                int a = Convert.ToInt32(A.Text);
                int b = Convert.ToInt32(B.Text);
                int c = Convert.ToInt32(C.Text);
                Point tt;
                for (double i = -100; i <= 100; i += 0.1)
                {
                    double t = i * 25;
                    double formula = a * Math.Pow(i, 2) + b * i + c;
                    tt = new Point(400 + t, 160 - formula * 25);
                    parabola.Points.Add(tt);
                }
                parabola.Stroke = Brushes.Black;
                grid2.Children.Add(parabola);
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
        }

        private void sinx_Checked(object sender, RoutedEventArgs e)
        {
            Polyline sinx = new Polyline();
            sinx.Points = new PointCollection();
            Point tt;
            for (double i = -100; i <= 100; i += 0.1)
            {
                double t = i * 25;
                double formula = Math.Sin(i);         //a * Math.Pow(i, 2) + b * i + c;
                tt = new Point(400 + t, 160 - formula * 25);
                sinx.Points.Add(tt);
            }

            sinx.Stroke = Brushes.Blue;
            grid3.Children.Add(sinx);
        }

        private void sinx_Unchecked(object sender, RoutedEventArgs e)
        {
            grid3.Children.Clear();
        }

        private void cosx_Unchecked(object sender, RoutedEventArgs e)
        {
            grid4.Children.Clear();
        }

        private void cosx_Checked(object sender, RoutedEventArgs e)
        {
            Polyline cosx = new Polyline();
            cosx.Points = new PointCollection();
            Point tt;
            for (double i = -100; i <= 100; i += 0.1)
            {
                double t = i * 25;
                double formula = Math.Cos(i);         //a * Math.Pow(i, 2) + b * i + c;
                tt = new Point(400 + t, 160 - formula * 25);
                cosx.Points.Add(tt);
            }
            cosx.Stroke = Brushes.Green;
            grid4.Children.Add(cosx);
        }

        private void tanx_Checked(object sender, RoutedEventArgs e)
        {
            Polyline tanx = new Polyline();
            tanx.Points = new PointCollection();
            Point tt;
            for (double i = -100; i <= 100; i += 0.1)
            {
                double t = i * 25;
                double formula = Math.Tan(i);         //a * Math.Pow(i, 2) + b * i + c;
                tt = new Point(400 + t, 160 - formula * 25);
                tanx.Points.Add(tt);
            }
            tanx.Stroke = Brushes.Red;
            grid5.Children.Add(tanx);
        }

        private void tanx_Unchecked(object sender, RoutedEventArgs e)
        {
            grid5.Children.Clear();
        }

    }
}
