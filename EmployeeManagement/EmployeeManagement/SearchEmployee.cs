using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            //Open a new database connection
            string strConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asif\\Documents\\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            //Fire a command
            string strCommand = "Select * from Employee where Id='"+id+"'";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            SqlDataReader reader = null;
            reader = objCommand.ExecuteReader();
            //objCommand.ExecuteNonQuery();
            while (reader.Read()) {
                string name = reader["Name"].ToString();
                label2.Text = name;
            }

            //close the connection
            objConnection.Close();
        }
    }
}
