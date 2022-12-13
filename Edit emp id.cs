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
    public partial class Edit_emp_id : Form
    {
        public Edit_emp_id()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit_Employee edit = new Edit_Employee();
            edit.Show();
        }
    }
}
