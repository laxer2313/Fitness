namespace Fitness
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelNumberOfHouse = new System.Windows.Forms.Label();
            this.labelNumberOfFlat = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfHouse = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfFlat = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.pictureBoxSmallLogo = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatAppearance.BorderSize = 2;
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Red;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(82, 524);
            this.buttonBackToMainMenu.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(128, 51);
            this.buttonBackToMainMenu.TabIndex = 0;
            this.buttonBackToMainMenu.Text = "Wróć";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelName.Location = new System.Drawing.Point(14, 107);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Imie";
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.FlatAppearance.BorderSize = 2;
            this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.buttonCreateUser.ForeColor = System.Drawing.Color.Red;
            this.buttonCreateUser.Location = new System.Drawing.Point(264, 524);
            this.buttonCreateUser.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(128, 51);
            this.buttonCreateUser.TabIndex = 4;
            this.buttonCreateUser.Text = "Stwórz konto";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelSurname.Location = new System.Drawing.Point(14, 140);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(86, 20);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelEmail.Location = new System.Drawing.Point(14, 338);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 20);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "E-mail";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelPhone.Location = new System.Drawing.Point(14, 173);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(70, 20);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Telefon";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelCity.Location = new System.Drawing.Point(14, 206);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(110, 20);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "Miejscowość";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelStreet.Location = new System.Drawing.Point(14, 239);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(49, 20);
            this.labelStreet.TabIndex = 9;
            this.labelStreet.Text = "Ulica";
            // 
            // labelNumberOfHouse
            // 
            this.labelNumberOfHouse.AutoSize = true;
            this.labelNumberOfHouse.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelNumberOfHouse.Location = new System.Drawing.Point(14, 272);
            this.labelNumberOfHouse.Name = "labelNumberOfHouse";
            this.labelNumberOfHouse.Size = new System.Drawing.Size(113, 20);
            this.labelNumberOfHouse.TabIndex = 10;
            this.labelNumberOfHouse.Text = "Numer domu";
            // 
            // labelNumberOfFlat
            // 
            this.labelNumberOfFlat.AutoSize = true;
            this.labelNumberOfFlat.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelNumberOfFlat.Location = new System.Drawing.Point(14, 305);
            this.labelNumberOfFlat.Name = "labelNumberOfFlat";
            this.labelNumberOfFlat.Size = new System.Drawing.Size(160, 20);
            this.labelNumberOfFlat.TabIndex = 11;
            this.labelNumberOfFlat.Text = "Numer mieszkania";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelZipCode.Location = new System.Drawing.Point(14, 371);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(122, 20);
            this.labelZipCode.TabIndex = 12;
            this.labelZipCode.Text = "Kod pocztowy";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelPassword.Location = new System.Drawing.Point(14, 404);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 20);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Hasło";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelDateOfBirth.Location = new System.Drawing.Point(14, 437);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(134, 20);
            this.labelDateOfBirth.TabIndex = 14;
            this.labelDateOfBirth.Text = "Data urodzenia";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelSex.Location = new System.Drawing.Point(14, 470);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(40, 20);
            this.labelSex.TabIndex = 15;
            this.labelSex.Text = "Płeć";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxName.Location = new System.Drawing.Point(182, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(264, 27);
            this.textBoxName.TabIndex = 16;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxSurname.Location = new System.Drawing.Point(182, 140);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(264, 27);
            this.textBoxSurname.TabIndex = 18;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxPhone.Location = new System.Drawing.Point(182, 173);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(264, 27);
            this.textBoxPhone.TabIndex = 19;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxCity.Location = new System.Drawing.Point(182, 206);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(264, 27);
            this.textBoxCity.TabIndex = 20;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxStreet.Location = new System.Drawing.Point(182, 239);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(264, 27);
            this.textBoxStreet.TabIndex = 21;
            // 
            // textBoxNumberOfHouse
            // 
            this.textBoxNumberOfHouse.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxNumberOfHouse.Location = new System.Drawing.Point(182, 272);
            this.textBoxNumberOfHouse.Name = "textBoxNumberOfHouse";
            this.textBoxNumberOfHouse.Size = new System.Drawing.Size(264, 27);
            this.textBoxNumberOfHouse.TabIndex = 22;
            // 
            // textBoxNumberOfFlat
            // 
            this.textBoxNumberOfFlat.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxNumberOfFlat.Location = new System.Drawing.Point(182, 305);
            this.textBoxNumberOfFlat.Name = "textBoxNumberOfFlat";
            this.textBoxNumberOfFlat.Size = new System.Drawing.Size(264, 27);
            this.textBoxNumberOfFlat.TabIndex = 23;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxEmail.Location = new System.Drawing.Point(182, 338);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(264, 27);
            this.textBoxEmail.TabIndex = 24;
            //this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox1_Validated);
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxZipCode.Location = new System.Drawing.Point(182, 371);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(264, 27);
            this.textBoxZipCode.TabIndex = 25;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(182, 404);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(264, 27);
            this.textBoxPassword.TabIndex = 26;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(182, 437);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(264, 27);
            this.dateTimePickerDateOfBirth.TabIndex = 27;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(182, 470);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(264, 28);
            this.comboBoxSex.TabIndex = 28;
            // 
            // pictureBoxSmallLogo
            // 
            this.pictureBoxSmallLogo.Image = global::Fitness.Properties.Resources._2;
            this.pictureBoxSmallLogo.Location = new System.Drawing.Point(-6, -224);
            this.pictureBoxSmallLogo.Name = "pictureBoxSmallLogo";
            this.pictureBoxSmallLogo.Size = new System.Drawing.Size(436, 314);
            this.pictureBoxSmallLogo.TabIndex = 17;
            this.pictureBoxSmallLogo.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(477, 587);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNumberOfFlat);
            this.Controls.Add(this.textBoxNumberOfHouse);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelNumberOfFlat);
            this.Controls.Add(this.labelNumberOfHouse);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.pictureBoxSmallLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(493, 626);
            this.MinimumSize = new System.Drawing.Size(493, 626);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelNumberOfHouse;
        private System.Windows.Forms.Label labelNumberOfFlat;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxSmallLogo;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxNumberOfHouse;
        private System.Windows.Forms.TextBox textBoxNumberOfFlat;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}