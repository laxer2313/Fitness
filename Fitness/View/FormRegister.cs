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
            User user = new User();
            user.Email = textBoxEmail.Text;
            user.Name = textBoxName.Text;
            user.LastName = textBoxSurname.Text;
            user.PhoneNumber = textBoxPhone.Text;
            user.PosteCode = textBoxZipCode.Text;
            if(comboBoxSex.SelectedItem.ToString() == "Kobieta")
            {
                user.Sex = "K";
            }
            else
            {
                user.Sex = "M";
            }
            user.Street = textBoxStreet.Text;
            user.StreetNumber = textBoxNumberOfHouse.Text;
            user.City = textBoxCity.Text;
            user.ApartmentNumber = textBoxNumberOfFlat.Text;
            user.BirthdayDate = dateTimePickerDateOfBirth.Text;
            user.ClearPassword = textBoxPassword.Text;

            register(user);
        }

    }
}
