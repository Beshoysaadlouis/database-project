﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Operations emp = new Employee_Operations();
            emp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car_Operations car = new Car_Operations();
            car.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
