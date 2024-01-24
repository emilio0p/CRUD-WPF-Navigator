using EmilioOrdunaPena_ProyectoFinal2EV.DB;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                // Validar el nombre: letras, números y espacios permitidos
                string name = txtNombre.Text;
                if (!Regex.IsMatch(name, @"^[\p{L}0-9 ]+$"))
                {
                    MessageBox.Show("El nombre solo debe contener letras, números, espacios y acentos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Validar la categoría: solo números enteros permitidos
                if (!int.TryParse(txtCategoria.Text, out int cate))
                {
                    MessageBox.Show("La categoría debe ser un número entero.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Validar la imagen: una cadena no vacía
                string img = txtImagen.Text;
                if (string.IsNullOrWhiteSpace(img))
                {
                    MessageBox.Show("La ruta de la imagen no puede estar vacía.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Validar la descripción: cualquier carácter es válido
                string des = txtDesc.Text;

                // Validar el stock: solo números enteros permitidos
                if (!int.TryParse(txtStock.Text, out int units))
                {
                    MessageBox.Show("El stock debe ser un número entero.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Validar el precio: solo números con punto o coma permitidos
                if (!float.TryParse(txtPrecio.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float price))
                {
                    MessageBox.Show("El precio debe ser un número decimal válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Llamar al método actualizarProducto solo si todas las validaciones son exitosas
                Database.actualizarProducto(id, name, des, price, img, units, cate);
                this.Close();
            }
            else
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
