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
        // Objeto de conexion a la base de datos
        public static MySqlConnection conexion =
            new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=tiradepapeldb");


        // Metodo login a la tabla de usuarios
        public static Boolean LogIn(String username, String password)
        {
            // Variable que será devuelta
            Boolean respuesta = false;
            
               
            // Apertura de la conexión
            conexion.Open();

            // String de la consulta que se lanzará
            String consultaUser = "SELECT * FROM usuarios WHERE nombre_usuario = @username  AND contraseña = @password;";

            // Comando con la conexion
            MySqlCommand query = new MySqlCommand(consultaUser, conexion);

            // Se añaden los valores obtenidos a la query (esto es para hacerlo de una forma más segura)
            query.Parameters.AddWithValue("@username", username);
            query.Parameters.AddWithValue("@password", password);

            // Se crea el DataReader
            MySqlDataReader mySqlDataReader = query.ExecuteReader();

            // Si existe algún registro con estas credenciales se guarda el valor de la respuesta como true
            if(mySqlDataReader.Read())
            {
                respuesta = true;
            }
            
            // Se cierra la conexión y se devuelve la variable de la respuesta
            conexion.Close();
            return respuesta;
        }



        // Método para obtener la lista actual de categorías existentes
        public static List<String> obtenerCategorias()
        {
            // Variable colección para almacenar los nombres de las categorías
            List<String> listaCat = new List<string>();

            // Apertura de la conexión
            conexion.Open();

            // Consulta para obtener la lista de categorías
            String consultaCat = "SELECT nombre FROM categorias;";
            MySqlCommand mySqlCommand = new MySqlCommand(consultaCat, conexion);

            // Ejecución del DataReader
            MySqlDataReader mysqlDataReader = mySqlCommand.ExecuteReader();

            // Mientras que existan registros los va almacenando en la colección
            while(mysqlDataReader.Read())
            {
                listaCat.Add(mysqlDataReader.GetString(0)); // Solo la primera columna
            }

            // Cerrar la conexión y devolver la lista
            conexion.Close();
            return listaCat;
        }


        // Método para rellenar la tabla con todos los productos
        public static void rellenarTablaProductos(DataGrid dataGrid)
        {
            // Apertura de la conexión
            conexion.Open();
            
            // Consulta para obtener todos los productos
            String consultaProd = "SELECT * FROM productos;";

            // Creación del DataAdapter
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consultaProd, conexion);

            // Creación del DataTable
            DataTable dataTable = new DataTable();

            // Llenamos el DataTable mediante el DataAdapter
            mySqlDataAdapter.Fill(dataTable);
            dataGrid.ItemsSource = dataTable.DefaultView;

            // Cerrar la conexión
            conexion.Close();
        }


        // Método para buscar productos por nombre
        public static void buscarProducto(DataGrid dataGrid, String busqueda)
        {
            // Apertura de la conexión
            conexion.Open();

            // Consulta para obtener los productos con nombre parecido al obtenido
            String consultaProd = "SELECT * FROM productos WHERE nombre LIKE \"" + busqueda + "%\" ;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consultaProd, conexion);

            DataTable dataTable = new DataTable();

            mySqlDataAdapter.Fill(dataTable);

            dataGrid.ItemsSource = dataTable.DefaultView;

            // Cerrar la conexión
            conexion.Close();
        }


        // Método para mostrar productos por categoría
        public static void mostrarPorCategoria(DataGrid dataGrid, String categoria)
        {
            // Abre la conexión a la base de datos
            conexion.Open();

            // Consulta para obtener todos los productos de una categoría específica
            String consulta = "SELECT * FROM productos WHERE id_categoria = (SELECT id_categoria FROM categorias WHERE nombre=\"" + categoria + "\");";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consulta, conexion);

            // Llena un DataTable con los resultados de la consulta
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            // Asigna el DataTable como origen de datos para el DataGrid
            dataGrid.ItemsSource = dataTable.DefaultView;

            // Cierra la conexión a la base de datos
            conexion.Close();
        }


        // Método para actualizar la información de un producto
        public static void actualizarProducto(long id, string? nombre, string? desc, float precio, string? imagen, int stock, int categoria)
        {
            // Abre la conexión a la base de datos
            conexion.Open();

            // Consulta para actualizar la información de un producto específico
            string consulta = "UPDATE productos SET nombre = @Nombre, descripcion = @Descripcion, precio = @Precio, imagen_ref = @Imagen, unidades_stock = @Stock, id_categoria = @Categoria WHERE id_producto = @Id";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            // Asigna los parámetros a la consulta
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Descripcion", desc);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Imagen", imagen);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@Id", id);

            // Ejecuta la consulta de actualización
            cmd.ExecuteNonQuery();

            // Cierra la conexión a la base de datos
            conexion.Close();
        }


        // Método para borrar producto
        public static void borrarProducto(long id)
        {
            // Abre la conexión a la base de datos
            conexion.Open();

            // Consulta para eliminar un producto específico
            string consulta = "DELETE FROM productos WHERE id_producto = @Id";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            // Asigna el parámetro a la consulta
            cmd.Parameters.AddWithValue("@Id", id);

            // Ejecuta la consulta de eliminación
            cmd.ExecuteNonQuery();

            // Cierra la conexión a la base de datos
            conexion.Close();
        }


        // Método para agregar un nuevo producto
        public static void agregarProducto(string? nombre, string? desc, float precio, string? imagen, int stock, int categoria)
        {
            // Abre la conexión a la base de datos
            conexion.Open();

            // Consulta para agregar un nuevo producto
            string consulta = "INSERT INTO productos (nombre, descripcion, precio, imagen_ref, unidades_stock, id_categoria) VALUES (@Nombre, @Descripcion, @Precio, @Imagen, @Stock, @Categoria);";

            MySqlCommand cmd = new MySqlCommand(consulta, conexion);

            // Asigna los parámetros a la consulta
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Descripcion", desc);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Imagen", imagen);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@Categoria", categoria);

            // Ejecuta la consulta de inserción
            cmd.ExecuteNonQuery();

            // Cierra la conexión a la base de datos
            conexion.Close();
        }


        // Método para mostrar los productos sin stock
        public static void rellenarProductosSinStock(DataGrid dataGrid)
        {
            // Abre la conexión a la base de datos
            conexion.Open();

            // Consulta para obtener productos con stock cero
            String consultaProd = "SELECT * FROM productos WHERE unidades_stock = 0;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consultaProd, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            // Asigna el DataTable como origen de datos para el DataGrid
            dataGrid.ItemsSource = dataTable.DefaultView;

            // Cierra la conexión a la base de datos
            conexion.Close();
        }

        
        // Método para mostrar los productos más caros
        public static void rellenarProductosMasCaros(DataGrid dataGrid)
        {
            // Abre la conexión a la base de datos
            conexion.Open();

            // Consulta para obtener los 5 productos más caros
            String consultaProd = "SELECT * FROM productos ORDER BY precio DESC LIMIT 5;";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consultaProd, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            // Asigna el DataTable como origen de datos para el DataGrid
            dataGrid.ItemsSource = dataTable.DefaultView;

            // Cierra la conexión a la base de datos
            conexion.Close();
        }


        // Mostrar los productos más vendidos
        public static void rellenarProductosMasVendidos(DataGrid dataGrid)
        {
            // Abre la conexión a la base de datos
            conexion.Open();

            // Consulta para obtener los 5 productos más vendidos
            int[] arrayIds = new int[5];
            int i = 0;
            String consultaProd = "SELECT id_producto FROM detalles_pedido GROUP BY id_producto ORDER BY SUM(cantidad) DESC LIMIT 5;";
            MySqlCommand query1 = new MySqlCommand(consultaProd, conexion);
            MySqlDataReader reader1 = query1.ExecuteReader();

            // Obtiene los IDs de los productos más vendidos
            while (reader1.Read())
            {
                arrayIds[i++] = reader1.GetInt32(0);
            }

            reader1.Close();

            String ids = "";
            for (int a = 0; a < arrayIds.Length; a++)
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

            // Consulta para obtener información de los productos más vendidos
            String consulta2 = "SELECT * FROM productos WHERE id_producto IN (" + ids + ");";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consulta2, conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            // Asigna el DataTable como origen de datos para el DataGrid
            dataGrid.ItemsSource = dataTable.DefaultView;

            // Cierra la conexión a la base de datos
            conexion.Close();
        }

        public static void rellenarTablaClientes(DataGrid dataGrid)
        {
            conexion.Open();

            String consulta = "SELECT * FROM clientes";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(consulta,conexion);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            dataGrid.ItemsSource=dataTable.DefaultView;

            conexion.Close();
        }
    }
}
