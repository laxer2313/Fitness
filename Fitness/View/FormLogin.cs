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
        public FormLogin(Action<string, string> login, Action panel)
        {
            InitializeComponent();
            this.login += login;
            this.panel += panel;
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        event Action<string, string> login;
        event Action panel;

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            login(textBoxEmail.Text, textBoxPassword.Text);
            Hide();
            panel();
            Close();
            
        }
    }
}
