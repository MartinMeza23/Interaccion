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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnBoton.Click += BtnBoton_Click;
        }

        private void BtnBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Adios Mundo!";
            lblHolaMundo.FontSize = 29;
            lblHolaMundo.Foreground = Brushes.Red;
        }

        private void BtnMi2doBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "2doBoton!";
            lblHolaMundo.FontSize = 24;
            lblHolaMundo.Foreground = Brushes.Aqua;
        }

        private void BtnMi3erBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "3erBoton!";
            lblHolaMundo.FontSize = 35;
            lblHolaMundo.Foreground = Brushes.Coral;
        }

    }
}
