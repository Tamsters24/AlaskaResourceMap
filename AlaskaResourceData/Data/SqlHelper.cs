using System;
using MySqlConnector;

namespace AlaskaResourceData.Data
{
    public class SqlHelper  //Instantiated in Program.cs
    {
        public static string ConnectStr;
        public static MySqlConnection GetConnection() {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectStr);
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
