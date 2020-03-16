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
    public partial class Borrow : Form
    {
        public int id;
        public string student_no;
        public string name;
        public string address;
        public int phone_no;
        public string course;
        public string book_name;

        MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23;database=pupcea_academic_library_monitoring_system");
        public Borrow()
        {
            InitializeComponent();
        }

        private void buttonBorrow_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
            this.Close();
        }

        private void buttonBorrow_Submit_Click(object sender, EventArgs e)
        {
            book_name = Convert.ToString(textBox1.Text);

            DB db = new DB();

            MySqlCommand BorrowRequest = new MySqlCommand("INSERT INTO `borrow_requests`(`book_name`, `id`, `student_no`, `name`, `course`, `address`, `phone_no`) VALUES (@book_name, @id, @student_no, @name, @course, @address, @phone_no)", db.getConnect());
            BorrowRequest.Parameters.Add("@book_name", MySqlDbType.VarChar).Value = book_name;
            BorrowRequest.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            BorrowRequest.Parameters.Add("@student_no", MySqlDbType.VarChar).Value = student_no;
            BorrowRequest.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            BorrowRequest.Parameters.Add("@course", MySqlDbType.VarChar).Value = course;
            BorrowRequest.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            BorrowRequest.Parameters.Add("@phone_no", MySqlDbType.Int16).Value = phone_no;


            try
            {
                db.openConnection();
                if (BorrowRequest.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Please go to the admin to leave your current semestral Registration Card to claim the book.", "Successful Login and Book Request");
                    this.Hide();
                    Home Home = new Home();
                    Home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBorrow_Submit_MouseEnter(object sender, EventArgs e)
        {
            buttonBorrow_Submit.BackColor = Color.Maroon;
        }

        private void buttonBorrow_Submit_MouseLeave(object sender, EventArgs e)
        {
            buttonBorrow_Submit.BackColor = Color.White;
        }

        private void buttonBorrow_Back_MouseEnter(object sender, EventArgs e)
        {
            buttonBorrow_Back.BackColor = Color.Maroon;
        }

        private void buttonBorrow_Back_MouseLeave(object sender, EventArgs e)
        {
            buttonBorrow_Submit.BackColor = Color.White;
        }
    }
}
