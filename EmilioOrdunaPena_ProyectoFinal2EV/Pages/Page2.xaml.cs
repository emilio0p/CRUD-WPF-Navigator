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
            Database.rellenarProductosMasVendidos(tablaProductos2);
            btnConsulta1.Content = "| " + btnConsulta1.Content;
            btnConsulta1.Background = new SolidColorBrush(Color.FromRgb(123, 168, 94));
        }

        private void btnConsulta1_Click(object sender, RoutedEventArgs e)
        {
            reiniciarTextosColores();
            Database.rellenarProductosMasVendidos(tablaProductos2);
            btnConsulta1.Content = "| " + btnConsulta1.Content;
            btnConsulta1.Background = new SolidColorBrush(Color.FromRgb(123, 168, 94));
        }

        private void btnConsulta2_Click(object sender, RoutedEventArgs e)
        {
            reiniciarTextosColores();
            Database.rellenarProductosSinStock(tablaProductos2);
            btnConsulta2.Content = "| " + btnConsulta2.Content;
            btnConsulta2.Background = new SolidColorBrush(Color.FromRgb(123, 168, 94));
        }

        private void btnConsulta3_Click(object sender, RoutedEventArgs e)
        {
            reiniciarTextosColores();
            Database.rellenarProductosMasCaros(tablaProductos2);
            btnConsulta3.Content = "| " + btnConsulta3.Content;
            btnConsulta3.Background = new SolidColorBrush(Color.FromRgb(123, 168, 94));
        }

        private void reiniciarTextosColores()
        {
            btnConsulta1.Content = "Productos más vendidos";
            btnConsulta2.Content = "Productos sin stock";
            btnConsulta3.Content = "Productos más caros";
            btnConsulta1.Background = new SolidColorBrush(Color.FromRgb(128, 177, 152));
            btnConsulta2.Background = new SolidColorBrush(Color.FromRgb(128, 177, 152));
            btnConsulta3.Background = new SolidColorBrush(Color.FromRgb(128, 177, 152));


        }
    }
}
