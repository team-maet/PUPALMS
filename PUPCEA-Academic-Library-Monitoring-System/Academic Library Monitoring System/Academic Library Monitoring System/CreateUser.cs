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
    public partial class CreateUser : Form
    {
          MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23");
        public CreateUser()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "(e.g.) 2020-12345-MN-0")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "(e.g.) 2020-12345-MN-0";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "(e.g.) Juan Dela Cruz")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "(e.g.) Juan Dela Cruz";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "(e.g.) BS in Computer Engineering")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "(e.g.) BS in Computer Engineering";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "House No, Street, Brgy, City")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "House No, Street, Brgy, City";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "091234567")
            {
                textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "091234567";
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "user")
            {
                textBox6.Text = "";
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "user";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "password")
            {
                textBox7.Text = "";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "password";
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // add new user

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `user_data`(`student_no`, `name`, `course`, `address`, `phone_no`, `username`, `password`) VALUES (@student_no, @name, @course, @address, @phone_no, @username, @password)", db.getConnect());
            command.Parameters.Add("@student_no", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@course", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@phone_no", MySqlDbType.Int16).Value = textBox5.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBox7.Text;

            // open connection

            db.openConnection();

            //execute query
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Account Created");
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error");
            }

            //close connection
            db.closeConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreate_MouseEnter(object sender, EventArgs e)
        {
            buttonCreate.BackColor = Color.Maroon;
        }

        private void buttonCreate_MouseLeave(object sender, EventArgs e)
        {
            buttonCreate.BackColor = Color.White;
        }
    }
}
