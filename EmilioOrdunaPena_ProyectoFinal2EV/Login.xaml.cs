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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmilioOrdunaPena_ProyectoFinal2EV.DB;

namespace EmilioOrdunaPena_ProyectoFinal2EV
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }



        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            String user = txtUsuario.Text;
            String pass = txtContraseña.Password;

            if (user.Length<=0 || pass.Length<=0)
            {
                MessageBox.Show("Debes rellenar todos los campos...");
            } else
            {
                if(DB.Database.LogIn(user, pass)){
                    txtFalloInicio.Visibility = Visibility.Collapsed;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                } else
                {
                    txtFalloInicio.Visibility = Visibility.Visible;
                }
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
