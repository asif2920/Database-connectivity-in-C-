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
    public partial class InsertEmployee : Form
    {
        public InsertEmployee()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Next ne = new Next();
            int eId,age;
            string eName, sex, eType, dept, eRank = "";
            eId = Convert.ToInt32(textBoxId.Text);
            age = Convert.ToInt32(textBoxAge.Text);
            eName = textBoxName.Text;
            sex = comboBoxSex.Text;
            eType = comboBoxEmployeeType.Text;
            dept = comboBoxDepartment.Text;
            eRank = comboBoxRank.Text;


            
                        //Open a new database connection
                        string strConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asif\\Documents\\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
                       SqlConnection objConnection = new SqlConnection(strConnection);
                        objConnection.Open();

                        //Fire a command
                        string strCommand = "insert into Employee values('"+eId+"','"+eName+"','"+age+"','"+sex+"','"+eType+"','"+dept+"','"+eRank+"')";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.ExecuteNonQuery();

            //close the connection
            objConnection.Close();
            
            ne.Show();
        }
    }
}
