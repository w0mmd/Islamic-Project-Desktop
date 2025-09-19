using Islamic_Project.Forms_Athkar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islamic_Project.User_Control
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AthkarSleep athkarSleep = new AthkarSleep();
            athkarSleep.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AthkarWakingupcs athkarWakingup = new AthkarWakingupcs();
            athkarWakingup.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AthkarSalat athkarSalat = new AthkarSalat();
            athkarSalat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AthkarAfterSalat athkarAfterSalat = new AthkarAfterSalat();
            athkarAfterSalat.Show();
        }

        private void btn_PrayerTimes_Click(object sender, EventArgs e)
        {
            AthkarEvening athkarEvening = new AthkarEvening();
            athkarEvening.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AthkarMorning athkarMorning = new AthkarMorning();
            athkarMorning.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AthkarTravelling athkarTravelling = new AthkarTravelling();
            athkarTravelling.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AthkarQuraan athkarQuraan = new AthkarQuraan();
            athkarQuraan.Show();
        }
    }
}
