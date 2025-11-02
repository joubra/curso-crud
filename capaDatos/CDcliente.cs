using capaEntidad;
using MySql.Data.MySqlClient;
using System.Data;
namespace capaDatos
{
    public class CDcliente
    {
        string cadenaConexion = "Server=localhost; User=root; Password=123456; Port=3306; database=cursocs";
        public void pruebaConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                Console.WriteLine("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion: " + ex.Message);
                return;
            }
            MessageBox.Show("Conexion exitosa");
        }
        public void crear(CEClientes cE)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            string query = "INSERT INTO `clientes` (`Nombre`, `Apellido`, `Foto`) VALUES ('" + cE.Nombre + "', '" + cE.Apellido + "', '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.foto) + "');";
            MySqlCommand comand = new MySqlCommand(query, conexion);
            comand.ExecuteNonQuery();
            conexion.Close();



        }
        public void Editar(CECliente cE)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "UPDATE `clientes` SET `nombre`='" + cE.Nombre + "', `apellido`='" + cE.Apellido + "', `foto`='" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.Foto) + "' WHERE  `id`=" + cE.Id + ";";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Actualizado!");


        }

        public DataSet Listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string Query = "SELECT * FROM `clientes` LIMIT 1000;";
            MySqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();

            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(dataSet, "tbl");

            return dataSet;
        }
    }
}

