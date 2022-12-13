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
    public partial class Car_Operations : Form
    {
        public Car_Operations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_car car = new Add_car();
            car.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Car_id car = new Edit_Car_id();
            car.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_Car car = new Delete_Car();
            car.Show();
        }

        private void Car_Operations_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Car car = new View_Car();
            car.Show();
        }
    }
}
