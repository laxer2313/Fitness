using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fitness.Modell.DataBases;

namespace Fitness.Modell
{
    class User
    {
        public User()
        {

        }
        public string Email { get; }
        public string Password { get; }
        public string Name { get; }
        public string LastName { get; }
        public string PhoneNumber { get; }
        public string City { get; }
        public string PosteCode { get; }
        public string Street { get; }
        public string StreetNumber { get; }
        public string ApartmentNumber { get; }
        public string BirthdayDate { get; }
        public string Sex { get; }

        public bool IsLoginValid(string email, string password)
        {
            var comand = Query.GetUser(email, password);
            return false;
        }
    }
}
