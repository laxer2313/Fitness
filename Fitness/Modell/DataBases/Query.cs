using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell.DataBases
{
    static class Query
    {
        static string GET_PASSWORD = "select haslo from osoby where email={0}";
        static string GET_USER = "select * from osoby where email={0} and haslo={1}";
        static string GET_CLASSESS = "select * from zajecia";
        static string ADD_USER = "insert osoby value({0}, {1}, {2}, {3}, {4], {5}, {6}, {7}, {8}, {9}, now(), {10}, {11})";

        public static string GetPassword(string email)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat(GET_PASSWORD, email);

            return query.ToString();
        }

        public static string GetUser(string email, string password)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat(GET_USER, email, password);
            return query.ToString();
        }

        public static string AddUser(User user)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat(ADD_USER, user.Email, user.Name, user.LastName, user.PhoneNumber, user.City, user.PosteCode,
                               user.Street, user.StreetNumber, user.ApartmentNumber, user.BirthdayDate, user.Sex, user.Password);
            return query.ToString();
        }

        public static string AddTestUser(string email, string pass)
        {
            // tak mozna pisac zapytania
            string xd = String.Format("insert osoby value(\"{0}\", \"imie\", \"nazw\", \"1234\", \"zab\", \"41-800\", \"sob\", \"12\", \"13\", \"1997-05-26\", now(), 'K', {1})", email, pass);
            return xd;
        }
    }
}
