﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTeamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStuSelect_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(tbStuId.Text, tbName.Text);
            form3.Show();
        }
    }
}
