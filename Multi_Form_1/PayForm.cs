using System;
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
    public partial class PayForm : Form
    {
        SearchForm sf = new SearchForm();
        public PayForm()
        {
            InitializeComponent();
            sf.pf = this;
        }

        private void PayForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sf.textBox1.Text = "";
            sf.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            string textToAdd = textBox2.Text;
            f2.Show();
            f2.listBox1.Items.Add("پرداخت شهریه به مبلغ" + textToAdd + " توسط دانشجو سارا اسدی با شماره دانشجویی 140112028003");
        }
    }
}
