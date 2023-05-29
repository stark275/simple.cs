using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace winform1.Data
{
    class Database
    {
        private readonly MySqlConnection _connexion;
        public MySqlConnection Connection
        {
            get { return _connexion; }
        }
        public Database(string server, string username, string password, string database)
        {
            string connectionString = String.Format("server={0};uid={1};pwd={2};database={3}", server, username, password, database);
            this._connexion = new MySqlConnection(connectionString);
        }

        public DataTable Read(string query)
        {
            Connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, this.Connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable datatable = new DataTable();
            datatable.Load(dataReader);
            Connection.Close();

            return datatable;
        }

        public DataTable Login(string username, string password)
        {
            Connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from users where username = @Username and password = @Password", this.Connection);
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar, 20).Value = username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar, 20).Value = password;
            MySqlDataReader dataReader = cmd.ExecuteReader();
            DataTable datatable = new DataTable();
            datatable.Load(dataReader);
            Connection.Close();

            return datatable;
        }


    }
}
