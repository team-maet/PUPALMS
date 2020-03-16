using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Academic_Library_Monitoring_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logout Logout = new Logout();
            Logout.ShowDialog();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Image\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.ShowDialog();
            this.Close();
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.Maroon;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.White;
        }

        private void buttonLogout_MouseEnter(object sender, EventArgs e)
        {
            buttonLogout.BackColor = Color.Maroon;
        }

        private void buttonLogout_MouseLeave(object sender, EventArgs e)
        {
            buttonLogout.BackColor = Color.White;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
