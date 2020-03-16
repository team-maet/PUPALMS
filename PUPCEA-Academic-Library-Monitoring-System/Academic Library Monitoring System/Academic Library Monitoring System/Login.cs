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
    public partial class Login : Form
    {
        MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23;database=pupcea_academic_library_monitoring_system");

        public int id;
        public string student_no;
        public string name;
        public string address;
        public int phone_no;
        public string course;

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Submit_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textUsername.Text;
            String password = textPassword.Text;
       
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //Validation of the login input
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user_data` WHERE `username` = @usn and `password` = @pass", db.getConnect());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                MySqlCommand command2 = new MySqlCommand("SELECT * FROM `user_data` WHERE `username` = @username", db.getConnect());
                command2.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

                command2.CommandType = CommandType.Text;
                command2.Connection = Connect;
                Connect.Open();
                try
                {
                    MySqlDataReader dr;
                    dr = command2.ExecuteReader();
                    while (dr.Read())
                    {
                        if ((string)dr["username"] == textUsername.Text)
                        {
                            id = (int)dr["id"];
                            student_no = (string)dr["student_no"];
                            name = (string)dr["name"];
                            address = (string)dr["address"];
                            phone_no = (int)dr["phone_no"];
                            username = (string)dr["username"];
                            course = (string)dr["course"];

                            break;
                        } 
                    }
                    dr.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Connect.Close();

                MySqlCommand Insertcurrentlog = new MySqlCommand("INSERT INTO `login_current`(`id`, `student_no`, `name`, `course`, `address`, `phone_no`, `username`) VALUES (@id, @student_no, @name, @course, @address, @phone_no, @username)", db.getConnect());
                MySqlCommand Insertcurrentlog2 = new MySqlCommand("INSERT INTO `records`(`id`, `student_no`, `name`, `course`, `address`, `phone_no`, `username`) VALUES (@id, @student_no, @name, @course, @address, @phone_no, @username)", db.getConnect());
                Insertcurrentlog.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                Insertcurrentlog.Parameters.Add("@student_no", MySqlDbType.VarChar).Value = student_no;
                Insertcurrentlog.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                Insertcurrentlog.Parameters.Add("@course", MySqlDbType.VarChar).Value = course;
                Insertcurrentlog.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                Insertcurrentlog.Parameters.Add("@phone_no", MySqlDbType.Int32).Value = phone_no;
                Insertcurrentlog.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                Insertcurrentlog2.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                Insertcurrentlog2.Parameters.Add("@student_no", MySqlDbType.VarChar).Value = student_no;
                Insertcurrentlog2.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                Insertcurrentlog2.Parameters.Add("@course", MySqlDbType.VarChar).Value = course;
                Insertcurrentlog2.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                Insertcurrentlog2.Parameters.Add("@phone_no", MySqlDbType.Int32).Value = phone_no;
                Insertcurrentlog2.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                try
                {
                    db.openConnection();
                    if (Insertcurrentlog.ExecuteNonQuery() == 1 && Insertcurrentlog2.ExecuteNonQuery() == 1)
                    {
                        //mesage box if you want to borrow book.
                        DialogResult dialogResult = MessageBox.Show("Do you want to borrow a book " + name + "?", "Login Successful", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Borrow Borrow = new Borrow();
                            Borrow.id = id;
                            Borrow.student_no = student_no;
                            Borrow.name = name;
                            Borrow.address = address;
                            Borrow.phone_no = phone_no;
                            Borrow.course = course;
                            Borrow.ShowDialog();
                            this.Close();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Login Successful");

                            this.Hide();
                            Home Home = new Home();
                            Home.ShowDialog();
                            this.Close();
                        }
                    }
                    db.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please check your username or password", "Invalid Input");
            }
        }


        // JUST A CODE FOR TEXT BOX ENTER AND LEAVE
        private void buttonLogin_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Home = new Home();
            Home.ShowDialog();
        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            if (textUsername.Text == "(e.g.) juandelacruz09")
            {
                textUsername.Text = "";
            }
        }

        private void textUsername_Leave(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                textUsername.Text = "(e.g.) juandelacruz09";
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textUsername.Text == "********")
            {
                textUsername.Text = "";
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                textUsername.Text = "********";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Submit_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin_Submit.BackColor = Color.Maroon;
        }

        private void buttonLogin_Submit_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin_Submit.BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
