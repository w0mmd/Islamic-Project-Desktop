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
    public partial class UserControl3 : UserControl
    {

        public UserControl3()
        {
            InitializeComponent();
            AssignPicBoxTagToLabel();

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
        }

        private void AssignPicBoxTagToLabel()
        {
            pictureBox1.Tag = label1;
            pictureBox4.Tag = label2;
            pictureBox6.Tag = label3;
            pictureBox8.Tag = label4;
            pictureBox16.Tag = label8;
            pictureBox14.Tag = label7;
            pictureBox12.Tag = label6;
            pictureBox10.Tag = label5;

            pictureBox2.Tag = label1;
            pictureBox3.Tag = label2;
            pictureBox5.Tag = label3;
            pictureBox7.Tag = label4;
            pictureBox15.Tag = label8;
            pictureBox13.Tag = label7;
            pictureBox9.Tag = label5;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            var ClickedBox = sender as PictureBox;

            if(ClickedBox?.Tag is Label LabelText)
            {
                int Current = LabelText.Tag is int value ? value : 0;

                Current++;
                LabelText.Tag = Current;
                LabelText.Text = Current.ToString();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var Reset = sender as PictureBox;

            if(Reset?.Tag is Label LabelText)
            {
                LabelText.Tag = 0;
                LabelText.Text = "0";
            }
        }

        
    }
}
