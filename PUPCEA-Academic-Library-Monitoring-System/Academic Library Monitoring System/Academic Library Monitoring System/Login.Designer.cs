namespace Academic_Library_Monitoring_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin_Submit = new System.Windows.Forms.Button();
            this.buttonLogin_Back = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(501, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.IndianRed;
            this.textUsername.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textUsername.Location = new System.Drawing.Point(466, 144);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(136, 20);
            this.textUsername.TabIndex = 3;
            this.textUsername.Text = "(e.g.) juandelacruz09";
            this.textUsername.Enter += new System.EventHandler(this.textUsername_Enter);
            this.textUsername.Leave += new System.EventHandler(this.textUsername_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(327, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(327, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.IndianRed;
            this.textPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textPassword.Location = new System.Drawing.Point(466, 186);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(136, 20);
            this.textPassword.TabIndex = 15;
            this.textPassword.Text = "aaaaaaaa";
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // buttonLogin_Submit
            // 
            this.buttonLogin_Submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin_Submit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin_Submit.Location = new System.Drawing.Point(483, 232);
            this.buttonLogin_Submit.Name = "buttonLogin_Submit";
            this.buttonLogin_Submit.Size = new System.Drawing.Size(101, 48);
            this.buttonLogin_Submit.TabIndex = 19;
            this.buttonLogin_Submit.Text = "Login";
            this.buttonLogin_Submit.UseVisualStyleBackColor = false;
            this.buttonLogin_Submit.Click += new System.EventHandler(this.buttonLogin_Submit_Click);
            this.buttonLogin_Submit.MouseEnter += new System.EventHandler(this.buttonLogin_Submit_MouseEnter);
            this.buttonLogin_Submit.MouseLeave += new System.EventHandler(this.buttonLogin_Submit_MouseLeave);
            // 
            // buttonLogin_Back
            // 
            this.buttonLogin_Back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin_Back.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin_Back.Location = new System.Drawing.Point(616, 346);
            this.buttonLogin_Back.Name = "buttonLogin_Back";
            this.buttonLogin_Back.Size = new System.Drawing.Size(68, 30);
            this.buttonLogin_Back.TabIndex = 24;
            this.buttonLogin_Back.Text = "Back";
            this.buttonLogin_Back.UseVisualStyleBackColor = false;
            this.buttonLogin_Back.Click += new System.EventHandler(this.buttonLogin_Back_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(-5, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 14);
            this.panel3.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(-5, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 14);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-5, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 14);
            this.panel1.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(18, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "PUP Library Monitoring System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 414);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin_Back);
            this.Controls.Add(this.buttonLogin_Submit);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academic Library Monitoring System | LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonLogin_Submit;
        private System.Windows.Forms.Button buttonLogin_Back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}