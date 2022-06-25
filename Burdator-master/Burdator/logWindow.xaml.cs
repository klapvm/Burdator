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
    /// Логика взаимодействия для logWindow.xaml
    /// </summary>
    public partial class logWindow : Window
    {
        public logWindow()
        {
            InitializeComponent();
        }

        public void itog()
        {
            try
            {
                xText.Text = Math.Log(Convert.ToInt32(aText.Text)).ToString();
                xText_Copy.Text = Math.Log10(Convert.ToInt32(aText.Text)).ToString();
                xText_Copy1.Text = Math.Log(Convert.ToInt32(aText.Text), Convert.ToInt32(bText.Text)).ToString();
            }
            catch(Exception ex) { }
        }

        private void a_TextChanged(object sender, TextChangedEventArgs e)
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