using Islamic_Project.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islamic_Project
{
    public partial class MainScreen : Form
    {
        private MainPage mainPage;
        private UserControl1 PrayerTimes;
        private UserControl2 Athkar;
        private UserControl3 Tasbeeh;
        private UserControl4 Quraan;
        public MainScreen()
        {
            InitializeComponent();

             mainPage = new MainPage();
             PrayerTimes = new UserControl1();
            Athkar = new UserControl2();
            Tasbeeh = new UserControl3();
            Quraan = new UserControl4();

            panel2.Controls.Add(mainPage);
            panel2.Controls.Add(PrayerTimes);
            panel2.Controls.Add(Athkar);
            panel2.Controls.Add(Tasbeeh);
            panel2.Controls.Add(Quraan);

            foreach(Control c in panel2.Controls)
            {
                c.Dock = DockStyle.Fill;
            }

            mainPage.BringToFront();
         
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font(btn.Font, FontStyle.Underline);
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }

        private void btn_PrayerTimes_Click(object sender, EventArgs e)
        {
            PrayerTimes.BringToFront();
        }

        private void btn_MainPage_Click(object sender, EventArgs e)
        {
            mainPage.BringToFront();
        }

        private void btn_Athkar_Click(object sender, EventArgs e)
        {
            Athkar.BringToFront();
        }

        private void btn_Tasbeeh_Click(object sender, EventArgs e)
        {
            Tasbeeh.BringToFront();
        }

        private void btn_Quraan_Click(object sender, EventArgs e)
        {
            Quraan.BringToFront();
        }
    }
}
