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
        List<int> passenger = new List<int>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Int32.Parse(textBox1.Text);
            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                int a = rand.Next(1, 3);
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
            
        }
    }
}
