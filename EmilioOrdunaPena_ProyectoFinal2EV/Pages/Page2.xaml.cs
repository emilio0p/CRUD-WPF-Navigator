using EmilioOrdunaPena_ProyectoFinal2EV.DB;
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

namespace EmilioOrdunaPena_ProyectoFinal2EV.Pages
{
    /// <summary>
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btnConsulta1_Click(object sender, RoutedEventArgs e)
        {
            Database.rellenarProductosMasVendidos(tablaProductos2);
        }

        private void btnConsulta2_Click(object sender, RoutedEventArgs e)
        {
            Database.rellenarProductosSinStock(tablaProductos2);
        }

        private void btnConsulta3_Click(object sender, RoutedEventArgs e)
        {
            Database.rellenarProductosMasCaros(tablaProductos2);
        }
    }
}
