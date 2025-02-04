using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1._0
{
    internal class BDAirport
    {
        MySqlConnection connection = new MySqlConnection("server=sql11.freesqldatabase.com;port=3306;username=sql11704821;password=3M4qGq2qzI;database=sql11704821; charset=utf8");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
