namespace Fitness
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBoxSmallLogo = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSmallLogo
            // 
            this.pictureBoxSmallLogo.Image = global::Fitness.Properties.Resources._2;
            this.pictureBoxSmallLogo.Location = new System.Drawing.Point(0, -225);
            this.pictureBoxSmallLogo.Name = "pictureBoxSmallLogo";
            this.pictureBoxSmallLogo.Size = new System.Drawing.Size(468, 305);
            this.pictureBoxSmallLogo.TabIndex = 0;
            this.pictureBoxSmallLogo.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelEmail.Location = new System.Drawing.Point(72, 98);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "E-mail";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelPassword.Location = new System.Drawing.Point(72, 131);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Hasło";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxEmail.Location = new System.Drawing.Point(160, 95);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(257, 27);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(160, 131);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(257, 27);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatAppearance.BorderSize = 2;
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Red;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(95, 198);
            this.buttonBackToMainMenu.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(128, 51);
            this.buttonBackToMainMenu.TabIndex = 5;
            this.buttonBackToMainMenu.Text = "Wróć";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.FlatAppearance.BorderSize = 2;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.buttonLogIn.ForeColor = System.Drawing.Color.Red;
            this.buttonLogIn.Location = new System.Drawing.Point(275, 198);
            this.buttonLogIn.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(128, 51);
            this.buttonLogIn.TabIndex = 6;
            this.buttonLogIn.Text = "Zaloguj";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 261);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.pictureBoxSmallLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(508, 300);
            this.MinimumSize = new System.Drawing.Size(508, 300);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSmallLogo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonLogIn;
    }
}