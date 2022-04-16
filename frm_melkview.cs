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
    public partial class frm_melkview : Form
    {
        public frm_melkview()
        {
            InitializeComponent();
        }

        private void frm_melkview_Load(object sender, EventArgs e)
        {

           lbl_comment_count.Text+=cls_db_helper.db_commnet_count(cls_settting.melk_view_ID).ToString();
            int rate = cls_db_helper.db_commnet_rate_avg(cls_settting.melk_view_ID);
            if (rate>0)
            {
                lbl_rate_avg.Text += rate.ToString();
            }
            else
            {
                lbl_rate_avg.Text += "ندارد";
            }


            string sql_command = "SELECT     comment as نظر FROM  dbo.tbl_comment WHERE melk_id='" + cls_settting.melk_view_ID+"'";
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
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                string saveStaff = " select * from tbl_melk where ID=@id";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@id", System.Data.SqlDbType.Int, 30).Value = cls_settting.melk_view_ID;

                    openCon.Open();

                    SqlDataReader reader = querySaveStaff.ExecuteReader();
                    while (reader.Read())
                    {

                        if ((bool)reader["erae_dahande"] == true)
                        {
                            label1.Text = "شخصی";

                        }
                        else
                        {
                            label1.Text = "بنگاه";
                        }
                        label4.Text = reader["name"] + " " + reader["namebongah"] + " " + reader["mobile"] + " " + reader["telephone"];
                        if ((bool)reader["sale"] == true)
                        {
                            label57.Text = "جهت فروش";
                            if (reader["sale_price"].ToString() == "0")
                            {
                                label6.Text = "قیمت این ملک توافقی می باشد";
                            }
                            else
                            {
                                label6.Text = string.Format("{0:N0}", double.Parse(reader["sale_price"].ToString().Replace(",", ""))) + "تومان";
                            }
                            if ((bool)reader["moaveze"] == true)
                            {
                                label6.Text += " قابل معاوضه است ";
                            }

                            label11.Visible = false;
                            label12.Visible = false;
                        }
                        else
                        {
                            label57.Text = "جهت اجاره";
                            label6.Text = "مبلغ اجاره " + string.Format("{0:N0}", double.Parse(reader["rent_price"].ToString().Replace(",", ""))) + " تومان-" + " مبلغ ودیعه " + string.Format("{0:N0}", double.Parse(reader["vadiye_price"].ToString().Replace(",", ""))) + " تومان";
                            if ((bool)reader["tabdil"] == true)
                            {
                                label6.Text += "- " + " قابل تبدیل است ";
                            }

                            if ((bool)reader["threeperson_family"] == true)
                            {
                                label12.Text += "- " + "خانواده سه نفره ";
                            }
                            if ((bool)reader["mojarad"] == true)
                            {
                                label12.Text += "- " + "مجرد خانم ";
                            }
                            if ((bool)reader["mojarad_mard"] == true)
                            {
                                label12.Text += "- " + "مجرد آقا ";
                            }
                            if ((bool)reader["zooj"] == true)
                            {
                                label12.Text += "- " + "زوج ";
                            }
                            if ((bool)reader["family"] == true)
                            {
                                label12.Text += "- " + "خانواده ";
                            }
                        }
                        label7.Text = "خیابان " + reader["address_asli"] + " کوچه " + reader["address_fari"] + " پلاک " + reader["address_pelak"] + " واحد " + reader["address_vahed"];

                        if(reader["divar"].ToString() != "اعلام نشده")
                        {
                            label50.Text += reader["divar"] + " ";
                        }
                        if (reader["kabin"].ToString() != "اعلام نشده")
                        {
                            label50.Text += reader["kabin"] + " ";
                        }
                        if (reader["parking"].ToString() != "اعلام نشده")
                        {
                            label50.Text += " پارکینگ "+reader["parking"] + " ";
                        }

                        if (reader["sarmayesh"].ToString() != "اعلام نشده")
                        {
                            label50.Text += reader["sarmayesh"] + " ";
                        }
                        if (reader["garmayesh"].ToString() != "اعلام نشده")
                        {
                            label50.Text += reader["garmayesh"] + " ";
                        }
                        if (reader["kaf"].ToString() != "اعلام نشده")
                        {
                            label50.Text += reader["kaf"] + " ";
                        }
                    //    label50.Text = reader["divar"] + " - " + reader["kaf"] + " - " + reader["garmayesh"] + " - " + reader["sarmayesh"] + " - پارکینگ " + reader["parking"] + " - " + reader["kabin"];
                        /*,[asamsor]
      ,[anbari]
      ,[balcone]
      ,[roof]
      ,[emtiyazat]
      ,[abi]
      ,[salon]
      ,[master]*/
                        label38.Text = reader["comment"].ToString();
                        if ((bool)reader["asamsor"] == true)
                        {
                            label50.Text += " - " + "آسانسور";
                        }
                        if ((bool)reader["anbari"] == true)
                        {
                            label50.Text += " - " + "انباری";
                        }
                        if ((bool)reader["balcone"] == true)
                        {
                            label50.Text += " - " + "بالکن";
                        }
                        if ((bool)reader["roof"] == true)
                        {
                            label50.Text += " - " + "روف گاردن";
                        }
                        if ((bool)reader["emtiyazat"] == true)
                        {
                            label50.Text += " - " + "امتیازات مستقل";
                        }
                        if ((bool)reader["abi"] == true)
                        {
                            label50.Text += " - " + "مجموعه آبی";
                        }
                        if ((bool)reader["salon"] == true)
                        {
                            label50.Text += " - " + "سالن اجتماعات";
                        }
                        if ((bool)reader["master"] == true)
                        {
                            label50.Text += " - " + "حمام مستر";
                        }

                        if (reader["khab"] != "0")
                        {
                            label39.Text = reader["khab"].ToString();
                        }
                        else
                        {
                            label39.Text = "-";
                        }
                        if (reader["tabaghat"] != "0")
                        {
                            label44.Text = reader["tabaghat"].ToString();
                        }
                        else
                        {
                            label44.Text = "-";
                        }
                        if (reader["tabaghe"] != "0")
                        {
                            label46.Text = reader["tabaghe"].ToString();
                        }
                        else
                        {
                            label46.Text = "-";
                        }
                        if (reader["salsakht"] != "0")
                        {
                            label48.Text = reader["salsakht"].ToString();
                        }
                        else
                        {
                            label48.Text = "-";
                        }
                        if (reader["tedadkolvahed"] != "0")
                        {
                            label35.Text = reader["tedadkolvahed"].ToString();
                        }
                        else
                        {
                            label35.Text = "-";
                        }
                        if (reader["tedadvaheddartabaghe"] != "0")
                        {
                            label42.Text = reader["tedadvaheddartabaghe"].ToString();
                        }
                        else
                        {
                            label42.Text = "-";
                        }

                        label55.Text = cls_db_helper.ToPersianDateString((DateTime)reader["created_date"]);
                        if(reader["type"].ToString() != "اعلام نشده")
                        label9.Text = reader["type"].ToString();
                        if (reader["mantaghe"].ToString() != "اعلام نشده")
                            label15.Text = reader["mantaghe"].ToString();
                        if (reader["mahale"].ToString() != "اعلام نشده")
                            label17.Text = reader["mahale"].ToString();
                        if (reader["zirbana"].ToString() != "اعلام نشده")
                            label13.Text = reader["zirbana"].ToString() + " متر";
                        if (reader["area"].ToString() != "اعلام نشده")
                            label19.Text = reader["area"].ToString() + " متر";
                        if (reader["tarakom"].ToString() != "اعلام نشده")
                            label21.Text = reader["tarakom"].ToString();
                        if (reader["hashiye"].ToString() != "اعلام نشده")
                            label23.Text = reader["hashiye"].ToString() + " متر";
                        if (reader["arzemabar"].ToString() != "اعلام نشده")
                            label25.Text = reader["arzemabar"].ToString() + " متر";

                        if (reader["sanad"].ToString() != "اعلام نشده")
                            label27.Text = reader["sanad"].ToString();
                        if (reader["karbari"].ToString() != "اعلام نشده")
                            label29.Text = reader["karbari"].ToString();
                        if (reader["dastarasi"].ToString() != "اعلام نشده")
                            label31.Text = reader["dastarasi"].ToString();
                        if (reader["sakhteman"].ToString() != "اعلام نشده")
                            label33.Text = reader["sakhteman"].ToString();
                    }
                }
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comment = "";
            comment = textBox1.Text;
            if (checkBox4.Checked == true)
            {
                comment += " -بازسازی شده و خوب ";
            }
            if (checkBox5.Checked == true)
            {
                comment += " -قیمت مناسب ";
            }
            if (checkBox2.Checked == true)
            {
                comment += " -موقعیت مکانی عالی";
            }
            if (checkBox3.Checked == true)
            {
                comment += " -بیش از حد کهنه ";
            }
            if (checkBox1.Checked == true)
            {
                comment += " -بیش از ارزش واقعی ";
            }
            int rate = -1;
            if (comboBox1.SelectedItem != null)
            {
                rate = Convert.ToInt16(comboBox1.SelectedItem.ToString());
            }
            cls_db_helper.db_comment_add(cls_settting.melk_view_ID, cls_settting.user_id, comment, rate);
            MessageBox.Show("نظر شما ثبت شد");
            groupBox1.Enabled = false;

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
 * ,[erae_dahande]
      ,[name]
      ,[namebongah]
      ,[mobile]
      ,[telephone]
      ,[sale]
      ,[sale_price]
      ,[rent_price]
      ,[vadiye_price]
      ,[moaveze]
      ,[mosharekat]
      ,[threeperson_family]
      ,[mojarad]
      ,[mojarad_mard]
      ,[zooj]
      ,[tabdil]
      ,[family]
      ,[type]
      ,[address_asli]
      ,[address_fari]
      ,[address_pelak]
      ,[address_vahed]
      ,[mantaghe]
      ,[mahale]
      ,[area]
      ,[zirbana]
      ,[arzemabar]
      ,[hashiye]
      ,[tarakom]
      ,[dastarasi]
      ,[sakhteman]
      ,[sanad]
      ,[mosha]
      ,[karbari]
      ,[tabaghat]
      ,[tedadkolvahed]
      ,[tedadvaheddartabaghe]
      ,[tabaghe]
      ,[salsakht]
      ,[divar]
      ,[kaf]
      ,[garmayesh]
      ,[sarmayesh]
      ,[parking]
      ,[khab]
      ,[kabin]
      ,[asamsor]
      ,[anbari]
      ,[balcone]
      ,[roof]
      ,[emtiyazat]
      ,[abi]
      ,[salon]
      ,[master]
      ,[user_created_id]
      ,[created_date]
      ,[enable]
      ,[comment]
*/
