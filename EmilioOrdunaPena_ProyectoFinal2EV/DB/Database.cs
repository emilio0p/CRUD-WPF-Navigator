using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EmilioOrdunaPena_ProyectoFinal2EV.DB
{
    public class Database
    {
        // Objeto conexion a la base de datos
        public static MySqlConnection conexion =
            new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=tiradepapeldb");


        // Metodo login a la tabla de usuarios
        public static Boolean LogIn(String username, String password)
        {
            Boolean respuesta = false;
            
               
            
            conexion.Open();
            String consultaUser = "SELECT * FROM usuarios WHERE nombre_usuario = @username  AND contraseña = @password;";

            MySqlCommand query = new MySqlCommand(consultaUser, conexion);

            query.Parameters.AddWithValue("@username", username);
            query.Parameters.AddWithValue("@password", password);

            MySqlDataReader mySqlDataReader = query.ExecuteReader();

            if(mySqlDataReader.Read())
            {
                respuesta = true;
            }
            

            conexion.Close();
            return respuesta;
        }

        public static List<String> obtenerCategorias()
        {
            List<String> listaCat = new List<string>();
            conexion.Open();
            String consultaCat = "SELECT nombre FROM categorias;";
            MySqlCommand mySqlCommand = new MySqlCommand(consultaCat, conexion);
            MySqlDataReader mysqlDataReader = mySqlCommand.ExecuteReader();

            while(mysqlDataReader.Read())
            {
                listaCat.Add(mysqlDataReader.GetString(0));
            }

            conexion.Close();
            return listaCat;
        }

        public static void rellenarTablaProductos(DataGrid dataGrid)
        {
            conexion.Open();
            
            String consultaProd = "SELECT * FROM productos;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consultaProd, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGrid.ItemsSource = dataTable.DefaultView;
            conexion.Close();
        }

        public static void buscarProducto(DataGrid dataGrid, String busqueda)
        {
            conexion.Open();

            String consultaProd = "SELECT * FROM productos WHERE nombre LIKE \"" + busqueda + "%\" ;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consultaProd, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGrid.ItemsSource = dataTable.DefaultView;
            conexion.Close();
        }

        public static void mostrarPorCategoria(DataGrid dataGrid, String categoria)
        {
            conexion.Open();

            String consulta = "SELECT * FROM productos WHERE id_categoria = (SELECT id_categoria FROM categorias WHERE nombre=\"" + categoria + "\");";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consulta, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGrid.ItemsSource= dataTable.DefaultView;
            conexion.Close();
        }
    }
}
