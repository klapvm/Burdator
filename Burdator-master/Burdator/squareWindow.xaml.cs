using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Burdator
{
    /// <summary>
    /// Логика взаимодействия для squareWindow.xaml
    /// </summary>
    public partial class squareWindow : Window
    {
        public squareWindow()
        {
            InitializeComponent();
        }

        public void itog()
        {
            xText.Text = "";
            try {
                int a = Convert.ToInt32(aText.Text);
                int b = Convert.ToInt32(bText.Text);
                int c = Convert.ToInt32(cText.Text);

                int D = (b * b) + ((-4) * a * c);

                double x1 = (((b * -1) + Math.Sqrt(D)) / (2 * a));
                double x2 = (((b * -1) - Math.Sqrt(D)) / (2 * a));

                xText.Text = "x1 = " + x1.ToString() + " ; " + "x2 = " + x2.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void a_TextChanged(object sender, TextChangedEventArgs e)
        {
            itog();
        }

        private void bText_TextChanged(object sender, TextChangedEventArgs e)
        {
            itog();
        }

        private void c_TextChanged(object sender, TextChangedEventArgs e)
        {
            itog();
        }

        public void DigitsTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
