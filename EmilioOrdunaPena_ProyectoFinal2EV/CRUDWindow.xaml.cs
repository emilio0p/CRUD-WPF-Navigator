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
    /// Lógica de interacción para CRUDWindow.xaml
    /// </summary>
    public partial class CRUDWindow : Window
    {


        public CRUDWindow(long id, string? nombre, string? desc, float precio, string? imagen, int stock, int categoria)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtPrecio.Text = precio.ToString("C");
            txtCategoria.Text = categoria.ToString();
            txtDesc.Text = desc;
            txtImagen.Text = imagen;
            txtStock.Text = stock.ToString();
            MessageBox.Show(id.ToString());
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
