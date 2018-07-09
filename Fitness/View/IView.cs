using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.View
{
    interface IView
    {
        event Action<string, string> Login;
        event Action<Modell.User> Register;
        
    }
}
