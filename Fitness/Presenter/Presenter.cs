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
        View.IFormLogin formLogin;
        View.IFormMainMenu formMainMenu;
        View.IFormPanel formPanel;
        View.IFormPlan formPlan;
        View.IFormRegister formRegister;

        public Presenter(Modell.Model model)
        {
            this.model = model;
            //this.formLogin = formLogin;
            //this.formMainMenu = formMainMenu;
            //this.formPanel = formPanel;
            //this.formPlan = formPlan;
            //this.formRegister = formRegister;

            //formLogin.Login += Login;
        }

        void Login(string email, string password)
        {
            model.Login(email, password);
        }
    }
}
