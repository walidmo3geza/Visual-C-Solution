using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
            this.label1.ContextMenuStrip = contextMenuStrip1;
            this.toolStripStatusLabel1.Text = this.label1.Text;
            this.toolStripStatusLabel2.Text = "Black";
            this.toolStripStatusLabel2.ForeColor = Color.Black;
            this.toolStripStatusLabel3.Text = "X = 0";
            this.toolStripStatusLabel4.Text = "Y = 0";
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(Color.Red);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(Color.Green);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_color(Color.Blue);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void change_color(Color color)
        {
            label1.ForeColor = color;
            this.toolStripStatusLabel2.Text = label1.ForeColor.Name;
            this.toolStripStatusLabel2.ForeColor = color;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripStatusLabel3.Text = "X = " + e.X.ToString();
            this.toolStripStatusLabel4.Text = "Y = " + e.Y.ToString();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBox dialog = new DBox();
            DialogResult dResult;
            dialog.textBox = label1.Text;
            dResult = dialog.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                label1.Text=dialog.textBox.ToString();
            }
            //dialog.textBox = label1.Text;
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dResult;
            colorDialog1.Color = label1.ForeColor;
            dResult = colorDialog1.ShowDialog();
            if(dResult == DialogResult.OK)
            {
                this.label1.ForeColor = colorDialog1.Color;
                this.toolStripStatusLabel2.Text = this.label1.ForeColor.Name;
            }
        }
    }
}
