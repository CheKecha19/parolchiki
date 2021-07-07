using MySql.Data.MySqlClient;

namespace parolchiki
{
    internal class DB
    {
        private readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=mainbase");

        public void openconnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            else
            {
                closeconnection();
                openconnection();
            }
        }

        public void closeconnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
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
