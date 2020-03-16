using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Academic_Library_Monitoring_System
{
    public partial class AdminDashboard : Form
    {
        private string SN;

        MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23;database=pupcea_academic_library_monitoring_system");
        DB db = new DB();

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void buttonCreate_User_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser CreateUser = new CreateUser();
            CreateUser.ShowDialog();
            this.Close();
        }

        private void buttonCreate_User_MouseEnter(object sender, EventArgs e)
        {
            buttonCreate_User.BackColor = Color.Maroon;
        }

        private void buttonCreate_User_MouseLeave(object sender, EventArgs e)
        {
            buttonCreate_User.BackColor = Color.White;
        }

        private void buttonPending_Borrow_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin_Record.BackColor = Color.Maroon;
        }

        private void buttonPending_Borrow_MouseLeave(object sender, EventArgs e)
        {
            buttonCreate_User.BackColor = Color.White;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM login_current ORDER BY Login_time DESC", Connect);
            DataTable dbtl = new DataTable();
            sqlDa.Fill(dbtl);
            
            dataGridView1.DataSource = dbtl;
            comboBox1.SelectedIndex = 0;

            MySqlDataAdapter brrwd = new MySqlDataAdapter("SELECT * FROM borrow_requests ORDER BY request_time ASC", Connect);
            DataTable dbt2 = new DataTable();
            brrwd.Fill(dbt2);

            dataGridView2.DataSource = dbt2;
            

           //gago at line 63
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student Number")
            {
                SN = "student_no";
            }
            else
            {
                SN = "Name";
            }

            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM login_current WHERE `"+SN+"` LIKE '" + textBox1.Text + "%'", Connect);
            DataTable dbtl = new DataTable();
            sqlDa.Fill(dbtl);
            dataGridView1.DataSource = dbtl;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Accept_but_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
            {
                if (oneCell.Selected == false) continue;
                string request_no = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string book_name = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                string id = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                string student_no = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                string name = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                string course = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                string address = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                string phone_no = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();

                dataGridView2.Rows.RemoveAt(oneCell.RowIndex);

                MySqlCommand Delete = new MySqlCommand("DELETE FROM `borrow_requests` WHERE `borrow_requests`.`request_no` = '" + request_no + "'", db.getConnect());
                

                try
                {
                    db.openConnection();
                    if (Delete.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand accepted = new MySqlCommand("INSERT into `book_accepted` (`request_no`, `book_name`, `id`, `student_no`, `name`, `course`, `address`, `phone_no`) VALUES (@request_no, @book_name, @id, @student_no, @name ,@course ,@address ,@phone_no)", db.getConnect());
                        accepted.Parameters.Add("@request_no", MySqlDbType.Int32).Value = request_no;
                        accepted.Parameters.Add("@book_name", MySqlDbType.VarChar).Value = book_name;
                        accepted.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                        accepted.Parameters.Add("@student_no", MySqlDbType.VarChar).Value = student_no;
                        accepted.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                        accepted.Parameters.Add("@course", MySqlDbType.VarChar).Value = course;
                        accepted.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                        accepted.Parameters.Add("@phone_no", MySqlDbType.Int32).Value = phone_no;
                        try
                        {
                            db.openConnection();
                            if (accepted.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Request Accepted");
                            }
                            else
                            {
                                MessageBox.Show("Fail Request");
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
                        MessageBox.Show("Fail Request");
                    }
                    db.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksRecord BooksRecord = new BooksRecord();
            BooksRecord.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Record_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRecords loginRecords = new LoginRecords();
            loginRecords.ShowDialog();
            this.Close();
        }

        private void refuse_but_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
            {
                if (oneCell.Selected == false) continue;
                string request_no = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                dataGridView2.Rows.RemoveAt(oneCell.RowIndex);

                MySqlCommand Delete = new MySqlCommand("DELETE FROM `borrow_requests` WHERE `borrow_requests`.`request_no` = '" + request_no + "'", db.getConnect());

                try
                {
                    db.openConnection();
                    if (Delete.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Request Declined");
                    }
                    else
                    {
                        MessageBox.Show("Decline Error");
                    }
                    db.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
