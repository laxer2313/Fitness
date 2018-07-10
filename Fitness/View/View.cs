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
        public event Action GetClasses;

        Menu menu;
        public View()
        {
            menu = new Menu(login, Register);
        }

        public void Run()
        {
            menu.register += Register;
            Application.Run(menu);
        }

        void login()
        {
            FormLogin formLogin = new FormLogin(Login, Panel, LoginEnable);
            menu.Hide();
            formLogin.ShowDialog();
            try
            {
                menu.Show();
            }
            catch (Exception e)
            {

            }
        }

        public void Panel()
        {
            GetClasses();
            FormPanel formPanel = new FormPanel(DataClasses);
            formPanel.ShowDialog();
        }
        public void Comunicat(string text, string text2)
        {
            MessageBox.Show(text, text2, MessageBoxButtons.OK);
        }

        public ValueWrapper<bool> LoginEnable { get; set; }

        public List<Classes> DataClasses { set; private get; }
    }
}
