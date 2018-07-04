using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.View
{
    interface IFormLogin
    {
        event Action<string, string> Login;
    }
}
