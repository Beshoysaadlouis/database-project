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
    public partial class Edit_Car_id : Form
    {
        public Edit_Car_id()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit_Car car = new Edit_Car();
            car.Show();
        }
    }
}
