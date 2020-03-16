using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Academic_Library_Monitoring_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Home = new Home();
            Home.ShowDialog();
            this.Close();
        }

        private void buttonAdminLogin_Submit_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textUsername.Text;
            String password = textPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin_data` WHERE `username` = @usn and `password` = @pass", db.getConnect());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your username or password", "Invalid Input");
            }
        }

        private void buttonLogin_Back_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin_Back.BackColor = Color.Maroon;
        }

        private void buttonLogin_Back_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin_Back.BackColor = Color.White;
        }
    }
}
