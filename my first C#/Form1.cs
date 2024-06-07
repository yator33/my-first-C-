using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_sl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello there");
            MessageBox.Show("message 2");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            this.BackColor = Color.Red;
            button2.ForeColor = Color.Pink;
            this.Text = "my first project in c#";
            this.button1.Text = "you can delete";
            this.button2.Text = "cancel";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
        }
    }
}
