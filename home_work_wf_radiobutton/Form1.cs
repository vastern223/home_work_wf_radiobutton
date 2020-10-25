using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work_wf_radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            decimal totalPrice = 0;
          
            foreach (RadioButton rb1 in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rb1.Checked) { totalPrice += Convert.ToDecimal(rb1.Tag); check1 = true;  }           
            }
            foreach (RadioButton rb2 in groupBox2.Controls.OfType<RadioButton>())
            {
                if (rb2.Checked) { totalPrice += Convert.ToDecimal(rb2.Tag); check2= true; }
            }
            foreach (RadioButton rb3 in groupBox3.Controls.OfType<RadioButton>())
            {
                if (rb3.Checked) { totalPrice += Convert.ToDecimal(rb3.Tag); check3 = true; }
            }

            if (check1 && check2 && check3)
            {   counter++;
                MessageBox.Show($"data {DateTime.Now.ToShortDateString()}\ntime{DateTime.Now.ToShortTimeString()}\ntotal price: { totalPrice } $", "\n", MessageBoxButtons.OK);
                textBox1.Text += $"{counter}) price: {totalPrice} data {DateTime.Now.ToShortDateString()}{Environment.NewLine}";
            }
        }
    }
}
