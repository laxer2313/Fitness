using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell
{
    interface IModel
    {
        User Login(string email, string password);
        

    }
}
