﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinijuegoMate
{
    public partial class pregunta7 : Form
    {
        public pregunta7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            Form1 menuForm = new Form1();
            menuForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
