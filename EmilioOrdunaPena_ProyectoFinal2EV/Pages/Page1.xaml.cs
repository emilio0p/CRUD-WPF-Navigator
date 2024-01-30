using EmilioOrdunaPena_ProyectoFinal2EV.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private int numCat;
        public Page1()
        {
            InitializeComponent();
            Database.rellenarTablaProductos(tablaProductos);
            llenarCategorias();
            
        }

        private void llenarCategorias()
        {

            List<String> lista = new List<String>();

            lista = DB.Database.obtenerCategorias();
            numCat = lista.Count;

            for (int i = 0; i < lista.Count; i++) {
                ComboBoxItem cm = new ComboBoxItem();
                cm.Content = lista[i];
                listaCategorias.Items.Add(cm);
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {

                Database.buscarProducto(tablaProductos, txtBuscar.Text);
            
            
        }

        private void listaCategorias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listaCategorias.SelectedItem != catPorDefecto)
            {
                ComboBoxItem seleccion = (ComboBoxItem)listaCategorias.SelectedItem;
                String cat = seleccion.Content.ToString();
                Database.mostrarPorCategoria(tablaProductos, cat);
            } else
            {
                if(tablaProductos != null)
                {
                    Database.rellenarTablaProductos(tablaProductos);
                }
                
            }
        }

        private void tablaProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tablaProductos.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)tablaProductos.SelectedItem;

                // Aquí puedes acceder a los datos de la fila seleccionada
                long id = Convert.ToInt64(selectedRow["id_producto"]);
                string nombre = selectedRow["nombre"].ToString();
                string desc = selectedRow["descripcion"].ToString();
                float precio = (float)(selectedRow["precio"]);
                string imagen = selectedRow["imagen_ref"].ToString();
                int stock = Convert.ToInt32(selectedRow["unidades_stock"].ToString());
                int categoria = Convert.ToInt32(selectedRow["id_categoria"].ToString());
                // Y así sucesivamente...

                // Luego, abre la ventana de detalles
                CRUDWindow detallesWindow = new CRUDWindow(id, nombre, desc, precio, imagen, stock, categoria);
                detallesWindow.ShowDialog();
            }
        }

        private void btnAgregarRegistro_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow(numCat);
            addWindow.ShowDialog();
        }
    }
}
