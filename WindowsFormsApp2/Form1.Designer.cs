namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.CountPassenger = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountViper = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CountOnliner = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CountGuests = new System.Windows.Forms.Label();
            this.txtTimeStartVip = new System.Windows.Forms.TextBox();
            this.txtTimeEndVip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimeEndOnline = new System.Windows.Forms.TextBox();
            this.txtTimeStartOnline = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimeEndGuest = new System.Windows.Forms.TextBox();
            this.txtTimeStartGuest = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CountViperDone = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CountOnlineDone = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.CountGuestsDone = new System.Windows.Forms.Label();
            this.txtDoingVip = new System.Windows.Forms.Label();
            this.txtDoingOnline = new System.Windows.Forms.Label();
            this.txtDoingGuest = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "none";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(629, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng lượng khách vào";
            // 
            // CountPassenger
            // 
            this.CountPassenger.AutoSize = true;
            this.CountPassenger.BackColor = System.Drawing.Color.White;
            this.CountPassenger.Location = new System.Drawing.Point(131, 47);
            this.CountPassenger.Name = "CountPassenger";
            this.CountPassenger.Size = new System.Drawing.Size(13, 13);
            this.CountPassenger.TabIndex = 5;
            this.CountPassenger.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số khách cửa thương gia";
            // 
            // CountViper
            // 
            this.CountViper.AutoSize = true;
            this.CountViper.BackColor = System.Drawing.Color.Red;
            this.CountViper.Location = new System.Drawing.Point(172, 132);
            this.CountViper.Name = "CountViper";
            this.CountViper.Size = new System.Drawing.Size(13, 13);
            this.CountViper.TabIndex = 6;
            this.CountViper.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số khách cửa online";
            // 
            // CountOnliner
            // 
            this.CountOnliner.AutoSize = true;
            this.CountOnliner.BackColor = System.Drawing.Color.Chartreuse;
            this.CountOnliner.Location = new System.Drawing.Point(172, 164);
            this.CountOnliner.Name = "CountOnliner";
            this.CountOnliner.Size = new System.Drawing.Size(13, 13);
            this.CountOnliner.TabIndex = 8;
            this.CountOnliner.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số khách cửa bình thường";
            // 
            // CountGuests
            // 
            this.CountGuests.AutoSize = true;
            this.CountGuests.BackColor = System.Drawing.Color.Yellow;
            this.CountGuests.Location = new System.Drawing.Point(172, 197);
            this.CountGuests.Name = "CountGuests";
            this.CountGuests.Size = new System.Drawing.Size(13, 13);
            this.CountGuests.TabIndex = 10;
            this.CountGuests.Text = "0";
            // 
            // txtTimeStartVip
            // 
            this.txtTimeStartVip.Location = new System.Drawing.Point(261, 125);
            this.txtTimeStartVip.Name = "txtTimeStartVip";
            this.txtTimeStartVip.Size = new System.Drawing.Size(52, 20);
            this.txtTimeStartVip.TabIndex = 13;
            this.txtTimeStartVip.Text = "1";
            // 
            // txtTimeEndVip
            // 
            this.txtTimeEndVip.Location = new System.Drawing.Point(338, 125);
            this.txtTimeEndVip.Name = "txtTimeEndVip";
            this.txtTimeEndVip.Size = new System.Drawing.Size(52, 20);
            this.txtTimeEndVip.TabIndex = 14;
            this.txtTimeEndVip.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "từ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thời gian xử lí ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "từ";
            // 
            // txtTimeEndOnline
            // 
            this.txtTimeEndOnline.Location = new System.Drawing.Point(338, 157);
            this.txtTimeEndOnline.Name = "txtTimeEndOnline";
            this.txtTimeEndOnline.Size = new System.Drawing.Size(52, 20);
            this.txtTimeEndOnline.TabIndex = 19;
            this.txtTimeEndOnline.Text = "4";
            // 
            // txtTimeStartOnline
            // 
            this.txtTimeStartOnline.Location = new System.Drawing.Point(261, 157);
            this.txtTimeStartOnline.Name = "txtTimeStartOnline";
            this.txtTimeStartOnline.Size = new System.Drawing.Size(52, 20);
            this.txtTimeStartOnline.TabIndex = 18;
            this.txtTimeStartOnline.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "từ";
            // 
            // txtTimeEndGuest
            // 
            this.txtTimeEndGuest.Location = new System.Drawing.Point(338, 190);
            this.txtTimeEndGuest.Name = "txtTimeEndGuest";
            this.txtTimeEndGuest.Size = new System.Drawing.Size(52, 20);
            this.txtTimeEndGuest.TabIndex = 23;
            this.txtTimeEndGuest.Text = "6";
            // 
            // txtTimeStartGuest
            // 
            this.txtTimeStartGuest.Location = new System.Drawing.Point(261, 190);
            this.txtTimeStartGuest.Name = "txtTimeStartGuest";
            this.txtTimeStartGuest.Size = new System.Drawing.Size(52, 20);
            this.txtTimeStartGuest.TabIndex = 22;
            this.txtTimeStartGuest.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tổng SL khách Thương gia xong";
            // 
            // CountViperDone
            // 
            this.CountViperDone.AutoSize = true;
            this.CountViperDone.BackColor = System.Drawing.Color.Red;
            this.CountViperDone.Location = new System.Drawing.Point(705, 128);
            this.CountViperDone.Name = "CountViperDone";
            this.CountViperDone.Size = new System.Drawing.Size(13, 13);
            this.CountViperDone.TabIndex = 25;
            this.CountViperDone.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(540, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Tổng SL khách Online xong";
            // 
            // CountOnlineDone
            // 
            this.CountOnlineDone.AutoSize = true;
            this.CountOnlineDone.BackColor = System.Drawing.Color.Chartreuse;
            this.CountOnlineDone.Location = new System.Drawing.Point(707, 160);
            this.CountOnlineDone.Name = "CountOnlineDone";
            this.CountOnlineDone.Size = new System.Drawing.Size(13, 13);
            this.CountOnlineDone.TabIndex = 27;
            this.CountOnlineDone.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Tổng SL khách bình thường";
            // 
            // CountGuestsDone
            // 
            this.CountGuestsDone.AutoSize = true;
            this.CountGuestsDone.BackColor = System.Drawing.Color.Yellow;
            this.CountGuestsDone.Location = new System.Drawing.Point(707, 193);
            this.CountGuestsDone.Name = "CountGuestsDone";
            this.CountGuestsDone.Size = new System.Drawing.Size(13, 13);
            this.CountGuestsDone.TabIndex = 30;
            this.CountGuestsDone.Text = "0";
            // 
            // txtDoingVip
            // 
            this.txtDoingVip.AutoSize = true;
            this.txtDoingVip.BackColor = System.Drawing.Color.Red;
            this.txtDoingVip.Location = new System.Drawing.Point(444, 128);
            this.txtDoingVip.Name = "txtDoingVip";
            this.txtDoingVip.Size = new System.Drawing.Size(35, 13);
            this.txtDoingVip.TabIndex = 32;
            this.txtDoingVip.Text = "Trống";
            // 
            // txtDoingOnline
            // 
            this.txtDoingOnline.AutoSize = true;
            this.txtDoingOnline.BackColor = System.Drawing.Color.Chartreuse;
            this.txtDoingOnline.Location = new System.Drawing.Point(444, 160);
            this.txtDoingOnline.Name = "txtDoingOnline";
            this.txtDoingOnline.Size = new System.Drawing.Size(35, 13);
            this.txtDoingOnline.TabIndex = 33;
            this.txtDoingOnline.Text = "Trống";
            // 
            // txtDoingGuest
            // 
            this.txtDoingGuest.AutoSize = true;
            this.txtDoingGuest.BackColor = System.Drawing.Color.Yellow;
            this.txtDoingGuest.Location = new System.Drawing.Point(444, 197);
            this.txtDoingGuest.Name = "txtDoingGuest";
            this.txtDoingGuest.Size = new System.Drawing.Size(35, 13);
            this.txtDoingGuest.TabIndex = 34;
            this.txtDoingGuest.Text = "Trống";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(432, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Hoạt động";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "label15";
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDoingGuest);
            this.Controls.Add(this.txtDoingOnline);
            this.Controls.Add(this.txtDoingVip);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CountGuestsDone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CountOnlineDone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CountViperDone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTimeEndGuest);
            this.Controls.Add(this.txtTimeStartGuest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimeEndOnline);
            this.Controls.Add(this.txtTimeStartOnline);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimeEndVip);
            this.Controls.Add(this.txtTimeStartVip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CountGuests);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CountOnliner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountViper);
            this.Controls.Add(this.CountPassenger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "none";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CountPassenger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CountViper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CountOnliner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CountGuests;
        private System.Windows.Forms.TextBox txtTimeStartVip;
        private System.Windows.Forms.TextBox txtTimeEndVip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimeEndOnline;
        private System.Windows.Forms.TextBox txtTimeStartOnline;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimeEndGuest;
        private System.Windows.Forms.TextBox txtTimeStartGuest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CountViperDone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label CountOnlineDone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CountGuestsDone;
        private System.Windows.Forms.Label txtDoingVip;
        private System.Windows.Forms.Label txtDoingOnline;
        private System.Windows.Forms.Label txtDoingGuest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

