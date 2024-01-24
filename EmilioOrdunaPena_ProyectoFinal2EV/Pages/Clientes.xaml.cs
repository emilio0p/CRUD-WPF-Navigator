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
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : Page
    {
        public Clientes()
        {
            InitializeComponent();
            Database.rellenarTablaClientes(tablaClientes);
        }
    }
}
