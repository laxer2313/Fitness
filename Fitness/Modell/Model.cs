using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell
{
    class Model : IModel
    {
        DataBases.DBConnection db;
        User user;
        public Model()
        {
            db = new DataBases.DBConnection();
        }
        public ValueWrapper<bool> HaveUser
        {
            get
            {
                if (user == null)
                    return new ValueWrapper<bool>(false);
                else return new ValueWrapper<bool>(true);
            }
        }

        public List<Classes> GetClasses()
        {
            return db.GetClasses();
        }

        public void Login(string email, string password)
        {
            user = db.Login(email, password);
        }

        public bool Register(User user)
        {
            return db.AddUser(user);
        }
    }
}
