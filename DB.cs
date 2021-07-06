using MySql.Data.MySqlClient;
using System.Data;

namespace parolchiki
{
    internal class DB
    {
        private readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=mainbase");

        public void openconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeconnection()
        {
            connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void regetaccounts()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `accounts`", getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
    }
}
