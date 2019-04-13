using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2014j_1
{
    public partial class Form2 : Form
    {
        int a = 25, b = 12, c = 4, d = 8, f = 7;
        int m, g, h, j, l;
        int k1, k2, k3, k4, k5;
        int r1, r2, r3, r4, r5;
        int m1, m2, m3, m4, m5;
        int o1, o2, o3, o4, o5;
        int x1, x2, x3, x4, x5;
        public static int t;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bursaDataSet1.Actiuni' table. You can move, or remove it, as needed.
            this.actiuniTableAdapter.Fill(this.bursaDataSet1.Actiuni);
            dataGridView1.Rows[0].Cells[3].Value = a;
            dataGridView1.Rows[1].Cells[3].Value = b;
            dataGridView1.Rows[2].Cells[3].Value = c;
            dataGridView1.Rows[3].Cells[3].Value = d;
            dataGridView1.Rows[4].Cells[3].Value = f;


            if (Form1.ok == true)
            {
                timer1.Interval = Form1.i;
                timer1.Start();
            }
            else
                MessageBox.Show("Bursa este oprita, ne pare rau!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           g = Int32.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString());
           m = Int32.Parse(dataGridView1.Rows[1].Cells[1].Value.ToString());
           h = Int32.Parse(dataGridView1.Rows[2].Cells[1].Value.ToString());
           j = Int32.Parse(dataGridView1.Rows[3].Cells[1].Value.ToString());
           l = Int32.Parse(dataGridView1.Rows[4].Cells[1].Value.ToString());

           k1 = Int32.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString());
           k2 = Int32.Parse(dataGridView1.Rows[1].Cells[2].Value.ToString());
           k3 = Int32.Parse(dataGridView1.Rows[2].Cells[2].Value.ToString());
           k4 = Int32.Parse(dataGridView1.Rows[3].Cells[2].Value.ToString());
           k5 = Int32.Parse(dataGridView1.Rows[4].Cells[2].Value.ToString());

           m1 = Int32.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString());
           m2 = Int32.Parse(dataGridView1.Rows[1].Cells[3].Value.ToString());
           m3 = Int32.Parse(dataGridView1.Rows[2].Cells[3].Value.ToString());
           m4 = Int32.Parse(dataGridView1.Rows[3].Cells[3].Value.ToString());
           m5 = Int32.Parse(dataGridView1.Rows[4].Cells[3].Value.ToString());

           

           dataGridView1.Rows[0].Cells[5].Value = g * a;
           dataGridView1.Rows[1].Cells[5].Value = m * b;
           dataGridView1.Rows[2].Cells[5].Value = h * c;
           dataGridView1.Rows[3].Cells[5].Value = j * d;
           dataGridView1.Rows[4].Cells[5].Value = l * f;
            if (Form1.ok == true)
            {
                Random rnd = new Random();
                r1 = rnd.Next(-5, 5);
                r2 = rnd.Next(-5, 5);
                r3 = rnd.Next(-5, 5);
                r4 = rnd.Next(-5, 5);
                r5 = rnd.Next(-5, 5);
                dataGridView1.Rows[0].Cells[4].Value = r1;
                dataGridView1.Rows[1].Cells[4].Value = r2;
                dataGridView1.Rows[2].Cells[4].Value = r3;
                dataGridView1.Rows[3].Cells[4].Value = r4;
                dataGridView1.Rows[4].Cells[4].Value = r5;

                dataGridView1.Rows[0].Cells[3].Value = a + r1;
                dataGridView1.Rows[1].Cells[3].Value = b + r2;
                dataGridView1.Rows[2].Cells[3].Value = c + r3;
                dataGridView1.Rows[3].Cells[3].Value = d + r4;
                dataGridView1.Rows[4].Cells[3].Value = f + r5;

                dataGridView1.Rows[0].Cells[3].Value = k1 + r1;
                dataGridView1.Rows[1].Cells[3].Value = k2 + r2;
                dataGridView1.Rows[2].Cells[3].Value = k3 + r3;
                dataGridView1.Rows[3].Cells[3].Value = k4 + r4;
                dataGridView1.Rows[4].Cells[3].Value = k5 + r5;

                dataGridView1.Rows[0].Cells[6].Value = m1 * a;
                dataGridView1.Rows[1].Cells[6].Value = m2 * b;
                dataGridView1.Rows[2].Cells[6].Value = m3 * c;
                dataGridView1.Rows[3].Cells[6].Value = m4 * d;
                dataGridView1.Rows[4].Cells[6].Value = m5 * f;

                dataGridView1.Rows[0].Cells[7].Value = g * r1;
                dataGridView1.Rows[1].Cells[7].Value = m * r2;
                dataGridView1.Rows[2].Cells[7].Value = h * r3;
                dataGridView1.Rows[3].Cells[7].Value = j * r4;
                dataGridView1.Rows[4].Cells[7].Value = l * r5;


                o1 = Int32.Parse(dataGridView1.Rows[0].Cells[5].Value.ToString());
                o2 = Int32.Parse(dataGridView1.Rows[1].Cells[5].Value.ToString());
                o3 = Int32.Parse(dataGridView1.Rows[2].Cells[5].Value.ToString());
                o4 = Int32.Parse(dataGridView1.Rows[3].Cells[5].Value.ToString());
                o5 = Int32.Parse(dataGridView1.Rows[4].Cells[5].Value.ToString());

                x1 = Int32.Parse(dataGridView1.Rows[0].Cells[6].Value.ToString());
                x2 = Int32.Parse(dataGridView1.Rows[1].Cells[6].Value.ToString());
                x3 = Int32.Parse(dataGridView1.Rows[2].Cells[6].Value.ToString());
                x4 = Int32.Parse(dataGridView1.Rows[3].Cells[6].Value.ToString());
                x5 = Int32.Parse(dataGridView1.Rows[4].Cells[6].Value.ToString());

                dataGridView1.Rows[0].Cells[8].Value = x1 - o1;
                dataGridView1.Rows[1].Cells[8].Value = x2 - o2;
                dataGridView1.Rows[2].Cells[8].Value = x3 - o3;
                dataGridView1.Rows[3].Cells[8].Value = x4 - o4;
                dataGridView1.Rows[4].Cells[8].Value = x5 - o5;

                t = (x1 - o1) + (x2 + o2) + (x3 - o3) + (x4 - o4) + (x5 - o5);
                textBox1.Text = t.ToString();
                
                timer1.Interval = Form1.i;
            }
        }
    }
}
