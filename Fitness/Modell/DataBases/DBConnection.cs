using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fitness.Modell.DataBases
{
    class DBConnection
    {
        static string SERVER = "localhost";
        static string USER = "root";
        static string PASSWD = "";
        static string DATABASE = "fitness";
        static uint PORT = 3306;

        private MySqlConnectionStringBuilder conStrBuilder;
        private MySqlConnection connection;
        private MySqlCommand command;
        public DBConnection()
        {
            conStrBuilder = new MySqlConnectionStringBuilder();
            conStrBuilder.Server = SERVER;
            conStrBuilder.UserID = USER;
            conStrBuilder.Password = PASSWD;
            conStrBuilder.Database = DATABASE;
            conStrBuilder.Port = PORT;
            conStrBuilder.SslMode = MySqlSslMode.None;
        }


        public User Login(string email, string password)
        {
            connection = new MySqlConnection(conStrBuilder.ConnectionString);
            command = new MySqlCommand(Query.GetPassword(email), connection);

            string getpassword = "";
            try
            {
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                dataReader.Read();
                getpassword = dataReader[0].ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                connection.Close();
            }

            if (password == getpassword)
                return getUser(email, password);
            else return null;
        }

        public void AddUser(User user)
        {
            connection = new MySqlConnection(conStrBuilder.ConnectionString);
            command = new MySqlCommand(Query.AddUser(user), connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        User getUser(string email, string password)
        {
            List<string> list = new List<string>();

            connection = new MySqlConnection(conStrBuilder.ConnectionString);
            StringBuilder query = new StringBuilder();
            command = new MySqlCommand(Query.GetUser(email, password), connection);

            try
            {
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                dataReader.Read();
                foreach(var par in dataReader)
                list.Add(par.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                connection.Close();
            }
            User user = new User(list);

            return user;
        }
    }
}
