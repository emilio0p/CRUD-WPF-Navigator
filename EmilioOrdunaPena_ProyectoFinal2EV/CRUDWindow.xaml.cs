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
    /// Lógica de interacción para CRUDWindow.xaml
    /// </summary>
    public partial class CRUDWindow : Window
    {
        Boolean textoCambiado = false;
        long id;

        public CRUDWindow(long id, string? nombre, string? desc, float precio, string? imagen, int stock, int categoria)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = nombre;
            txtPrecio.Text = precio.ToString();
            txtCategoria.Text = categoria.ToString();
            txtDesc.Text = desc;
            txtImagen.Text = imagen;
            txtStock.Text = stock.ToString();
            textoCambiado = false;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (textoCambiado)
            {
                string name = txtNombre.Text; 
                int cate = Convert.ToInt32(txtCategoria.Text); 
                string img = txtImagen.Text;
                string des = txtDesc.Text;
                int units = Convert.ToInt32(txtStock.Text);
                float price = float.Parse(txtPrecio.Text);

                Database.actualizarProducto(id, name, des, price, img, units, cate);
                this.Close();
            } else
            {
                this.Close();
            }
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quieres eliminar el registro?", "Eliminar registro", MessageBoxButton.YesNo, MessageBoxImage.Stop);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    Database.borrarProducto(id);
                    this.Close();
                    break;

                case MessageBoxResult.No:
                    // No hacer nada en este caso
                    break;
            }
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Controla si se ha modificado algo del texto para hacer o no la consulta update
            textoCambiado = true;
            
        }
    }
}
