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
    public partial class Form12 : Form
    {
        public Form12(string TextoPronto)
        {
            InitializeComponent();
            label.Text = "Conteúdo escrito: " + TextoPronto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
