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
    public partial class Logout : Form
    {

        MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23;database=pupcea_academic_library_monitoring_system");

        private int id;
        private string student_no;
        private string name;
        private string course;
        private string address;
        private int phone_no;

        public Logout()
        {
            InitializeComponent();
        }

        private void buttonLogout_Submit_Click_1(object sender, EventArgs e)
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

                MySqlCommand command2 = new MySqlCommand("SELECT * FROM `login_current` WHERE `username` = @username", db.getConnect());
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
                            course = (string)dr["course"];
                            address = (string)dr["address"];
                            phone_no = (int)dr["phone_no"];
                            break;
                        }
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Connect.Close();

                MySqlCommand UpdateRecord = new MySqlCommand("UPDATE `records` SET `Logout_time`= CURRENT_TIMESTAMP WHERE `username` = '" +textUsername.Text+"' ORDER BY `Login_time` DESC LIMIT 1", db.getConnect());

                try
                {
                    db.openConnection();
                    if (UpdateRecord.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand DeleteLogin_current = new MySqlCommand("DELETE FROM `login_current` WHERE `login_current`.`id` = " + id + "", db.getConnect());
                        try
                        {
                            db.openConnection();
                            if (DeleteLogin_current.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Logout Successful");
                                this.Hide();
                                Home Home = new Home();
                                Home.ShowDialog();
                                this.Close();
                            }

                            else
                            {
                                MessageBox.Show("Logout Failed");
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
                        MessageBox.Show("Logout Failed");
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

        private void buttonLogout_Back_Click(object sender, EventArgs e)
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

        private void buttonLogout_Submit_MouseEnter(object sender, EventArgs e)
        {
            buttonLogout_Submit.BackColor = Color.Maroon;
        }

        private void buttonLogout_Submit_MouseMove(object sender, MouseEventArgs e)
        {
            buttonLogout_Submit.BackColor = Color.White;
        }

        private void buttonLogout_Back_MouseEnter(object sender, EventArgs e)
        {
            buttonLogout_Back.BackColor = Color.Maroon;
        }

        private void buttonLogout_Back_MouseLeave(object sender, EventArgs e)
        {
            buttonLogout_Back.BackColor = Color.White;
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
