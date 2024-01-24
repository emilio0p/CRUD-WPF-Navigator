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
using System.Windows.Shapes;

namespace EmilioOrdunaPena_ProyectoFinal2EV
{
    /// <summary>
    /// Lógica de interacción para AddCliente.xaml
    /// </summary>
    public partial class AddCliente : Window
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            String nombre = txtNombre.Text;
            String email = txtEmail.Text;
            String tlfn = txtTelefono.Text;
            Database.agregarCliente(nombre, email, tlfn);
            this.Close();
        }
    }
}
