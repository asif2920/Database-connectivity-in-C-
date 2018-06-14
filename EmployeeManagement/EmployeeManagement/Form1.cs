using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InsertEmployee insertEmployee = new InsertEmployee();
            insertEmployee.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchEmployee se = new SearchEmployee();
            se.Show();
        }
    }
}
