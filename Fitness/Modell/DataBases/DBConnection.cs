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
            User user = new User();
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
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                password = hashedInputStringBuilder.ToString();
            }
            if (password == getpassword)
                return getUser(email);
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


        User getUser(string email)
        {
            List<string> list = new List<string>();

            connection = new MySqlConnection(conStrBuilder.ConnectionString);
            command = new MySqlCommand(Query.GetUser(email), connection);

            try
            {
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                dataReader.Read();
                for (int i = 0; i < 13; i++)
                    list.Add(dataReader[i].ToString());
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

        List<Classes> GetClasses()
        {
            List<Classes> list = new List<Classes>();

            connection = new MySqlConnection(conStrBuilder.ConnectionString);
            command = new MySqlCommand(Query.GetClasses(), connection);

            try
            {
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Classes classes = new Classes(dataReader);
                    list.Add(classes);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
    }
}
