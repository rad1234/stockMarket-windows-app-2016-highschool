using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _2014j_1
{
    public partial class Form1 : Form
    {
        public static Boolean ok ;
        public static int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button2.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value);
            i = timer1.Interval;
            timer1.Start();
            button2.BackColor = Color.Green;
            button2.Enabled = true;
            button1.BackColor = Color.Gray;
            button1.Enabled = false;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            ok = true;
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value);
            i = timer1.Interval;
        }

        private void actiunileMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button1.Enabled = true;
            ok = false;
            button2.Enabled = false;
            button2.BackColor = Color.Gray;
            timer1.Stop();
        }

        private void grafBursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
