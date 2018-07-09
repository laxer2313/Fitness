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


        public List<Classes> GetClasses()
        {
            throw new NotImplementedException();
        }

        public void Login(string email, string password)
        {
            user = db.Login(email, password);
        }

        public void Register(User user)
        {
            db.AddUser(user);
        }
    }
}
