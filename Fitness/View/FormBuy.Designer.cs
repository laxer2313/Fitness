namespace Fitness.View
{
    partial class FormBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuy));
            this.pictureBoxSmallLogo = new System.Windows.Forms.PictureBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxUlga = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSmallLogo
            // 
            this.pictureBoxSmallLogo.Image = global::Fitness.Properties.Resources._2;
            this.pictureBoxSmallLogo.Location = new System.Drawing.Point(-43, -224);
            this.pictureBoxSmallLogo.Name = "pictureBoxSmallLogo";
            this.pictureBoxSmallLogo.Size = new System.Drawing.Size(438, 305);
            this.pictureBoxSmallLogo.TabIndex = 1;
            this.pictureBoxSmallLogo.TabStop = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelType.Location = new System.Drawing.Point(12, 100);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(106, 20);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Typ karnetu";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(142, 97);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxType.Size = new System.Drawing.Size(249, 28);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.Text = "Miesięczny";
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // checkBoxUlga
            // 
            this.checkBoxUlga.AutoSize = true;
            this.checkBoxUlga.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.checkBoxUlga.Location = new System.Drawing.Point(142, 131);
            this.checkBoxUlga.Name = "checkBoxUlga";
            this.checkBoxUlga.Size = new System.Drawing.Size(87, 24);
            this.checkBoxUlga.TabIndex = 4;
            this.checkBoxUlga.Text = "Ulgowy";
            this.checkBoxUlga.UseVisualStyleBackColor = true;
            this.checkBoxUlga.CheckedChanged += new System.EventHandler(this.checkBoxUlga_CheckedChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.buttonBack.ForeColor = System.Drawing.Color.Red;
            this.buttonBack.Location = new System.Drawing.Point(211, 255);
            this.buttonBack.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(128, 51);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.FlatAppearance.BorderSize = 2;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.buttonBuy.ForeColor = System.Drawing.Color.Red;
            this.buttonBuy.Location = new System.Drawing.Point(62, 255);
            this.buttonBuy.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(128, 51);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Kup";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelPrice.Location = new System.Drawing.Point(12, 164);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 20);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Cena";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBoxPrice.Location = new System.Drawing.Point(142, 161);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(249, 27);
            this.textBoxPrice.TabIndex = 9;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.labelDate.Location = new System.Drawing.Point(12, 208);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(81, 20);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Od kiedy";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 207);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 7, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(403, 318);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.checkBoxUlga);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.pictureBoxSmallLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(419, 357);
            this.MinimumSize = new System.Drawing.Size(419, 357);
            this.Name = "FormBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kup karnet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmallLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSmallLogo;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckBox checkBoxUlga;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}