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

        public static void actualizarProducto(long id, string? nombre, string? desc, float precio, string? imagen, int stock, int categoria)
        {
            conexion.Open();

            string consulta = "UPDATE productos SET nombre = @Nombre, descripcion = @Descripcion, precio = @Precio, imagen_ref = @Imagen, unidades_stock = @Stock, id_categoria = @Categoria WHERE id_producto = @Id";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Descripcion", desc);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Imagen", imagen);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();

            conexion.Close();


        }

        public static void borrarProducto(long id)
        {
            conexion.Open();

            string consulta = "DELETE FROM productos WHERE id_producto = @Id";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public static void agregarProducto(string? nombre, string? desc, float precio, string? imagen, int stock, int categoria)
        {
            conexion.Open();

            string consulta = "INSERT INTO productos (nombre, descripcion, precio, imagen_ref, unidades_stock, id_categoria) VALUES (@Nombre, @Descripcion, @Precio, @Imagen, @Stock, @Categoria);";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Descripcion", desc);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Imagen", imagen);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@Categoria", categoria);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public static void rellenarProductosSinStock(DataGrid dataGrid)
        {
            conexion.Open();

            String consultaProd = "SELECT * FROM productos WHERE unidades_stock = 0;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consultaProd, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGrid.ItemsSource = dataTable.DefaultView;
            conexion.Close();
        }

        public static void rellenarProductosMasCaros(DataGrid dataGrid)
        {
            conexion.Open();

            String consultaProd = "SELECT * FROM productos ORDER BY precio DESC LIMIT 5;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consultaProd, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGrid.ItemsSource = dataTable.DefaultView;
            conexion.Close();
        }

        public static void rellenarProductosMasVendidos(DataGrid dataGrid)
        {
            conexion.Open();
            int[] arrayIds = new int[5];
            int i = 0;
            // Consulta para obtener los id de los 5 productos más vendidos
            String consultaProd = "SELECT id_producto FROM detalles_pedido GROUP BY id_producto ORDER BY SUM(cantidad) DESC LIMIT 5;";
            MySqlCommand query1 = new MySqlCommand(consultaProd, conexion);
            MySqlDataReader reader1 = query1.ExecuteReader();
            while (reader1.Read())
            {
                arrayIds[i++] = reader1.GetInt32(0);
            }

            reader1.Close();

            String ids = "";
            for(int a =0; a< arrayIds.Length; a++)
            {
                if (a + 1 >= arrayIds.Length)
                {
                    ids += arrayIds[a];
                }
                else
                {
                    ids += arrayIds[a] + ", ";
                }
                
            }

            String consulta2 = "SELECT * FROM productos WHERE id_producto IN (" + ids + ");";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consulta2, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGrid.ItemsSource = dataTable.DefaultView;

            conexion.Close();
        }
    }
}
