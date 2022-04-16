using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abadgaran
{
    public partial class frm_ejare_view : Form
    {
        public frm_ejare_view()
        {
            InitializeComponent();
        }

        private void frm_ejare_view_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //  dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //   dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            string condition = " sale = 0";
            if (txt_minarea.Text != "")
            {
                condition += " AND zirbana >" + txt_minarea.Text;
            }
            if (txt_maxarea.Text != "")
            {
                condition += " AND zirbana <" + txt_maxarea.Text;
            }
            if (txt_rent.Text != "")
            {
                condition += " AND rent_price <" + txt_rent.Text.Replace(",", "");
            }
            if (txt_rahn.Text != "")
            {
                condition += " AND vadiye_price <" + txt_rahn.Text.Replace(",", "");
            }
            string type = "";
            if (rdi_apartment.Checked == true)
            {
                type = "آپارتمان";
                condition += " AND type='" + type + "'";

            }
            if (rdi_fullapartment.Checked == true)
            {
                type = "مجتمع آپارتمانی";
                condition += " AND type='" + type + "'";

            }
            if (rdi_store.Checked == true)
            {
                type = "تجاری";
                condition += " AND type='" + type + "'";

            }
            if (rdi_pezeshk.Checked == true)
            {
                type = "آپارتمان اداری";
                condition += " AND type='" + type + "'";

            }

            if (rdi_bagh.Checked == true)
            {
                type = "باغ";
                condition += " AND type='" + type + "'";
            }
            if (chk_mojarad.Checked == true)
            {
                condition += " AND mojarad=1";
            }
            if (cmb_mantaghe.SelectedItem != null)
            {
                condition += " AND mantaghe='" + cmb_mantaghe.SelectedItem + "'";
            }
            if (cmb_mahale.SelectedItem != null)
            {
                condition += " AND mahale='" + cmb_mahale.SelectedItem + "'";
            }
            condition += " AND gold='0'";
            string sql_command = "SELECT     id as کد, type as کاربری,  erae_dahande AS شخصی,substring(FORMAT(rent_price, 'C0'), 2, len(FORMAT(rent_price, 'C0'))-1)  AS اجاره, substring(FORMAT(vadiye_price, 'C0'), 2, len(FORMAT(vadiye_price, 'C0'))-1)  AS ودیعه, mojarad AS مجرد, tabdil AS [قابل تبدیل], mahale AS محله, zirbana AS زیربنا, khab AS خواب, asamsor AS اسانسور, tabaghe AS طبقه FROM  dbo.tbl_melk WHERE" + condition + "ORDER BY created_date DESC";
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                using (SqlCommand sqlcommand = new SqlCommand(sql_command))
                {
                    sqlcommand.Connection = openCon;
                    SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // this.dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;


                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cls_settting.melk_view_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                frm_melkview frm = new frm_melkview();
                frm.ShowDialog();
                cls_settting.melk_view_ID = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condition = " sale = 0";
            if(txt_minarea.Text!="")
            {
                condition += " AND zirbana >" + txt_minarea.Text;
            }
            if (txt_maxarea.Text != "")
            {
                condition += " AND zirbana <" + txt_maxarea.Text;
            }
            if (txt_rent.Text != "")
            {
                condition += " AND rent_price <" + txt_rent.Text.Replace(",","");
            }
            if (txt_rahn.Text != "")
            {
                condition += " AND vadiye_price <" + txt_rahn.Text.Replace(",", "");
            }
            string type = "";
            if (rdi_apartment.Checked == true)
            {
                type = "آپارتمان";
                condition += " AND type='" + type + "'";

            }
            if (rdi_fullapartment.Checked == true)
            {
                type = "مجتمع آپارتمانی";
                condition += " AND type='" + type + "'";

            }
            if (rdi_store.Checked == true)
            {
                type = "تجاری";
                condition += " AND type='" + type + "'";

            }
            if (rdi_pezeshk.Checked == true)
            {
                type = "آپارتمان اداری";
                condition += " AND type='" + type + "'";

            }
           
            if (rdi_bagh.Checked == true)
            {
                type = "باغ";
                condition += " AND type='" + type + "'";
            }
       if(chk_mojarad.Checked==true)
            {
                condition += " AND mojarad=1";
            }
            if(cmb_mantaghe.SelectedItem != null)
            {
                condition += " AND mantaghe='" + cmb_mantaghe.SelectedItem + "'";
            }
            if (cmb_mahale.SelectedItem != null)
            {
                condition += " AND mahale='" + cmb_mahale.SelectedItem + "'";
            }
            condition += " AND gold='0'";
           string sql_command = "SELECT     id as کد,   erae_dahande AS شخصی,substring(FORMAT(rent_price, 'C0'), 2, len(FORMAT(rent_price, 'C0'))-1)  AS اجاره, substring(FORMAT(vadiye_price, 'C0'), 2, len(FORMAT(vadiye_price, 'C0'))-1)  AS ودیعه, mojarad AS مجرد, tabdil AS [قابل تبدیل], mahale AS محله, zirbana AS زیربنا, khab AS خواب, asamsor AS اسانسور, tabaghe AS طبقه FROM  dbo.tbl_melk WHERE" + condition + "ORDER BY created_date DESC";
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                using (SqlCommand sqlcommand = new SqlCommand(sql_command))
                {
                    sqlcommand.Connection = openCon;
                    SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                   // this.dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;


                }
            }
        }

        private void rdi_apartment_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_mantaghe_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_mantaghe.Enabled = false;
            cmb_mahale.Items.Clear();
            if (cmb_mantaghe.SelectedItem == "خارج از محدوده شهری")
            {
                cmb_mahale.Items.Add("مایان");
                cmb_mahale.Items.Add("شاهنامه");
                cmb_mahale.Items.Add("ناظریه");
                cmb_mahale.Items.Add("اخلمد");
                cmb_mahale.Items.Add("گراخک");
                cmb_mahale.Items.Add("کلات");
                cmb_mahale.Items.Add("ترقدر");
                cmb_mahale.Items.Add("نقندر");
                cmb_mahale.Items.Add("زشک");
                cmb_mahale.Items.Add("حسن آباد");
                cmb_mahale.Items.Add("کلاته برفی");
                cmb_mahale.Items.Add("چهار فصل");
                cmb_mahale.Items.Add("ساغروان");
                cmb_mahale.Items.Add("کاهو");
                cmb_mahale.Enabled = true;

            }
            if (cmb_mantaghe.SelectedItem == "مشهد")
            {
                cmb_mahale.Enabled = true;
                cmb_mahale.Items.Add("هفده شهریور");
                cmb_mahale.Items.Add("آزادشهر");
                cmb_mahale.Items.Add("ابوطالب");
                cmb_mahale.Items.Add("احمد آباد");
                cmb_mahale.Items.Add("امام خمینی");
                cmb_mahale.Items.Add("امام رضا");
                cmb_mahale.Items.Add("امامت");
                cmb_mahale.Items.Add("اندیشه");
                cmb_mahale.Items.Add("الهیه");
                cmb_mahale.Items.Add("جلال آل احمد");
                cmb_mahale.Items.Add("بلوار توس");
                cmb_mahale.Items.Add("بلوار فردوسی");
                cmb_mahale.Items.Add("پیروزی");
                cmb_mahale.Items.Add("تورج");
                cmb_mahale.Items.Add("مجد");
                cmb_mahale.Items.Add("معلم");
                cmb_mahale.Items.Add("موسوی قوچانی");
                cmb_mahale.Items.Add("میدان شهدا");
                cmb_mahale.Items.Add("میدان عدل خمینی");
                cmb_mahale.Items.Add("گنبد سبز");
                cmb_mahale.Items.Add("گوهر شاد");
                cmb_mahale.Items.Add("لادن");
                cmb_mahale.Items.Add("مصلی");
                cmb_mahale.Items.Add("نوفل شاتو");
                cmb_mahale.Items.Add("شریعتی");
                cmb_mahale.Items.Add("راهنمایی");
                cmb_mahale.Items.Add("دلاوران");
                cmb_mahale.Items.Add("رضا شهر");
                cmb_mahale.Items.Add("سجاد");
                cmb_mahale.Items.Add("سرافرازان");
                cmb_mahale.Items.Add("سعدی");
                cmb_mahale.Items.Add("سناباد");
                cmb_mahale.Items.Add("سید رضی");
                cmb_mahale.Items.Add("آبکوه");
                cmb_mahale.Items.Add("شهید رجایی");
                cmb_mahale.Items.Add("شهید بهشتی");
                cmb_mahale.Items.Add("صارمی");
                cmb_mahale.Items.Add("کوهسنگی");
                cmb_mahale.Items.Add("رودکی");
                cmb_mahale.Items.Add("کوی مهدی");
                cmb_mahale.Items.Add("گاز شرقی");
                cmb_mahale.Items.Add("هاشمیه");
                cmb_mahale.Items.Add("نماز");
                cmb_mahale.Items.Add("خواجه ربیع");
                cmb_mahale.Items.Add("صیاد شیرازی");
                cmb_mahale.Items.Add("طبرسی");
                cmb_mahale.Items.Add("طرق");
                cmb_mahale.Items.Add("طلاب");
                cmb_mahale.Items.Add("عبادی");
                cmb_mahale.Items.Add("عبدالمطلب");
                cmb_mahale.Items.Add("فرامز عباسی");
                cmb_mahale.Items.Add("فلسطین");
                cmb_mahale.Items.Add("فلکه برق");
                cmb_mahale.Items.Add("فلکه آب");
                cmb_mahale.Items.Add("فلکه ضد");
                cmb_mahale.Items.Add("قاسم آباد");
                cmb_mahale.Items.Add("قائم");
                cmb_mahale.Items.Add("پرستار");
                cmb_mahale.Items.Add("کلاهدوز");
                cmb_mahale.Items.Add("کوثر");
                cmb_mahale.Items.Add("وکیل آباد");
                cmb_mahale.Items.Add("هفت تیر");
                cmb_mahale.Items.Add("هنرستان");
                cmb_mahale.Items.Add("مجیدیه");
                cmb_mahale.Items.Add("امیریه");
                cmb_mahale.Items.Add("عصمتیه");
                cmb_mahale.Items.Add("فکوری");
                ;
            }

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_rahn.Text != string.Empty)
            {
                txt_rahn.Text = string.Format("{0:N0}", double.Parse(txt_rahn.Text.Replace(",", "")));
                txt_rahn.Select(txt_rahn.TextLength, 0);
            }
        
        }

        private void txt_rent_TextChanged(object sender, EventArgs e)
        {
            if (txt_rent.Text != string.Empty)
            {
                txt_rent.Text = string.Format("{0:N0}", double.Parse(txt_rent.Text.Replace(",", "")));
                txt_rent.Select(txt_rent.TextLength, 0);
            }
        }
    }
}
