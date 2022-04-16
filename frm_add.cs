using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abadgaran
{
    public partial class frm_add : Form
    {
        public frm_add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_ajansname.Enabled = false;
            txt_mobile.Enabled = true;
            txt_sabet_phone.Enabled = true;
            label1.Text = "نام مالک";
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            txt_comment.Visible = true;
            label29.Visible = true;
            this.Size = new Size(1024, 255);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_frm_Load(object sender, EventArgs e)
        {
            cmb_compass.SelectedIndex = 0;
            cmb_dastrasi.SelectedIndex = 0;
            cmb_divar.SelectedIndex = 0;
            cmb_garmayesh.SelectedIndex = 0;
            cmb_kabin.SelectedIndex = 0;
            cmb_kabin.SelectedIndex = 0;
            cmb_kaf.SelectedIndex = 0;
            cmb_karbari.SelectedIndex = 0;
            txt_khab.Text = "0";
            cmb_mahale.SelectedIndex = 0;
            cmb_mantaghe.SelectedIndex = 0;
            cmb_parking.SelectedIndex = 0;
            cmb_sanad.SelectedIndex = 0;
            cmb_sarmayesh.SelectedIndex = 0;
            cmb_tarakom.SelectedIndex = 0;
            txt_vt.Text = "0";
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text.Replace(",","").ToString()) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
            if (txt_price.Text != string.Empty)
            {
                txt_price.Text = string.Format("{0:N0}", double.Parse(txt_price.Text.Replace(",", "")));
                txt_price.Select(txt_price.TextLength, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

         
            int er = 0;
            if (cmb_mantaghe.SelectedItem != null && cmb_mahale.SelectedItem != null)
            {
                if (cmb_mantaghe.SelectedItem.ToString() == "اعلام نشده" || cmb_mahale.SelectedItem.ToString() == "اعلام نشده")
                {
                    MessageBox.Show("حتما محله و منطقه را انتخاب کنید");
                    er++;
                }
            }
            else
            {
                MessageBox.Show("حتما محله و منطقه را انتخاب کنید");
                er++;
            }
            if(txt_name.Text=="")
            {
                MessageBox.Show("ورود نام اجباری است");
                er++;
            }

            string type = "";
            if (rdi_vilayi.Checked == true)
            {
                type = "خانه ویلایی";

            }
            if (rdi_apartment.Checked==true)
            {
                type = "آپارتمان";

            }
            if (rdi_fullapartment.Checked == true)
            {
                type = "مجتمع آپارتمانی";

            }
            if (rdi_store.Checked == true)
            {
                type = "تجاری";

            }
            if (rdi_pezeshk.Checked == true)
            {
                type = "آپارتمان اداری";

            }
            if (rdi_hotel.Checked == true)
            {
                type = "هتل";

            }

            if (rdi_farm.Checked == true)
            {
                type = "زمین کشاورزی";

            }
            if (rdi_sole.Checked == true)
            {
                type = "سوله";

            }
            if (rdi_bagh.Checked == true)
            {
                type = "باغ";

            }
            if (rdi_kolangi.Checked == true)
            {
                type = "کلنگی";

            }









            long rahn = 0;
            if (txt_rahn.Text != "")
            {
                if (txt_rahn.Text.Replace(",", "") != "")
                {
                    rahn = Convert.ToInt64(txt_rahn.Text.Replace(",", ""));
                }
                else
                {
                    rahn = 0;
                }
            }

            long ejare = 0;
            if (txt_rent.Text != "")
            {
                if (txt_rent.Text.Replace(",", "") != "")
                {
                    ejare = Convert.ToInt64(txt_rent.Text.Replace(",", ""));
                }
                else
                {
                    ejare = 0;
                }
            }

            long sale = 0;
            if (txt_price.Text != "")
            {
                if (txt_price.Text.Replace(",", "") != "")
                {
                    sale = Convert.ToInt64(txt_price.Text.Replace(",", ""));
                }
                else
                {
                    sale = 0;
                }
            }

            if( rdi_sale.Checked== true)
            {
                rahn = 0;
                ejare = 0;
              //  sale = Convert.ToInt64(txt_price.Text.Replace(",", ""));
            }
            else

            {
               // rahn = 0;
               // ejare = 0;
                sale = 0;
            }

            string mantaghe = "";
            if (cmb_mantaghe.SelectedItem!= null)
            {
                mantaghe = cmb_mantaghe.SelectedItem.ToString();
            }
            else
            {
                mantaghe = "";
            }

            string mahale = "";
            if (cmb_mahale.SelectedItem != null)
            {
                mahale = cmb_mahale.SelectedItem.ToString();
            }
            else
            {
                mahale = "";
            }
            if (er == 0)
            {
                bool res = cls_db_helper.db_add_melk(rdi_shakhsi.Checked, txt_name.Text, txt_ajansname.Text, txt_mobile.Text, txt_sabet_phone.Text, rdi_sale.Checked, sale, ejare, rahn, chk_moaveze.Checked, chk_mosharekat.Checked, chk_threeperson.Checked, chk_mojaradkhanom.Checked, chk_mojaradmard.Checked, chk_zooj.Checked, chk_tabdil.Checked, chk_khanevade.Checked, type, txt_addressasli.Text, txt_addressfari.Text, txt_pelak.Text, txt_addvahed.Text, mantaghe, mahale, Convert.ToInt32(txt_arse.Text), Convert.ToInt32(txt_zirbana.Text), Convert.ToInt32(txt_mabar.Text), Convert.ToInt32(txt_hashiye.Text), cmb_tarakom.SelectedItem.ToString(), cmb_dastrasi.SelectedItem.ToString(), cmb_compass.SelectedItem.ToString(), cmb_sanad.SelectedItem.ToString(), chk_mosha.Checked, cmb_karbari.SelectedItem.ToString(), Convert.ToInt32(txt_tabaghat.Text), Convert.ToInt32(txt_vahedkol.Text), Convert.ToInt32(txt_vt.Text.ToString()), Convert.ToInt32(txt_tabaghe.Text), txt_salsakht.Text, cmb_divar.SelectedItem.ToString(), cmb_kaf.SelectedItem.ToString(), cmb_garmayesh.SelectedItem.ToString(), cmb_sarmayesh.SelectedItem.ToString(), cmb_parking.SelectedItem.ToString(), Convert.ToInt32(txt_khab.Text.ToString()), cmb_kabin.SelectedItem.ToString(), chk_asansor.Checked, chk_anbari.Checked, chk_balcoon.Checked, chk_roof.Checked, chk_emtiyaz.Checked, chk_abi.Checked, chk_ejtemaat.Checked, chk_hamammaster.Checked, cls_settting.user_id, txt_comment.Text);
                if (res == true)
                {
                    MessageBox.Show("با موفقیت ثبت شد منتظر تایید ناظر");
                    this.Close();
                }
                if (res == false)
                {
                    MessageBox.Show("مشکلی وجود دارد");
                    this.Close();
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده لطفا با شماره 05191015508 تماس بگیرید");
                
            }
        }


        private void chk_moaveze_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_ajansname.Enabled = true;
            label1.Text = "نام مشاور";
            txt_mobile.Enabled = true;
            txt_sabet_phone.Enabled = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            txt_comment.Visible = true;
            label29.Visible = true;
            this.Size = new Size(1024, 255);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            this.Size = new Size(1024, 705);
            txt_addvahed.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
            groupBox4.Enabled = false;
            // button1.Location = new Point(-2, 0);
            //  txt_comment.Location = new Point(170, 3);
            //  label29.Location = new Point(906, 6);
        }

        private void rdi_sale_CheckedChanged(object sender, EventArgs e)
        {
            txt_rahn.Enabled = false;
            txt_rent.Enabled = false;
            chk_khanevade.Enabled = false;
            chk_mojaradkhanom.Enabled = false;
            chk_mojaradmard.Enabled = false;
            chk_tabdil.Enabled = false;
            chk_moaveze.Enabled = true;
            chk_mosharekat.Enabled = true;
            txt_price.Enabled = true;
            chk_zooj.Enabled = false;
            chk_threeperson.Enabled = false;
            this.Size = new Size(1024, 325);
        }

        private void rdi_rent_CheckedChanged(object sender, EventArgs e)
        {
            txt_rahn.Enabled = true;
            txt_rent.Enabled = true;
            chk_khanevade.Enabled = true;
            chk_zooj.Enabled = true;
            chk_threeperson.Enabled = true;
            chk_mojaradkhanom.Enabled = true;
            chk_mojaradmard.Enabled = true;
            chk_tabdil.Enabled = true;
            chk_moaveze.Enabled = false;
            chk_mosharekat.Enabled = false;
            txt_price.Enabled = false;

            cmb_sanad.Enabled = false;
            chk_mosha.Enabled = false;
            txt_arse.Enabled = false;
            cmb_tarakom.Enabled = false;
            this.Size = new Size(1024, 325);
        }

        private void rdi_farm_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            this.Size = new Size(1024, 705);
            // button1.Location = new Point(-2, 463);
            // txt_comment.Location = new Point(170, 463);
            //  label29.Location = new Point(906, 463);
            cmb_karbari.Items.Add("دیم و زارعت");
            cmb_karbari.Items.Add("گلخانه");
            cmb_karbari.Items.Add("باغ میوه");
            txt_addvahed.Enabled = false;
            txt_zirbana.Enabled = false;
            txt_mabar.Enabled = false;
            cmb_tarakom.Enabled = false;
            cmb_compass.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void rdi_zamin_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            this.Size = new Size(1024,705);
           // button1.Location = new Point(-2, 463);
           // txt_comment.Location = new Point(170, 463);
//label29.Location = new Point(906, 463);
        }

        private void rdi_apartment_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            this.Size = new Size(1024, 705);
            button1.Location = new Point(15, 619);
            txt_comment.Location = new Point(186,621);
            label29.Location = new Point(922,625);
            cmb_karbari.Enabled = false;
            cmb_tarakom.Enabled = false;

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void rdi_fullapartment_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            this.Size = new Size(1024, 705);
            button1.Location = new Point(15, 619);
            txt_comment.Location = new Point(186, 621);
            label29.Location = new Point(922, 625);

            txt_tabaghe.Enabled = false;
            txt_arse.Enabled = true;
            cmb_tarakom.Enabled = false;
            cmb_karbari.Enabled = false;
            txt_addvahed.Enabled = false;
            chk_mosha.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void rdi_store_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            this.Size = new Size(1024, 705);
            button1.Location = new Point(15, 619);
            txt_comment.Location = new Point(186, 621);
            label29.Location = new Point(922, 625);
            txt_arse.Enabled = false;
            cmb_tarakom.Enabled = false;
            cmb_kabin.Enabled = false;
            txt_vahedkol.Enabled = false;
            txt_vt.Enabled = false;
            chk_ejtemaat.Enabled = false;
            chk_asansor.Enabled = false;
            chk_hamammaster.Enabled = false;
            chk_roof.Enabled = false;
            chk_mosha.Enabled = false;
            chk_abi.Enabled = false;
            cmb_karbari.Enabled = false;
            txt_khab.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void rdi_pezeshk_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            this.Size = new Size(1024, 705);
            button1.Location = new Point(15, 619);
            txt_comment.Location = new Point(186, 621);
            label29.Location = new Point(922, 625);
            cmb_karbari.Items.Add("ساختمان پزشکان");
            cmb_karbari.Items.Add("ساختمان وکلا");
            cmb_karbari.Items.Add("اداری با مجوز تجاری");
            cmb_karbari.Items.Add("اداری عمومی بدون تجاری");
            txt_arse.Enabled = false;
            cmb_tarakom.Enabled = false;
            chk_mosha.Enabled = false;

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void rdi_bagh_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            this.Size = new Size(1024, 705);
            button1.Location = new Point(15, 619);
            txt_comment.Location = new Point(186, 621);
            label29.Location = new Point(922, 625);
            cmb_karbari.Enabled = false;
            txt_addvahed.Enabled = false;

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmb_tarakom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_bedroom_TextChanged(object sender, EventArgs e)
        {
                    }

        private void cmb_kabin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            this.Size = new Size(1024, 705);
            button1.Location = new Point(15, 619);
            txt_comment.Location = new Point(186, 621);
            label29.Location = new Point(922, 625);
            cmb_karbari.Items.Add("انبار");
            cmb_karbari.Items.Add("کارخانه");
            cmb_karbari.Items.Add("خالی");
  
          
            cmb_tarakom.Enabled = false;
            txt_addvahed.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void txt_rahn_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text.Replace(",", "").ToString()) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
            if (txt_rahn.Text != string.Empty)
            {
                txt_rahn.Text = string.Format("{0:N0}", double.Parse(txt_rahn.Text.Replace(",", "")));
                txt_rahn.Select(txt_rahn.TextLength, 0);
            }
        }

        private void txt_rent_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text.Replace(",", "").ToString()) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
            if (txt_rent.Text != string.Empty)
            {
                txt_rent.Text = string.Format("{0:N0}", double.Parse(txt_rent.Text.Replace(",", "")));
                txt_rent.Select(txt_rent.TextLength, 0);
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            this.Size = new Size(1024, 705);
            button1.Location = new Point(15, 619);
            txt_comment.Location = new Point(186, 621);
            label29.Location = new Point(922, 625);
            cmb_karbari.Items.Add("مهمان پذیر");
            cmb_karbari.Items.Add("هتل یک ستاره");
            cmb_karbari.Items.Add("هتل دو ستاره");
            cmb_karbari.Items.Add("هتل سه ستاره");
            cmb_karbari.Items.Add("هتل چهار ستاره");
            cmb_karbari.Items.Add("هتل پنج ستاره");
            cmb_karbari.Items.Add("هتل آپارتمان");
            cmb_karbari.Items.Add("خانه مسافر");
            txt_arse.Enabled = false;
            cmb_tarakom.Enabled = false;
            txt_addvahed.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void cmb_karbari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_mantaghe_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void cmb_mantaghe_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cmb_mantaghe.Enabled = false; 
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
            if (cmb_mantaghe.SelectedItem == "گلبهار")
            {
                cmb_mahale.Items.Add("گلبهار");

                cmb_mahale.Enabled = true;

            }
            if (cmb_mantaghe.SelectedItem == "شاندیز")
            {
                cmb_mahale.Items.Add("شاندیز");
        
                cmb_mahale.Enabled = true;

            }
            if (cmb_mantaghe.SelectedItem == "طرقبه")
            {
                cmb_mahale.Items.Add("طرقبه");

                cmb_mahale.Enabled = true;

            }
            if (cmb_mantaghe.SelectedItem == "مشهد")
            {
                cmb_mahale.Enabled = true;
                cmb_mahale.Items.Add("راه آهن");
                cmb_mahale.Items.Add("سیدی");
                cmb_mahale.Items.Add("کامیاب");
                cmb_mahale.Items.Add("مهر مادر");
                cmb_mahale.Items.Add("ساختمان");
                cmb_mahale.Items.Add("جاده سیمان");
                cmb_mahale.Items.Add("التیمور");
                cmb_mahale.Items.Add("خین عرب");
                cmb_mahale.Items.Add("کشاورز");
                cmb_mahale.Items.Add("برکپور");
                cmb_mahale.Items.Add("مصطفی خمینی");
                cmb_mahale.Items.Add("پنجتن");
                cmb_mahale.Items.Add("طرحچی");
                cmb_mahale.Items.Add("امام هادی");
                cmb_mahale.Items.Add("آزادی");
                cmb_mahale.Items.Add("جانباز");
                cmb_mahale.Items.Add("یاس");
                cmb_mahale.Items.Add("نارنج");
                cmb_mahale.Items.Add("نخل");
                cmb_mahale.Items.Add("گلدیس");
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
                cmb_mahale.Items.Add("قرهاد");
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
                cmb_mahale.Items.Add("کفایی");
                cmb_mahale.Items.Add("فلکه برق");
                cmb_mahale.Items.Add("فلکه آب");
                cmb_mahale.Items.Add("فلکه ضد");
                cmb_mahale.Items.Add("قاسم آباد");
                cmb_mahale.Items.Add("قائم");
                cmb_mahale.Items.Add("پرستار");
                cmb_mahale.Items.Add("کلاهدوز");
                cmb_mahale.Items.Add("شیرودی");
                cmb_mahale.Items.Add("کوثر");
                cmb_mahale.Items.Add("وکیل آباد");
                cmb_mahale.Items.Add("هفت تیر");
                cmb_mahale.Items.Add("هنرستان");
                cmb_mahale.Items.Add("مجیدیه");
                cmb_mahale.Items.Add("دانشجو");
                cmb_mahale.Items.Add("میدان تقی آباد");
                cmb_mahale.Items.Add("امیریه");
                cmb_mahale.Items.Add("عصمتیه");
                cmb_mahale.Items.Add("فکوری");
                ;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txt_ajansname_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_hamammaster_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_tabaghat_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if(IsAllDigits(temp.Text)== false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }
        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void txt_arse_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void txt_zirbana_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void txt_mabar_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void txt_hashiye_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void txt_vahedkol_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void txt_tabaghe_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void txt_salsakht_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void txt_khab_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void txt_vt_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            if (IsAllDigits(temp.Text) == false)
            {
                temp.Text = "";
                MessageBox.Show("فقط عدد وارد کنید");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_price.Text = "0";
            txt_price.Enabled = false;
               
        }

        private void rdi_vilayi_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            this.Size = new Size(1024, 705);
            button1.Location = new Point(15, 619);
            txt_comment.Location = new Point(186, 621);
            label29.Location = new Point(922, 625);
            cmb_karbari.Enabled = false;
            cmb_tarakom.Enabled = false;

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox5.Enabled = false;
        }
    }
}
