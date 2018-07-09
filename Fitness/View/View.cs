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

        public event Action<string, string> Login;
        public event Action<User> Register;
        event Action _login;

        Menu menu;
        public View()
        {
            menu = new Menu(login, Register);
        }

        public void Run()
        {
            Application.Run(menu);
        }

        void login()
        {
            FormLogin formLogin = new FormLogin(Login, panel);
            menu.Hide();
            formLogin.ShowDialog();
            menu.Show();

        }

        void panel()
        {
            FormPanel formPanel = new FormPanel();
            formPanel.ShowDialog();
        }
    }
}
