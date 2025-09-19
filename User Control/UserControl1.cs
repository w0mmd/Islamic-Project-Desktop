using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islamic_Project.User_Control
{
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private DateTime FajurTime;
        private DateTime DuhurTime;
        private DateTime AsurTime;
        private DateTime MaghribTime;
        private DateTime IshaTime;
        private DateTime NextAthanTime;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            FajurTime = DateTime.Today.AddHours(5).AddMinutes(11);
            DuhurTime = DateTime.Today.AddHours(13).AddMinutes(6);
            AsurTime = DateTime.Today.AddHours(16).AddMinutes(35);
            MaghribTime = DateTime.Today.AddHours(19).AddMinutes(20);
            IshaTime = DateTime.Today.AddHours(20).AddMinutes(41);

            SetNextAthan();
            ScheduleAthan();

        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.Black;

            Pen pen = new Pen(color);
            pen.Width = 3;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 500, 250, 1110, 250);


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lbl2_TimeNow_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl2_TimeNow.Text = System.DateTime.Now.ToString("T");

        }

        private void SetNextAthan()
        {
            DateTime now = DateTime.Now;

            if (now < FajurTime)
            {
                NextAthanTime = FajurTime;
                lbl_NextAthanName.Text = "الفجر";
            }
            else if(now < DuhurTime)
            {
                NextAthanTime = DuhurTime;
                lbl_NextAthanName.Text = "الظهر";
            }
            else if(now < AsurTime)
            {
                NextAthanTime = AsurTime;
                lbl_NextAthanName.Text = "العصر";
            }
            else if(now < MaghribTime)
            {
                NextAthanTime = MaghribTime;
                lbl_NextAthanName.Text = "المغرب";
            }
            else if(now < IshaTime)
            {
                NextAthanTime = IshaTime;
                lbl_NextAthanName.Text = "العشاء";
            }
            else
            {
                FajurTime = FajurTime.AddDays(1);
                DuhurTime = DuhurTime.AddDays(1);
                AsurTime = AsurTime.AddDays(1);
                MaghribTime = MaghribTime.AddDays(1);
                IshaTime = IshaTime.AddDays(1);

                NextAthanTime = FajurTime;
                lbl_NextAthanName.Text = "الفجر";
            }
        }

        private void ScheduleAthan()
        {
            timer2.Interval = 1000;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = NextAthanTime - DateTime.Now;

            if(ts.TotalMinutes > 0)
            {
                lbl_RemainingTime.Text = ts.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer2.Stop();
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipTitle = "تذكير";
                notifyIcon1.BalloonTipText = "حان موعد الأذان";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(1000);

                SetNextAthan();
                ScheduleAthan();
                
            }
        }
    }
}
