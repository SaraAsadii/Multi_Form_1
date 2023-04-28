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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        PayForm pf = new PayForm();
        private void button1_Click(object sender, EventArgs e)
        {
            pf.Show();
            this.Hide();
        }
    }
}
