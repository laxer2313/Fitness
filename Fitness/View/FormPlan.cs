using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness.Modell;
namespace Fitness
{
    public partial class FormPlan : Form
    {
        TextBox[,] panel = new TextBox[7, 14];  

        public FormPlan(List<Classes> classes)
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    panel[i, j] = new TextBox();
                    panel[i, j].Enabled = false;
                    panel[i, j].Location = new Point(44 + j * 40, 109 + i * 105);
                    panel[i, j].Multiline = true;
                    panel[i, j].Name = (i+1).ToString()+" "+(j+1).ToString();
                    panel[i, j].ReadOnly = true;
                    panel[i, j].Size = new Size(98, 33);
                    panel[i, j].Text = "";
                    panel[i, j].TextAlign = HorizontalAlignment.Center;
                    panel[i, j].Show();
                    tableLayoutPanel1.Controls.Add(panel[i, j], i + 1, j + 1);
                }
            }
            foreach(var p in classes)
            {
                uint i = p.NumberOfDay-1;
                uint j = uint.Parse(p.StartTime.Substring(0,2)) - 7;
                panel[i, j].Text = p.Name + "\r\n" + p.Instructor;
                if(p.Places-p.TakenPlaces==0)
                    panel[i,j].BackColor = Color.FromArgb(172, 30, 30);
                else if(p.Places - p.TakenPlaces < 3)
                    panel[i, j].BackColor = Color.FromArgb(187, 97, 97);
                else
                    panel[i, j].BackColor = Color.FromArgb(187, 132, 132);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
