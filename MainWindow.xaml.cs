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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero1.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero2.Content;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero3.Content;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero4.Content;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero5.Content;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero6.Content;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero7.Content;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero8.Content;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero9.Content;
        }
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Numeros.Text = Numeros.Text + BotonNumero0.Content;
        }
    }
}
