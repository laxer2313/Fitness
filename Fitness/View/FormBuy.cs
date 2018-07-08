using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness.View
{
    public partial class FormBuy : Form
    {
        public FormBuy()
        {
            InitializeComponent();
            comboBoxType.Items.Add("Miesięczny");
            comboBoxType.Items.Add("Jednorazowy");
            comboBoxType.Items.Add("10 wejść");
            this.dateTimePicker1.MinDate = System.DateTime.Now;
            this.dateTimePicker1.Value = System.DateTime.Now;
            textBoxPrice.Text = obliczCene(comboBoxType.Text, checkBoxUlga).ToString() + " zł";

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "Jednorazowy")
            {
                labelDate.Hide();
                dateTimePicker1.Hide();
                textBoxPrice.Text = obliczCene(comboBoxType.Text, checkBoxUlga).ToString() + " zł";
            }
            else if(comboBoxType.Text == "Miesięczny")
            {
                labelDate.Show();
                dateTimePicker1.Show();
                textBoxPrice.Text = obliczCene(comboBoxType.Text, checkBoxUlga).ToString() + " zł";
            }
            else
            {
                labelDate.Hide();
                dateTimePicker1.Hide();
                textBoxPrice.Text = obliczCene(comboBoxType.Text, checkBoxUlga).ToString() + " zł";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int obliczCene(string typ, CheckBox ulga)
        {
            int cena=0;

            if(checkBoxUlga.Checked)
            {
                if (typ == "Miesięczny") cena = 50;
                else if (typ == "Jednorazowy") cena = 10;
                else cena = 40;
            }
            else
            {
                if (typ == "Miesięczny") cena = 70;
                else if (typ == "Jednorazowy") cena = 15;
                else cena = 55;
            }

            return cena;
        }

        private void checkBoxUlga_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = obliczCene(comboBoxType.Text, checkBoxUlga).ToString() + " zł";
        }
    }
}
