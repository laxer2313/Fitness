namespace Fitness
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxBigLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Red;
            this.buttonLogin.Location = new System.Drawing.Point(22, 360);
            this.buttonLogin.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(126, 51);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Logowanie";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatAppearance.BorderSize = 2;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.buttonRegister.ForeColor = System.Drawing.Color.Red;
            this.buttonRegister.Location = new System.Drawing.Point(174, 360);
            this.buttonRegister.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(126, 51);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Rejestracja";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(325, 360);
            this.buttonExit.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(126, 51);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Zakończ";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxBigLogo
            // 
            this.pictureBoxBigLogo.Image = global::Fitness.Properties.Resources._1;
            this.pictureBoxBigLogo.Location = new System.Drawing.Point(-9, -57);
            this.pictureBoxBigLogo.Name = "pictureBoxBigLogo";
            this.pictureBoxBigLogo.Size = new System.Drawing.Size(531, 469);
            this.pictureBoxBigLogo.TabIndex = 3;
            this.pictureBoxBigLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(474, 424);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxBigLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 463);
            this.MinimumSize = new System.Drawing.Size(490, 463);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu główne";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBigLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxBigLogo;
    }
}

