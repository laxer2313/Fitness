using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell
{
    interface IModel
    {
        void Login(string email, string password);

        void Register(User user);

        List<Classes> GetClasses();
        ValueWrapper<bool> HaveUser { get; }

    }
}
