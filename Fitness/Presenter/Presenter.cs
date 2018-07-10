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
            view.GetClasses += GetClasses;
        }

        void Login(string email, string password)
        {
            model.Login(email, password);
            view.LoginEnable = model.HaveUser;
            if (model.HaveUser)
                view.Panel();
            else view.Comunicat("Bledne dane logowania", "Blad w wprowadzonych danych");
        }

        void Register(User user)
        {
            if(model.Register(user))
            {
                view.Comunicat("Rejestracja zakonczyla sie powodzeniem!", "Zakonczenie rejestracji");
            }
            else
                view.Comunicat("Rejestracja zakonczyla sie niepowodzeniem!", "Blad w wprowadzonych danych");


        }

        void GetClasses()
        {
            view.DataClasses = model.GetClasses();
        }
    }
}
