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
    public partial class BooksRecord : Form
    {
        MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23;database=pupcea_academic_library_monitoring_system");
        DB db = new DB();

        public BooksRecord()
        {
            InitializeComponent();
        }

        private void BooksRecord_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM book_accepted ORDER BY time_accepted DESC", Connect);
            DataTable dbtl = new DataTable();
            sqlDa.Fill(dbtl);

            dataGridView1.DataSource = dbtl;

            MySqlDataAdapter complete = new MySqlDataAdapter("SELECT * FROM borrow_record ORDER BY time_returned DESC", Connect);
            DataTable dbt2 = new DataTable();
            sqlDa.Fill(dbt2);

            dataGridView1.DataSource = dbt2;
        }

        private void Returned_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected == false) continue;
                string request_no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string book_name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string id = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string student_no = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string course = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string address = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string phone_no = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string time_accepted = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

                dataGridView1.Rows.RemoveAt(oneCell.RowIndex);

                MySqlCommand DeleteRequest = new MySqlCommand("DELETE FROM `book_accepted` WHERE `book_accepted`.`request_no` = '" + request_no + "'", db.getConnect());

                try
                {
                    db.openConnection();
                    if (DeleteRequest.ExecuteNonQuery() == 1)
                    {
                        MySqlCommand accepted = new MySqlCommand("INSERT into `borrow_record` (`request_no`, `book_name`, `id`, `student_no`, `name`, `course`, `address`, `phone_no`, `time_accepted`) VALUES (@request_no, @book_name, @id, @student_no, @name ,@course ,@address ,@phone_no, @time_accepted)", db.getConnect());
                        accepted.Parameters.Add("@request_no", MySqlDbType.Int32).Value = request_no;
                        accepted.Parameters.Add("@book_name", MySqlDbType.VarChar).Value = book_name;
                        accepted.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                        accepted.Parameters.Add("@student_no", MySqlDbType.VarChar).Value = student_no;
                        accepted.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                        accepted.Parameters.Add("@course", MySqlDbType.VarChar).Value = course;
                        accepted.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                        accepted.Parameters.Add("@phone_no", MySqlDbType.Int32).Value = phone_no;
                        accepted.Parameters.Add("@time_accepted", MySqlDbType.VarChar).Value = time_accepted;
                        try
                        {
                            db.openConnection();
                            if (accepted.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Book Returned");
                            }
                            else
                            {
                                MessageBox.Show("Failed");
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
                        MessageBox.Show("Failed");
                    }
                    db.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }
    }
}
