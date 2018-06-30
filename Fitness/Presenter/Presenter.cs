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
        View.IView view;

        public Presenter(Modell.Model model, View.IView view)
        {
            this.model = model;
            this.view = view;

            view.Login += login;
        }

        void login(string email, string password)
        {
            view.User = model.Login(email, password);
        }
    }
}
