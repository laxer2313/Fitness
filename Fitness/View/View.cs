using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness.Modell;

namespace Fitness.View
{
    class View : IView
    {
        Menu menu;

        public event Action<string, string> Login;
        public event Action<User> Register;

        public void Run()
        {
            Application.Run(new Menu(Login, Register));
        }
    }
}
