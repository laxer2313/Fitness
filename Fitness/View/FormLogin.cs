using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Fitness.Modell.DataBases;
using Fitness.Presenter;
using Fitness.Modell;
using Fitness.View;

namespace Fitness
{
    public partial class FormLogin : Form, ILogin
    {
        private readonly LoginPresenter _loginPresenter;

        public FormLogin()
        {
            InitializeComponent();
            var model = new User();
            _loginPresenter = new LoginPresenter(this, model);
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Email { get { return textBoxEmail.Text; } set { textBoxEmail.Text = value; } }
        public string Password { get { return textBoxEmail.Text; } set { textBoxEmail.Text = value; } }
        public bool CanLogin { get; set; }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            // to jest tylko do testowania zapytan
            var dbc = new DatabaseConnection("localhost", "fitness", "root", "");
            //MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost; database=fitness; UID=root; password=; sslmode=none");
            //connection.Open();
            MessageBox.Show(dbc.Open().ToString());
            dbc.ExecuteProcedure(Query.AddTestUser("admin", "123"));
            MessageBox.Show("XD");
            

            // koniec testowania zapytan


            _loginPresenter.Login();
            if (!CanLogin)
            {
                // uzytkownik nie istnieej wiec informacja ze zle passy
                MessageBox.Show("Username or password are wrong");
                return;
            }
            // uzytkownik istnieje wiec przenosi do panelu
            FormPanel Main = new FormPanel();
            Main.ShowDialog();
        }
    }
}
