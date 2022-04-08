using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;

namespace FocusLauncher.Controllers
{
    internal class DatabaseController
    {
        private readonly MySqlConnectionStringBuilder connectionData = new MySqlConnectionStringBuilder
        {
            Database = "frp_launcher",
            UserID = "root",
            Password = "",
            Server = "localhost",
            Port = 3306,
        };

        public void TestConnection()
        {
            try
            {
                MySqlConnection conn = new(connectionData.ConnectionString);
                conn.Open();
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection was not successful.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
