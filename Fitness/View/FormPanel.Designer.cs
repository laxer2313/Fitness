namespace Fitness
{
    partial class FormPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fitness.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(-36, -186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 378);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPlan
            // 
            this.buttonPlan.FlatAppearance.BorderSize = 2;
            this.buttonPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlan.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlan.ForeColor = System.Drawing.Color.Red;
            this.buttonPlan.Location = new System.Drawing.Point(58, 161);
            this.buttonPlan.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(298, 51);
            this.buttonPlan.TabIndex = 1;
            this.buttonPlan.Text = "Plan zajęć";
            this.buttonPlan.UseVisualStyleBackColor = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.FlatAppearance.BorderSize = 2;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuy.ForeColor = System.Drawing.Color.Red;
            this.buttonBuy.Location = new System.Drawing.Point(58, 218);
            this.buttonBuy.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(298, 51);
            this.buttonBuy.TabIndex = 2;
            this.buttonBuy.Text = "Kup karnet";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 2;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(58, 275);
            this.buttonLogout.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(298, 51);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(58, 332);
            this.buttonClose.MinimumSize = new System.Drawing.Size(126, 51);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(298, 51);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(416, 395);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonPlan);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 434);
            this.MinimumSize = new System.Drawing.Size(432, 434);
            this.Name = "FormPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPlan;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonClose;
    }
}