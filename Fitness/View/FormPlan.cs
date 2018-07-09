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
    public partial class FormPlan : Form
    {
        TextBox[,] panel = new TextBox[7, 14];  

        public FormPlan()
        {
            InitializeComponent();
            for(int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    panel[i, j] = new TextBox();
                    panel[i, j].BackColor = Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
                    panel[i, j].Location = new Point(44 + j * 40, 109 + i * 105);
                    panel[i, j].Multiline = true;
                    panel[i, j].Name = (i+1).ToString()+" "+(j+1).ToString();
                    panel[i, j].ReadOnly = true;
                    panel[i, j].Size = new Size(98, 33);
                    panel[i, j].TabIndex = 38;
                    panel[i, j].Text = "";
                    panel[i, j].TextAlign = HorizontalAlignment.Center;
                    panel[i, j].Show();
                }
                
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
