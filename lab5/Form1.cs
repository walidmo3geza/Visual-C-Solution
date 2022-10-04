using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        int number1, number2, res;

        private void button3_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (number1 * number2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToInt32(textBox1.Text);
                number2 = Convert.ToInt32(textBox2.Text);
                textBox3.Text = (number1 / number2).ToString();
            }catch(DivideByZeroException ex)
            {
                MessageBox.Show("You can't divide by zero!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (number1 - number2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (number1 + number2).ToString();
        }
    }
}
