using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness.View;
using Fitness.Modell;

namespace Fitness.Presenter
{
    class Presenter
    {
        IModel model;
        IView view;

        public Presenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
            view.Register += Register;
            view.Login += Login;
        }

        void Login(string email, string password)
        {
            model.Login(email, password);
        }

        void Register(User user)
        {
            model.Register(user);
            //test
        }
    }
}
