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
    public partial class Form3 : Form
    {
        Graphics g;
        Point p1, p2;
        int x, y, j = 1;
        float timp, valoare;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p1.X =  50;
            p1.Y = 205;
            if (Form1.ok == true)
            {
                timer2.Enabled = true;
                timer2.Interval = Form1.i;
            }
            else
            {
                MessageBox.Show("Bursa este inchisa!");
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                timp = Form1.i / 100;
                valoare = Form2.t / 5;
                if (timp < 0)
                {
                    timp = -1 * timp;
                }
                Pen r = new Pen(new SolidBrush(Color.Blue));
                Pen p = new Pen(new SolidBrush(Color.Red));
                g.DrawLine(r, 50, 200, 800, 200);
                g.DrawLine(r, 50, 20, 50, 400);
                g.DrawString("Valoare", new Font("Calibri", 12), new SolidBrush(Color.Red), 45, 3);
                x += Convert.ToInt32(timp);
                y = Convert.ToInt32(valoare+300);
               // MessageBox.Show(x.ToString() +  y.ToString());
                
                    p2.X = x+50;
                    p2.Y = y;
                
                g.DrawLine(p, p1, p2);
                p1 = p2;
                timer1.Interval = Form1.i;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Interval = Form1.i;
            timer1.Start();
            g.Clear(Color.White);

        }    

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
