using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DateTime dc;
        public int year;
        public int month;
        public int day;
        public int ismousedown = 0;
        public string[] StringDays = {"Sun","Mon","Tus","Wen","Thu","Fra","Sat"};
        public string[] StringMonths = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec" };

        private void Form1_Load(object sender, EventArgs e)
        {
            dc = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            year = dc.Year;
            month = dc.Month;
            day = dc.Day;
            label2.Text = year.ToString();
            label1.Text = day.ToString();
            label3.Text = month.ToString() + " " + StringMonths[month-1];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = 1;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = 0;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = 1;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }
    }
}
