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

namespace Ej2EventosPantallas
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

        private void btnAbrir_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.cambio += new Window2.Cambio(CambiarNombreVentana);
            w2.Show();
        }
        public void CambiarNombreVentana(string title)
        {
            Window1.Title = title;
        }
    }
}
