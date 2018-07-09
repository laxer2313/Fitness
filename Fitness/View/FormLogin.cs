using Fitness.Modell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class FormLogin : Form
    {
        public FormLogin(Action<string, string> login, Action panel, ValueWrapper<bool> EnableLogin )
        {
            InitializeComponent();
            this.login += login;
            this.panel += panel;
            this.EnableLogin = EnableLogin;
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        event Action<string, string> login;
        event Action panel;
        ValueWrapper<bool> EnableLogin;

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            login(textBoxEmail.Text, textBoxPassword.Text);
            if (EnableLogin == true)
            {
                Close();
                panel();
            }
        }
    }
}
