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


        // VIP
        List<int> viper = new List<int>();
        int TimeLimitVip;
        int CounterVip = 0;
        List<int> viperdone = new List<int>();

        //Online
        List<int> onliner = new List<int>();
        int TimeLimitOnline;
        int CounterOnline = 0;
        List<int> onlinedone = new List<int>();

        //Guest
        List<int> guests = new List<int>();
        int TimeLimitGuest;
        int CounterGuest = 0;
        List<int> guestsdone = new List<int>();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            n = Int32.Parse(textBox1.Text);
            //timer1.Interval = 1000;
            //timer1.Tick += new EventHandler(timer1_Tick);
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
                    
            }
            else
            {
                Random rand = new Random();
                int a = rand.Next(1, 4);
                passenger.Add(2);
                CountPassenger.Text = passenger.Count.ToString();
                if (a == 1)
                {
                    label1.Text = "Thuong gia";
                    viper.Add(a);
                    CountViper.Text = viper.Count.ToString();
                    
                }
                if (a == 2)
                {
                    label1.Text = "Dat ve online";
                    onliner.Add(a);
                    CountOnliner.Text = onliner.Count.ToString();
                }
                if (a == 3)
                {
                    label1.Text = "Thuong";
                    guests.Add(a);
                    CountGuests.Text = guests.Count.ToString();
                }
                counter++;
            }

            if (viper.Count > 0)
            {
                Random time = new Random();
                int Time = time.Next(int.Parse(txtTimeStartVip.Text), int.Parse(txtTimeStartVip.Text));
                DoorVipDoing(Time);
            }
            if (onliner.Count > 0)
            {
                Random time = new Random();
                int Time = time.Next(int.Parse(txtTimeStartOnline.Text), int.Parse(txtTimeEndOnline.Text));
                DoorOnlineDoing(Time);
            }
            if (guests.Count > 0)
            {
                Random time = new Random();
                int Time = time.Next(int.Parse(txtTimeStartGuest.Text), int.Parse(txtTimeEndGuest.Text));
                DoorGuestDoing(Time);
            }
        }

        private void DoorVipDoing(int Time)
        {
            if (Time - CounterVip == 0)
            {
                viperdone.Add(1);
                viper.RemoveAt(0);
                txtDoingVip.Text = "Trống";
                CountViper.Text = viper.Count.ToString();
                CountViperDone.Text = viperdone.Count.ToString();
                CounterVip = 0;
            }
            else
            {
                txtDoingVip.Text = "Đang xử lí";
                CounterVip++;
            }
        }

        private void DoorOnlineDoing(int Time)
        {
            if (Time - CounterOnline == 0)
            {
                onlinedone.Add(2);
                onliner.RemoveAt(0);
                txtDoingOnline.Text = "Trống";
                CountOnliner.Text = onliner.Count.ToString();
                CountOnlineDone.Text = onlinedone.Count.ToString();
                CounterOnline = 0;
            }
            else
            {
                txtDoingOnline.Text = "Đang xử lí";
                CounterOnline++;
            }
        }

        private void DoorGuestDoing(int Time)
        {
            if (Time - CounterGuest == 0)
            {
                guestsdone.Add(3);
                guests.RemoveAt(0);
                txtDoingGuest.Text = "Trống";
                CountGuests.Text = guests.Count.ToString();
                CountGuestsDone.Text = guestsdone.Count.ToString();
                CounterGuest = 0;
            }
            else
            {
                txtDoingGuest.Text = "Đang xử lí";
                CounterGuest++;
            }
        }
    }
}
