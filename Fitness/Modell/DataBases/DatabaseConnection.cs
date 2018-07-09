using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;


namespace Fitness.Modell.DataBases
{
    class DatabaseConnection : IDisposable
    {
        private MySqlConnection _connection;

        public enum OpenConnectionResult
        {
            ServerNotAvailable, UnknownError, OK
        }

        public DatabaseConnection(string server, string database, string uid, string password)
        {
            _connection = new MySqlConnection();
            _connection.ConnectionString = String.Format("Server={0}; database={1}; UID={2}; password={3}; sslmode=none",
                server, database, uid, password);
        }

        public OpenConnectionResult Open()
        {
            try
            {
                _connection.Open();
                return OpenConnectionResult.OK;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0: return OpenConnectionResult.ServerNotAvailable;
                    default: return OpenConnectionResult.UnknownError;
                }
            }
        }

        public void Close()
        {
            _connection.Close();
        }
        public void Dispose()
        {
            Close();
        }

        public string ExecuteProcedure(string procedure)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = _connection;
                cmd.CommandText = procedure;
                try
                {
                    cmd.ExecuteNonQuery();
                    return "Możesz się zalogować";
                }
                catch (Exception)
                {
                    return "Taki użytkownik już istnieje!";
                }
                
            }
        }
    }
}
