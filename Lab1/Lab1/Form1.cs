﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void task2_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
 Task2Res task2 = new Task2Res();
=======
            Task2 task2 = new Task2();
>>>>>>> Stashed changes
            // Show the settings form
            task2.Show();
        }

        private void task3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
           
        }
    }
}
