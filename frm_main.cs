using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Abadgaran
{
    public partial class frm_main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            pictureBox1.Load("http://www.amlakinoapp.ir/Adv1.png");
            pictureBox2.Load("http://www.amlakinoapp.ir/Adv2.png");
            pictureBox3.Load("http://www.amlakinoapp.ir/Adv3.png");
            pictureBox4.Load("http://www.amlakinoapp.ir/Adv4.png");
            lbl_version.Text = "Version " + Application.ProductVersion;
            //   cls_db_helper.testconnection("test", "test2", "test3", "mobile", DateTime.Now, DateTime.Now, 10, 1, "cpu");
            lbl_date.Text = "امروز : " + cls_db_helper.ToPersianDateString(DateTime.Now);
            lbl_name.Text = cls_settting.name + " خوش آمدید ";

            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                using (SqlCommand sqlcommand = new SqlCommand("SELECT  Id as کد ,substring(FORMAT(sale_price, 'C0'), 2, len(FORMAT(sale_price, 'C0'))-1)  AS مبلغ, moaveze as معاوضه, mahale AS محله FROM  dbo.tbl_melk WHERE gold='1'"))
                {
                    sqlcommand.Connection = openCon;
                    SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
    DataTable dt = new DataTable();
    da.Fill(dt);
                    // this.dataGridView1.Visible = true;
                    dgw_gold.DataSource = dt;


                }
            }
            for (int i = 0; i <dgw_gold.RowCount; i++)
            {

               // string obj = (string)dgw_gold.Rows[i].DataBoundItem;//.DataBoundItem;

              //  obj = "test";
               // dgw_gold.Rows[i].Cells[2].ValueType=System.Type.
               // dgw_gold.Rows[i].Cells[2].Value =  string.Format("{0:N0}", double.Parse(dgw_gold.Rows[i].Cells[2].Value.ToString().Replace(",", ""))); ;
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_add frm = new frm_add();
            frm.ShowDialog();
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           frm_ejare_view frm = new frm_ejare_view();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_sale_view frm = new frm_sale_view();
            frm.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cls_settting.melk_view_ID = Convert.ToInt32(dgw_gold.Rows[e.RowIndex].Cells[1].Value);
            frm_melkview frm = new frm_melkview();
            frm.ShowDialog();
            cls_settting.melk_view_ID = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cls_settting.melk_view_ID = 10002;
            frm_melkview frm = new frm_melkview();
            frm.ShowDialog();
            cls_settting.melk_view_ID = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cls_settting.melk_view_ID = 10001;
            frm_melkview frm = new frm_melkview();
            frm.ShowDialog();
            cls_settting.melk_view_ID = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cls_settting.melk_view_ID = 10000;
            frm_melkview frm = new frm_melkview();
            frm.ShowDialog();
            cls_settting.melk_view_ID = 0;
        }

        private void اضافهکردنکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cls_settting.type ==3)
            {
                frm_user_add frm = new frm_user_add();
                frm.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
