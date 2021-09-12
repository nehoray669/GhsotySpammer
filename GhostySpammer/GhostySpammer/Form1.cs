using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostySpammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCIvTP1unAxXiEbxC3mZ4WwA?view_as=subscriber");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
