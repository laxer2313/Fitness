using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell.DataBases
{
    static class Query
    {
        static string GET_PASSWORD = "select haslo from osoby where email='{0}'";
        static string GET_USER = "select * from osoby where email = '{0}' and haslo = '{1}'";
        static string GET_CLASSESS = "select id, nazwa, godzina_rozpoczecia, ilosc_miejsc, dzien_tygodnia, concat(imie, \" \", nazwisko) from zajecia z, osoby o where z.email = o.osoby";
        static string ADD_USER = "insert osoby value('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', now(), '{10}', '{11}')";
        static string GET_NAME = "select concat(imie, ' ', nazwisko) from osoby where email = '{0}'";

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
            query.AppendFormat(ADD_USER, user.Email, user.Name, user.LastName, user.PhoneNumber, user.City, user.PosteCode, user.Street, user.StreetNumber, user.ApartmentNumber, user.BirthdayDate, user.Sex, user.HashPawssword);
            return query.ToString();
        }
        public static string GetClasses()
        {
            return GET_CLASSESS;
        }
        public static string GetName(string email)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat(GET_NAME, email);
            return query.ToString();
        }
    }
}
