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
    public partial class LoginRecords : Form
    {
        MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23;database=pupcea_academic_library_monitoring_system");
        DB db = new DB();

        public LoginRecords()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }

        private void LoginRecords_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM records ORDER BY Login_time DESC", Connect);
            DataTable dbtl = new DataTable();
            sqlDa.Fill(dbtl);

            dataGridView1.DataSource = dbtl;
        }
    }
}
