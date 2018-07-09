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
    public partial class FormPanel : Form
    {
        public FormPanel()
        {
            InitializeComponent();
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            FormPlan plan = new FormPlan();
            plan.ShowDialog();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            View.FormBuy kup = new View.FormBuy();
            kup.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
