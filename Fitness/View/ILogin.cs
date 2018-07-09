using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.View
{
    interface ILogin
    {
        string Email { get; set; }
        string Password { get; set; }
        bool CanLogin { get; set; }
    }
}
