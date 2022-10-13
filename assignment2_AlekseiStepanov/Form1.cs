using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label9.Text = (15 * int.Parse(textBox1.Text)).ToString() + ",00 €";
            label10.Text = (12 * int.Parse(textBox2.Text)).ToString() + ",00 €";
            label11.Text = (9 * int.Parse(textBox3.Text)).ToString() + ",00 €";
            label12.Text = (15 * int.Parse(textBox1.Text) + 12 * int.Parse(textBox2.Text) + 9 * int.Parse(textBox3.Text)).ToString() + ",00 €";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
       