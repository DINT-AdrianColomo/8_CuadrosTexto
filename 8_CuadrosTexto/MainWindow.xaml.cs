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

namespace _8_CuadrosTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Edad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && !int.TryParse(edadTextBox.Text, out _))
            {
                if(ayuda3TextBlock.Visibility == Visibility.Hidden)
                {
                    ayuda3TextBlock.Visibility = Visibility.Visible;
                }
            }
            if(e.Key == Key.F2 && int.TryParse(edadTextBox.Text, out _))
            {
                if (ayuda3TextBlock.Visibility == Visibility.Visible)
                {
                    ayuda3TextBlock.Visibility = Visibility.Hidden;
                }
            }
        }

        private void NombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && ayuda1TextBlock.Visibility == Visibility.Hidden)
            {
                ayuda1TextBlock.Visibility = Visibility.Visible;
            }
            else if (e.Key == Key.F1 && ayuda1TextBlock.Visibility == Visibility.Visible)
            {
                ayuda1TextBlock.Visibility = Visibility.Hidden;
            }
        }

        private void ApellidoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && ayuda2TextBlock.Visibility == Visibility.Hidden)
            {
                ayuda2TextBlock.Visibility = Visibility.Visible;
            }
            else if(e.Key == Key.F1 && ayuda2TextBlock.Visibility == Visibility.Visible)
            {
                ayuda2TextBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
