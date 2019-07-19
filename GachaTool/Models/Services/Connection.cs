using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace GachaTool.Models.Services
{
    class Connection
    {
        private static string connectionKey;

        static Connection()
        {
            connectionKey= ConfigurationManager.ConnectionStrings["GachaDB"].ConnectionString;
        }

        public static MySqlConnection OpenLocal()
        {
            MySqlConnection connection = new MySqlConnection(connectionKey);
            connection.Open();

            return connection;
        }
    }
}
