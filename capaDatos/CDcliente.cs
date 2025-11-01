using MySql.Data.MySqlClient;
using capaEntidad;
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
         string query = "INSERT INTO `clientes` (`Nombre`, `Apellido`, `Foto`) VALUES ('"+ cE.Nombre +"', '"+ cE.Apellido+ "', '"+ MySql.Data.MySqlClient.MySqlHelper.EscapeString(cE.foto) + "');";
         MySqlCommand comand = new MySqlCommand(query,conexion );
         comand.ExecuteNonQuery();
         conexion.Close();



        }
}
}

