using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell
{
    public class User
    {
        string hashPassword;
        public User(List<string> list)
        {
            Email = list[0];
            Name = list[1];
            LastName = list[2];
            PhoneNumber = list[3];
            City = list[4];
            PosteCode = list[5];
            Street = list[6];
            StreetNumber = list[7];
            ApartmentNumber = list[8];
            BirthdayDate = list[9];
            Sex = list[11];
            HashPawssword = list[12];
        }
        public User()
        {
        }
        public string Email { get; set; }
        public string ClearPassword { set; private get; }
        public string HashPawssword {
            set
            {
                hashPassword = value;
            }
            get
            {
                if (hashPassword != null)
                    return hashPassword;
                else if (ClearPassword == null)
                    return null;
                else
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(ClearPassword);
                    ClearPassword = null;
                    using (var hash = System.Security.Cryptography.SHA512.Create())
                    {
                        var hashedInputBytes = hash.ComputeHash(bytes);
                        var hashedInputStringBuilder = new StringBuilder(128);
                        foreach (var b in hashedInputBytes)
                            hashedInputStringBuilder.Append(b.ToString("X2"));
                        return hashedInputStringBuilder.ToString();
                    }
                }
            }
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string PosteCode { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string BirthdayDate { get; set; }
        public string Sex { get; set; }   
    }
}
