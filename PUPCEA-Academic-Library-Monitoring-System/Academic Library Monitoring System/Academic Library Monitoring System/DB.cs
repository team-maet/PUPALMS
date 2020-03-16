using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Academic_Library_Monitoring_System
{
    class DB
    {
        MySqlConnection Connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=phpMAImmature23;database=pupcea_academic_library_monitoring_system");


        //function to open connection
        public void openConnection()
        {
            if (Connect.State == System.Data.ConnectionState.Closed)
            {
                Connect.Open();
            }
        }

        //function to close connection
        public void closeConnection()
        {
            if (Connect.State == System.Data.ConnectionState.Open)
            {
                Connect.Close();
            }
        }

        //function to return the connection
        public MySqlConnection getConnect()
        {
            return Connect;
        }
    }
    
    
}
