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
        public FormLogin(Action<string, string> login)
        {
            InitializeComponent();
            this.login += login;
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        event Action<string, string> login;

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            login(textBoxEmail.Text, textBoxPassword.Text);
        }
    }
}
