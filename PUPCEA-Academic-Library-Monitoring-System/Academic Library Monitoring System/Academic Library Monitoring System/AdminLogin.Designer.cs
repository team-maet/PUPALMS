namespace Academic_Library_Monitoring_System
{
    partial class AdminLogin
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
            this.buttonLogin_Back = new System.Windows.Forms.Button();
            this.buttonAdminLogin_Submit = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin_Back
            // 
            this.buttonLogin_Back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin_Back.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin_Back.Location = new System.Drawing.Point(497, 293);
            this.buttonLogin_Back.Name = "buttonLogin_Back";
            this.buttonLogin_Back.Size = new System.Drawing.Size(68, 30);
            this.buttonLogin_Back.TabIndex = 30;
            this.buttonLogin_Back.Text = "Back";
            this.buttonLogin_Back.UseVisualStyleBackColor = false;
            this.buttonLogin_Back.Click += new System.EventHandler(this.buttonLogin_Back_Click);
            this.buttonLogin_Back.MouseEnter += new System.EventHandler(this.buttonLogin_Back_MouseEnter);
            this.buttonLogin_Back.MouseLeave += new System.EventHandler(this.buttonLogin_Back_MouseLeave);
            // 
            // buttonAdminLogin_Submit
            // 
            this.buttonAdminLogin_Submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdminLogin_Submit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminLogin_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdminLogin_Submit.Location = new System.Drawing.Point(257, 254);
            this.buttonAdminLogin_Submit.Name = "buttonAdminLogin_Submit";
            this.buttonAdminLogin_Submit.Size = new System.Drawing.Size(101, 48);
            this.buttonAdminLogin_Submit.TabIndex = 29;
            this.buttonAdminLogin_Submit.Text = "Login";
            this.buttonAdminLogin_Submit.UseVisualStyleBackColor = false;
            this.buttonAdminLogin_Submit.Click += new System.EventHandler(this.buttonAdminLogin_Submit_Click);
            // 
            // textPassword
            // 
            this.textPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textPassword.Location = new System.Drawing.Point(240, 208);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(136, 20);
            this.textPassword.TabIndex = 28;
            this.textPassword.Text = "aaaaaaaa";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(131, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(131, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Username";
            // 
            // textUsername
            // 
            this.textUsername.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textUsername.Location = new System.Drawing.Point(240, 166);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(136, 20);
            this.textUsername.TabIndex = 25;
            this.textUsername.Text = "(e.g.) juandelacruz09";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Academic_Library_Monitoring_System.Properties.Resources.manager;
            this.pictureBox1.Location = new System.Drawing.Point(240, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(577, 335);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin_Back);
            this.Controls.Add(this.buttonAdminLogin_Submit);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academic Library Monitoring System | ADMIN LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin_Back;
        private System.Windows.Forms.Button buttonAdminLogin_Submit;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}