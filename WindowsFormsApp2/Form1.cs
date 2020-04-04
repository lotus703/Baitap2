using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int n;
        List<int> passenger = new List<int>();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            n = Int32.Parse(textBox1.Text);
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter >= n)
            {
                timer1.Stop();
            }
            else
            {
                Random rand = new Random();
                int a = rand.Next(1, 4);
                passenger.Add(a);
                if (a == 1)
                {
                    label1.Text = "Thuong gia";
                }
                if (a == 2)
                {
                    label1.Text = "Dat ve online";
                }
                if (a == 3)
                {
                    label1.Text = "Thuong";
                }
                counter++;
            }

            //for (int i = 1; i < n; i++)
            //{
            //    int a = rand.Next(1, 3);
            //    passenger.Add(a);
            //    if (a == 1)
            //    {
            //        label1.Text = "Thuong gia";
            //    }
            //    if (a == 2)
            //    {
            //        label1.Text = "Dat ve online";
            //    }
            //    if (a == 3)
            //    {
            //        label1.Text = "Thuong";
            //    }
            //    //Thread.Sleep(1000);

            //}
        }
    }
}
