using Fitness.Modell;
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
        event Action<User> Register;
        event Action GetClasses;
        void Panel();
        void Comunicat(string text);
        
        ValueWrapper<bool> LoginEnable { get; set; }

        List<Classes> DataClasses { set; }

    }
}
