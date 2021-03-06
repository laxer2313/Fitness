﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister Formregister = new FormRegister();
            Formregister.ShowDialog();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin FormLogIn = new FormLogin();
            FormLogIn.ShowDialog();

            FormPanel f1 = new FormPanel();
            f1.ShowDialog();
        }
    }
}
