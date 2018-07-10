using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness.Modell;

namespace Fitness
{
    public partial class FormRegister : Form
    {

        event Action<User> register;
        public FormRegister(Action<User> Register)
        {
            InitializeComponent();
            register += Register;
            comboBoxSex.DataSource = new List<string>{ "Kobieta", "Mężczyzna"};
            dateTimePickerDateOfBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateOfBirth.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            bool validmail = false, validPass;
            try
            {
                if (textBoxEmail.Text == "")
                    throw new Exception();
                MailAddress mail = new MailAddress(textBoxEmail.Text);
                validmail = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidłowy adres email!");
                validmail = false;
            }
            if (textBoxPassword.Text.Length >= 6)
                validPass = true;
            else
            {
                MessageBox.Show("Haslo musi byc dlugosci wiekszej od 5!");
                validPass = false;
            }

            if (validmail && validPass)
            {
                User user = new User();
                user.Email = textBoxEmail.Text.Trim();
                user.Name = textBoxName.Text.Trim();
                user.LastName = textBoxSurname.Text.Trim();
                user.PhoneNumber = textBoxPhone.Text.Trim();
                user.PosteCode = textBoxZipCode.Text.Trim();
                if (comboBoxSex.SelectedItem.ToString() == "Kobieta")
                {
                    user.Sex = "K";
                }
                else
                {
                    user.Sex = "M";
                }
                user.Street = textBoxStreet.Text.Trim();
                user.StreetNumber = textBoxNumberOfHouse.Text.Trim();
                user.City = textBoxCity.Text.Trim();
                user.ApartmentNumber = textBoxNumberOfFlat.Text.Trim();
                user.BirthdayDate = dateTimePickerDateOfBirth.Text;
                user.ClearPassword = textBoxPassword.Text;

                register(user);
            }
        }

    }
}
