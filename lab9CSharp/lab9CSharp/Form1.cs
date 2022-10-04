using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "select id,name,isnull(dept_id,0) from employee";
            string st = "select id from department";
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
            }
            //MessageBox.Show(str);
            sqlCommand1.CommandText = s;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            while (dReader.Read())
            {
                string str = ((int)(dReader[0])).ToString() + "\t" + dReader[1].ToString() + "\t" + ((int)(dReader[2])).ToString();
                listBox1.Items.Add(str);
                comboBox1.Items.Add((int)(dReader[0])).ToString();
            }
            dReader.Close();
            sqlCommand1.CommandText = st;
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox2.Items.Add(sqlDataReader[0].ToString());
            }
            sqlDataReader.Close();
            sqlConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            if (((Button)sender).Text=="Insert") //Insert
            {
                str = "insert into employee values(" + textBox1.Text + ",'" + textBox2.Text + "'," + comboBox2.Text + ")";
                //MessageBox.Show(str);
            }
            else if (((Button)sender).Text == "Update")  //Update
            {
                str = "update employee set name = '" + textBox2.Text + "', dept_id = " + comboBox2.Text + " where id = " + textBox1.Text;
                //MessageBox.Show(str);

            }
            else if (((Button)sender).Text == "Delete")  //Delete
            {
                str = "delete from employee where id = " + textBox1.Text;
                //MessageBox.Show(str);
            }
            
            sqlCommand1.CommandText = str;
            sqlConnection1.Open();
            int afectedRows = sqlCommand1.ExecuteNonQuery();
            MessageBox.Show(afectedRows.ToString() + "row afected");
            sqlConnection1.Close();
            textBox1.Text = textBox2.Text = comboBox2.Text = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "select id,name,isnull(dept_id,0) from employee where id = " + comboBox1.Text;
            sqlCommand1.CommandText = s;
            sqlConnection1.Open();
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            if (sqlDataReader.Read())
            {
                textBox1.Text = sqlDataReader[0].ToString();
                textBox2.Text = sqlDataReader[1].ToString();
                comboBox2.Text = sqlDataReader[2].ToString();
            }
            sqlDataReader.Close();
            sqlConnection1.Close();
        }
    }
}
