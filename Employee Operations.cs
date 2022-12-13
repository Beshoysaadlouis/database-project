using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System_DB_Project
{
    public partial class Employee_Operations : Form
    {
        public Employee_Operations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Emp Emp_Id = new Add_Emp();
            Emp_Id.Show();
        }

        private void Employee_Operations_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_emp_id Emp_Id = new Edit_emp_id();
            Emp_Id.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Employee emp = new View_Employee();
            emp.Show();
        }
    }
}
