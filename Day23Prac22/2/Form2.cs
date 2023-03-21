using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            double x = double.Parse(textBox3.Text);

            textBox1.Text += Environment.NewLine +
            "X = " + x.ToString();


            double q = double.Parse(textBox2.Text);

            textBox1.Text += Environment.NewLine +
            "Q = " + q.ToString();
            double k;
            if (radioButton1.Checked)
        
                k = Math.Log10(Math.Pow(x, 2) + Math.Abs(q));
            else
            if (radioButton2.Checked)
                k = Math.Pow(Math.E, Math.Pow(x, 2) + q);
            else
                k = Math.Pow(x, 2) + q;

         
            textBox1.Text += Environment.NewLine + "K = " + k.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
