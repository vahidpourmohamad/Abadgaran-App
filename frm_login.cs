using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Data.SqlClient;
using AutoUpdaterDotNET;

namespace Abadgaran
{
    public partial class frm_login : Form
    {
        string myUniqueID;
        public frm_login()
        {
            InitializeComponent();
        }
        private void AutoUpdater_ApplicationExitEvent()
        {
           
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

       
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                string saveStaff = " select * from tbl_users  where username=@username and pass=@pass";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = textBox1.Text;
                    querySaveStaff.Parameters.Add("@pass", System.Data.SqlDbType.NVarChar).Value = textBox2.Text;

                    openCon.Open();

                    SqlDataReader reader = querySaveStaff.ExecuteReader();
                    if(reader.HasRows==false)
                    {
                        MessageBox.Show("رمز عبور و یا نام کاربری درست نیست");
                    }
                    while (reader.Read())
                    {
                            if (textBox1.Text != "admin")
                            {
                                if (reader["cpu"] == DBNull.Value)
                                {
                                    cls_db_helper.updateCPU((int)reader["id"], myUniqueID);
                                }
                                else
                                {
                                    if (myUniqueID != reader["cpu"].ToString().Replace(" ", ""))
                                    {
                                        MessageBox.Show("خطا شماره 751 لطفا با پشتیبانی تماس بگیرید");
                                        break;
                                    }
                                }
                            }
                        cls_settting.name = reader["name"].ToString();
                        cls_settting.user_id = (int)reader["ID"];
                            cls_settting.type=(int)reader["type"];
                            frm_main frm = new frm_main();
                        frm.Show(this);
                        this.TopMost = false;
                        this.Hide();
                    }
                }
            }
            }
            catch (Exception)
            {

                MessageBox.Show("اتصال اینترنت را چک کنید");
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void frm_login_Load(object sender, EventArgs e)
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
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorID"].ToString();
            }
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystemProduct");
            ManagementObjectCollection moc = mos.Get();
            string motherBoard = "";
            foreach (ManagementObject mo in moc)
            {
                motherBoard = (string)mo["UUID"];
            }
            myUniqueID = id + motherBoard;

            //Console.WriteLine(myUniqueID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
