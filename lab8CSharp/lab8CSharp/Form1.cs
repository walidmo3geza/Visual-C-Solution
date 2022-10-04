using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlDataAdapter1.Fill(dataSet11);
            sqlConnection1.Close();
            dataGridView1.DataSource = dataSet11.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataSet11.Tables[0].NewRow();
            dataRow["id"] = int.Parse(textBox1.Text);
            dataRow["name"] = textBox2.Text;
            dataRow["dept_id"] = int.Parse(textBox3.Text);
            dataSet11.Tables[0].Rows.Add(dataRow);
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int updatedID = int.Parse(textBox1.Text);
            DataRow dataRow = dataSet11.Tables[0].Rows.Find(updatedID);
            if(dataRow != null)
            {
                dataRow["name"] = textBox2.Text;
                dataRow["dept_id"] = int.Parse(textBox3.Text);
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlDataAdapter1.Update(dataSet11);
            sqlConnection1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int deletededID = int.Parse(textBox1.Text);
            DataRow dataRow = dataSet11.Tables[0].Rows.Find(deletededID);
            if (dataRow != null)
            {
                //dataRow["name"] = textBox2.Text;
                //dataRow["dept_id"] = int.Parse(textBox3.Text);
                dataSet11.Tables[0].Rows.Remove(dataRow);
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Record not found!");
            }
        }
    }
}
