﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("애옹 ",
                "고양이가 말하길..",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);


        }
    }
}
