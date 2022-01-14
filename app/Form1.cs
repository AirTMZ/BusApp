using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TimerConst.ForeColor = Color.FromArgb(215, 70, 61);
            TimeLabels.ForeColor = Color.FromArgb(215, 70, 61);
            ExpireLabel.ForeColor = Color.FromArgb(113, 114, 109);
        }
        private void GenButton_Click(object sender, EventArgs e)
        {
            if (InputBox.Text == "" || String.Concat(InputBox.Text.Where(c => !Char.IsWhiteSpace(c))) == "")
            {
                TextField.Text = "blast";
            }
            else
            {
                TextField.Text = InputBox.Text;
            }
            string time = DateTime.Now.ToShortTimeString();

            time = time.Replace(" AM", "");
            time = time.Replace(" PM", "");

            List<string> list = new List<string>();
            list = time.Split(':').ToList();

            int hour = Int32.Parse(list[0]);
            int min = Int32.Parse(list[1]);

            min = min + 30;
            if (min > 60)
            {
                min = min - 60;
                hour = hour + 1;
            }

            string ext = "th";
            string date = $"{DateTime.UtcNow.Date}";
            date = date.Split('/')[0];
            date = date.Replace("0", "");
            time = $"{hour}:{min}";

            if (int.Parse(date) == 1)
            {
                ext = "st";
            }
            else if (int.Parse(date) == 2)
            {
                ext = "nd";
            }
            else if (int.Parse(date) == 3)
            {
                ext = "rd";
            }

            date = $"{date}{ext}";
            string day = System.DateTime.Now.ToString("dddd");
            day = day.Substring(0, 3);
            string month = DateTime.Now.Month.ToString();
            month = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(int.Parse(month));
            month = month.Substring(0, 3);
            ExpireLabel.Text = $"Expires {time}, {day} {date} {month}";
            CurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            InputBox.Visible = false;
            GenButton.Visible = false;
            BackImage.Visible = true;
            ExpireLabel.Visible = true;
            TimeLabels.Visible = true;
            TimerConst.Visible = true;
            CurrentTime.Visible = true;
            QR2.Visible = true;


            GifBox.Visible = true;
            TextField.Visible = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        int min2 = 29;
        int sec2 = 59;
        string min3 = "29";
        string sec3 = "";
        private void Timer()
        {
            if (min2 != 0)
            {
                if (sec2 == 0)
                {
                    min2=min2-1;
                    sec2 = 59;
                    if (min2 < 10)
                    {
                        min3 = $"0{min2}";
                    }
                    else
                    {
                        min3 = $"{min2}";
                    }
                }
                else
                {
                    sec2=sec2-1;
                    if (sec2 < 10)
                    {
                        sec3 = $"0{sec2}";
                    }
                    else
                    {
                        sec3 = $"{sec2}";
                    }
                }
                TimerConst.Text = $"00  :  00  :  {min3}  :  {sec3}";
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer();
        }
        public int timelast;
        private void Time()
        {
            CurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            Time();
        }
    }
}
