using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Presenter
{
    class Presenter
    {
        Modell.IModel model;


        public Presenter(Modell.Model model)
        {
            this.model = model;
        }

        void Login(string email, string password)
        {
            model.Login(email, password);
        }
    }
}
