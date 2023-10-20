using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Perpus
{
    class DbConnection
    {
        string connectionString = "Server=127.0.0.1;Database=perpus-db;uid=root;Password=;";

        private MySqlConnection _connection;

        public DbConnection()
        {
            Console.WriteLine("Connecting to database..");
            try
            {
                _connection = new MySqlConnection(connectionString);
                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                    Console.WriteLine("Connecting to database success.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : "+ e.Message);
            }
        }


        public void Close()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
                _connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
