﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Form_1
{
    public partial class SearchForm : Form
    {
        public PayForm pf;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("سارا"))
            {
                pf.textBox1.Text = "140112028003";
                this.Hide();
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
