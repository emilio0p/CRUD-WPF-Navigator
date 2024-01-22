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
    /// Lógica de interacción para AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            string name = txtNombre.Text;
            int cate = Convert.ToInt32(txtCategoria.Text);
            string img = txtImagen.Text;
            string des = txtDesc.Text;
            int units = Convert.ToInt32(txtStock.Text);
            float price = float.Parse(txtPrecio.Text);
            Database.agregarProducto(name,des,price,img,units,cate);
            this.Close();
        }
    }
}
