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

namespace Ej2EventosPantallas
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        public delegate void Cambio(string title);
        public event Cambio cambio;

        public void CambiarNombreVentana(string title)
        {
            if (cambio != null)
            {
                cambio(title);
            }
        }

        private void btnCambiarTittle_Click(object sender, RoutedEventArgs e)
        {
            cambio(txbTitle.Text);
        }
    }
}
