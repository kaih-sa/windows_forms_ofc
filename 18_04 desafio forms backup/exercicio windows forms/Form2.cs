﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_windows_forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 j4 = new Form4();
            j4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 j11 = new Form11();
            j11.Show(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 j8 = new Form8();
            j8.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
