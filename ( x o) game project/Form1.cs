﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __x_o__game_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn1player_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
           // this.Hide();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn2player_Click(object sender, EventArgs e)
        {
            ONE_VS_ONE frm = new ONE_VS_ONE();
            frm.Show();
          //  this.Hide();
            

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
