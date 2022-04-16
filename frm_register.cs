using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Amlakino
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }
        private void AutoUpdater_ApplicationExitEvent()
        {

            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            AutoUpdater.Start("http://amlakinoapp.ir/ver/app.xml");
            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
            AutoUpdater.AppTitle = "املاکی نو";
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;


            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("نام کاربری نمی تواند خالی باشد");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("رمز عبور نمی تواند خالی باشد");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("نام نمی تواند خالی باشد");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("موبایل نمی تواند خالی باشد");
            }
            if (textBox3.Text.Length<11 || textBox3.Text.Substring(0,2)!="09")
            {
                MessageBox.Show("موبایل را صحیح وارد کنید");
            }
            Abadgaran.cls_db_helper.db_user_add(textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text, DateTime.Now, DateTime.Now, 0, 2, "");
            Abadgaran.Properties.Settings.Default.first_time = false;
            Abadgaran.Properties.Settings.Default.Save();
            MessageBox.Show("پیشنهاد می شود ابتدا فونتهای داخل پوشه فونت را نصب کنید و بعد دوباره برنامه را اجرا کنید");
            Application.Exit();

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void frm_register_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("لطفا دوباره برنامه را اجرا کنید");
            Application.Exit();
        }
    }
}
