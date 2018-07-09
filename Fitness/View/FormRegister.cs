using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

using Fitness.Modell.DataBases;
using Fitness.Presenter;
using Fitness.Modell;
using Fitness.View;

namespace Fitness
{
    public partial class FormRegister : Form, IRegister
    {
        public FormRegister()
        {
            InitializeComponent();
            comboBoxSex.Items.Add('K');
            comboBoxSex.Items.Add('M');
            dateTimePickerDateOfBirth.MaxDate = DateTime.Today;

        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            // to jest tylko do testowania zapytan

            
            bool validmail;
            var dbc = new DatabaseConnection("localhost", "fitness", "root", "");
            MessageBox.Show(dbc.Open().ToString());
            if (textBoxEmail.Text != "" && textBoxPassword.Text != "")
            {
                try
                {
                    MailAddress mail = new MailAddress(textBoxEmail.Text);
                    validmail = true;
                }
                catch (FormatException)
                {

                    MessageBox.Show("Nieprawidłowy adres email!");
                    validmail = false;
                }

                if (validmail == true)
                {
                    string wynik;
                    string plec="";
                    string datadzien = dateTimePickerDateOfBirth.Text.Remove(2, 8);
                    string datamiesiac = (dateTimePickerDateOfBirth.Text.Remove(5, 5)).Remove(0, 3);
                    string datarok = dateTimePickerDateOfBirth.Text.Remove(0, 6);
                    string data = datadzien + "-" + datamiesiac + "-" + datarok;
                    if(comboBoxSex.SelectedText.ToString() == "")
                    {
                        wynik = dbc.ExecuteProcedure(Query.AddUser(textBoxName.Text, textBoxSurname.Text, textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, textBoxNumberOfHouse.Text, textBoxNumberOfFlat.Text, textBoxEmail.Text, textBoxZipCode.Text, textBoxPassword.Text, data, plec));
                        
                    }   
                    else
                    {
                        plec = comboBoxSex.SelectedText.ToString();
                        wynik = dbc.ExecuteProcedure(Query.AddUser(textBoxName.Text, textBoxSurname.Text, textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, textBoxNumberOfHouse.Text, textBoxNumberOfFlat.Text, textBoxEmail.Text, textBoxZipCode.Text, textBoxPassword.Text, data, plec));
                    }

                    
                    MessageBox.Show(wynik);
                    if (wynik == "Możesz się zalogować")
                    {
                        this.Close();
                    }
                    
                }

            }
            else MessageBox.Show("Adres email i hasło są wymagane");

        }
    }
}
