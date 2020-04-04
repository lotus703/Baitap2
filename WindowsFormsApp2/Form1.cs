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
        int n;
        int[] passenger;
        public Form1()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 1; i<n; i++)
            {
                passenger[i] = rand.Next(1, 3);
                switch (passenger[i])
                {
                    case 1:
                        label1.Text = "Thuong gia";
                        break;
                    case 2:
                        label1.Text = "Dat ve online";
                        break;
                    case 3:
                        label1.Text = "Thuong";
                        break;
                }
                Thread.Sleep(1000);
            }
            
        }

         

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = Int32.Parse(textBox1.Text);
            passenger = new int[n];
        }
    }
}
