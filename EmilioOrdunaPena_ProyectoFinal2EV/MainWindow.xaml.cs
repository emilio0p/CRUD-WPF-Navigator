using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmilioOrdunaPena_ProyectoFinal2EV.DB;
using EmilioOrdunaPena_ProyectoFinal2EV.Pages;
using MySqlX.XDevAPI.Common;

namespace EmilioOrdunaPena_ProyectoFinal2EV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String username;
        public MainWindow(String username)
        {
            InitializeComponent();
            Loaded += TuVentanaPrincipal_Loaded;
            this.username = username;
        }

        // Cargar una página inicialmente
        private void TuVentanaPrincipal_Loaded(object sender, RoutedEventArgs e)
        {
            // Establecer la página inicial aquí
            mainFrame.NavigationService.Navigate(new Home(username));
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
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

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {

            string messageBoxText = "¿Seguro que quieres cerrar la sesión?";
            string caption = "Cerrar sesión";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Exclamation;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            switch (result)
            {
                case MessageBoxResult.Cancel:
                    break;

                case MessageBoxResult.Yes:
                    Login login = new Login();
                    login.Show();
                    this.Close();
                    break;

                case MessageBoxResult.No:
                    break;
            }
            
        }

        private void NavigateToPage1(object sender, RoutedEventArgs e)
        {
            if (!(mainFrame.Content is Page1))
            {
                mainFrame.Navigate(new Page1());   
            }
        }

        
    }
}

