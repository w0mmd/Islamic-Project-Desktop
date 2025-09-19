namespace Islamic_Project
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Quraan = new System.Windows.Forms.Button();
            this.btn_Athkar = new System.Windows.Forms.Button();
            this.btn_Tasbeeh = new System.Windows.Forms.Button();
            this.btn_PrayerTimes = new System.Windows.Forms.Button();
            this.btn_MainPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Quraan);
            this.panel1.Controls.Add(this.btn_Athkar);
            this.panel1.Controls.Add(this.btn_Tasbeeh);
            this.panel1.Controls.Add(this.btn_PrayerTimes);
            this.panel1.Controls.Add(this.btn_MainPage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 124);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Islamic_Project.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(30, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Quraan
            // 
            this.btn_Quraan.FlatAppearance.BorderSize = 0;
            this.btn_Quraan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quraan.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quraan.ForeColor = System.Drawing.Color.Navy;
            this.btn_Quraan.Location = new System.Drawing.Point(697, 11);
            this.btn_Quraan.Name = "btn_Quraan";
            this.btn_Quraan.Size = new System.Drawing.Size(102, 100);
            this.btn_Quraan.TabIndex = 4;
            this.btn_Quraan.Text = "القرآن";
            this.btn_Quraan.UseVisualStyleBackColor = true;
            this.btn_Quraan.Click += new System.EventHandler(this.btn_Quraan_Click);
            this.btn_Quraan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btn_Quraan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // btn_Athkar
            // 
            this.btn_Athkar.FlatAppearance.BorderSize = 0;
            this.btn_Athkar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Athkar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Athkar.ForeColor = System.Drawing.Color.Navy;
            this.btn_Athkar.Location = new System.Drawing.Point(953, 11);
            this.btn_Athkar.Name = "btn_Athkar";
            this.btn_Athkar.Size = new System.Drawing.Size(132, 100);
            this.btn_Athkar.TabIndex = 3;
            this.btn_Athkar.Text = "الأذكار";
            this.btn_Athkar.UseVisualStyleBackColor = true;
            this.btn_Athkar.Click += new System.EventHandler(this.btn_Athkar_Click);
            this.btn_Athkar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btn_Athkar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // btn_Tasbeeh
            // 
            this.btn_Tasbeeh.FlatAppearance.BorderSize = 0;
            this.btn_Tasbeeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tasbeeh.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tasbeeh.ForeColor = System.Drawing.Color.Navy;
            this.btn_Tasbeeh.Location = new System.Drawing.Point(805, 11);
            this.btn_Tasbeeh.Name = "btn_Tasbeeh";
            this.btn_Tasbeeh.Size = new System.Drawing.Size(142, 100);
            this.btn_Tasbeeh.TabIndex = 2;
            this.btn_Tasbeeh.Text = "التسبيح";
            this.btn_Tasbeeh.UseVisualStyleBackColor = true;
            this.btn_Tasbeeh.Click += new System.EventHandler(this.btn_Tasbeeh_Click);
            this.btn_Tasbeeh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btn_Tasbeeh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // btn_PrayerTimes
            // 
            this.btn_PrayerTimes.FlatAppearance.BorderSize = 0;
            this.btn_PrayerTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrayerTimes.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrayerTimes.ForeColor = System.Drawing.Color.Navy;
            this.btn_PrayerTimes.Location = new System.Drawing.Point(1091, 11);
            this.btn_PrayerTimes.Name = "btn_PrayerTimes";
            this.btn_PrayerTimes.Size = new System.Drawing.Size(206, 100);
            this.btn_PrayerTimes.TabIndex = 1;
            this.btn_PrayerTimes.Text = "مواقيت الصلاة";
            this.btn_PrayerTimes.UseVisualStyleBackColor = true;
            this.btn_PrayerTimes.Click += new System.EventHandler(this.btn_PrayerTimes_Click);
            this.btn_PrayerTimes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btn_PrayerTimes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // btn_MainPage
            // 
            this.btn_MainPage.FlatAppearance.BorderSize = 0;
            this.btn_MainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MainPage.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainPage.ForeColor = System.Drawing.Color.Navy;
            this.btn_MainPage.Location = new System.Drawing.Point(1303, 11);
            this.btn_MainPage.Name = "btn_MainPage";
            this.btn_MainPage.Size = new System.Drawing.Size(220, 100);
            this.btn_MainPage.TabIndex = 0;
            this.btn_MainPage.Text = "الصفحة الرئيسية";
            this.btn_MainPage.UseVisualStyleBackColor = true;
            this.btn_MainPage.Click += new System.EventHandler(this.btn_MainPage_Click);
            this.btn_MainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btn_MainPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1548, 631);
            this.panel2.TabIndex = 4;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 747);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_MainPage;
        private System.Windows.Forms.Button btn_PrayerTimes;
        private System.Windows.Forms.Button btn_Athkar;
        private System.Windows.Forms.Button btn_Tasbeeh;
        private System.Windows.Forms.Button btn_Quraan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

