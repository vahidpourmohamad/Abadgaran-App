using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace Abadgaran
{
    public static class cls_db_helper
    {
        public static int db_commnet_count(int melk_id)
        {
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                string saveStaff = " select count(*) as c from tbl_comment  where melk_id=@melk_id";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@melk_id", System.Data.SqlDbType.Int).Value = melk_id;
           

                    openCon.Open();

                    SqlDataReader reader = querySaveStaff.ExecuteReader();
              
                    while (reader.Read())
                    {
                        return ((int)reader["c"]);
                    }

                }
            }
            return (0);
        }
        public static int db_commnet_rate_avg(int melk_id)
        {
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                string saveStaff = " select AVG(rate) as c from tbl_comment  where melk_id=@melk_id and rate>0";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@melk_id", System.Data.SqlDbType.Int).Value = melk_id;


                    openCon.Open();

                    SqlDataReader reader = querySaveStaff.ExecuteReader();

                    while (reader.Read())
                    {
                       string temp= reader["c"].ToString();
                        if (reader["c"] != DBNull.Value)
                            return ((int)reader["c"]);
                        else
                            return (0);
                    }

                }
            }
            return (0);
        }
        public static bool db_comment_add(int melk_id,int user_created_id ,string commnet,int rate)
        {
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                string saveStaff = "INSERT INTO [dbo].[tbl_comment]([melk_id],[user_created_id],[comment],[rate])      VALUES(@melk_id,@user_created_id,@comment,@rate);";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@melk_id", System.Data.SqlDbType.Int).Value = melk_id;
                    querySaveStaff.Parameters.Add("@user_created_id", System.Data.SqlDbType.Int).Value = user_created_id;
                    querySaveStaff.Parameters.Add("@comment", SqlDbType.NVarChar).Value = commnet;
                    querySaveStaff.Parameters.Add("@rate", SqlDbType.Int).Value = rate;

                    openCon.Open();

                   int res= querySaveStaff.ExecuteNonQuery();
                    if(res>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static void updateCPU(int id,string cpu)
        {
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                string saveStaff = "  UPDATE[dbo].[tbl_users] SET [cpu]=@cpu where id= @id";
               

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@cpu", System.Data.SqlDbType.NVarChar).Value = cpu;
                    querySaveStaff.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();
                }
            }
        }
        public static string ToPersianDateString(DateTime georgianDate)
        {
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }
        public static void db_user_add(string name,string username,string pass,string mobile, DateTime date_renew,DateTime date_expire,int hack_code,int type,string cpu)
        {
            using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                string saveStaff = " INSERT INTO [dbo].[tbl_users]([username],[pass],[name],[mobile],[date_renew],[date_expire],[hack_code],[type])VALUES(@username,@pass,@name,@mobile,@date_renew,@date_expire,@hack_code,@type);";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = username;
                    querySaveStaff.Parameters.Add("@pass", System.Data.SqlDbType.NVarChar).Value = pass;
                    querySaveStaff.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    querySaveStaff.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = mobile;
                    querySaveStaff.Parameters.Add("@date_renew", SqlDbType.DateTime).Value = date_renew;
                    querySaveStaff.Parameters.Add("@date_expire", SqlDbType.DateTime).Value = date_expire;
                    querySaveStaff.Parameters.Add("@hack_code", SqlDbType.Int).Value = hack_code;
                    querySaveStaff.Parameters.Add("@type", SqlDbType.Int).Value = type;
                   // querySaveStaff.Parameters.Add("@cpu", SqlDbType.NVarChar).Value = cpu;
                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();
                }
            }
        }
        public static Boolean db_add_melk(bool erae_dahande, string name, string namebongah, string mobile, string telephone, bool sale, Int64 sale_price, Int64 rent_price, Int64 vadiye_price, bool moaveze, bool mosharekat, bool threeperson_family, bool mojarad, bool mojarad_mard, bool zooj, bool tabdil, bool family, string type, string address_asli, string address_fari, string address_pelak, string address_vahed, string mantaghe, string mahale, int area, int zirbana, int arzemabar, int hashiye, string tarakom, string dastarasi, string sakhteman, string sanad, bool mosha, string karbari, int tabaghat, int tedadkolvahed, int tedadvaheddartabaghe, int tabaghe, string salsakht, string divar, string kaf, string garmayesh, string sarmayesh, string parking, int khab, string kabin, bool asamsor, bool anbari, bool balcone, bool roof, bool emtiyazat, bool abi, bool salon, bool master, int user_created_id,string comment)
        {
         
        using (SqlConnection openCon = new SqlConnection(cls_settting.connection_string))
            {
                string saveStaff = "    INSERT INTO[dbo].[tbl_melk]([erae_dahande],[name],[namebongah],[mobile],[telephone],[sale],[sale_price],[rent_price],[vadiye_price],[moaveze],[mosharekat],[threeperson_family],[mojarad],[mojarad_mard],[zooj],[tabdil],[family],[type],[address_asli],[address_fari],[address_pelak],[address_vahed],[mantaghe],[mahale],[area],[zirbana],[arzemabar],[hashiye],[tarakom],[dastarasi],[sakhteman],[sanad],[mosha],[karbari],[tabaghat],[tedadkolvahed],[tedadvaheddartabaghe],[tabaghe],[salsakht],[divar],[kaf],[garmayesh],[sarmayesh],[parking],[khab],[kabin],[asamsor],[anbari],[balcone],[roof],[emtiyazat],[abi],[salon],[master],[user_created_id],[comment])      VALUES(@erae_dahande, @name, @namebongah, @mobile, @telephone, @sale, @sale_price, @rent_price, @vadiye_price, @moaveze, @mosharekat, @threeperson_family, @mojarad, @mojarad_mard, @zooj, @tabdil, @family, @type, @address_asli, @address_fari, @address_pelak, @address_vahed, @mantaghe, @mahale, @area, @zirbana, @arzemabar, @hashiye, @tarakom, @dastarasi, @sakhteman, @sanad, @mosha, @karbari, @tabaghat, @tedadkolvahed, @tedadvaheddartabaghe, @tabaghe, @salsakht, @divar, @kaf, @garmayesh, @sarmayesh, @parking, @khab, @kabin, @asamsor, @anbari, @balcone, @roof, @emtiyazat, @abi, @salon, @master, @user_created_id,@comment)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;




                    querySaveStaff.Parameters.Add("@erae_dahande", System.Data.SqlDbType.Bit).Value = erae_dahande;
                    querySaveStaff.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                    querySaveStaff.Parameters.Add("@namebongah", SqlDbType.NVarChar).Value = namebongah;
                    querySaveStaff.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = mobile;
                    querySaveStaff.Parameters.Add("@telephone", SqlDbType.NVarChar).Value = telephone;
                    querySaveStaff.Parameters.Add("@sale", SqlDbType.Bit).Value = sale;
                    querySaveStaff.Parameters.Add("@sale_price", SqlDbType.BigInt).Value = sale_price;
                    querySaveStaff.Parameters.Add("@rent_price", SqlDbType.BigInt).Value = rent_price;
                    querySaveStaff.Parameters.Add("@vadiye_price", SqlDbType.BigInt).Value = vadiye_price;

                    querySaveStaff.Parameters.Add("@moaveze", System.Data.SqlDbType.Bit).Value = moaveze;
                    querySaveStaff.Parameters.Add("@mosharekat", System.Data.SqlDbType.Bit).Value = mosharekat;
                    querySaveStaff.Parameters.Add("@threeperson_family", SqlDbType.Bit).Value = threeperson_family;
                    querySaveStaff.Parameters.Add("@mojarad", SqlDbType.Bit).Value = mojarad;
                    querySaveStaff.Parameters.Add("@mojarad_mard", SqlDbType.Bit).Value = mojarad_mard;
                    querySaveStaff.Parameters.Add("@zooj", SqlDbType.Bit).Value = zooj;
                    querySaveStaff.Parameters.Add("@tabdil", SqlDbType.Bit).Value = tabdil;
                    querySaveStaff.Parameters.Add("@family", SqlDbType.Bit).Value = family;
                    querySaveStaff.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;

                    querySaveStaff.Parameters.Add("@address_asli", System.Data.SqlDbType.NVarChar).Value = address_asli;
                    querySaveStaff.Parameters.Add("@address_fari", System.Data.SqlDbType.NVarChar).Value = address_fari;
                    querySaveStaff.Parameters.Add("@address_pelak", SqlDbType.NVarChar).Value = address_pelak;
                    querySaveStaff.Parameters.Add("@address_vahed", SqlDbType.NVarChar).Value = address_vahed;
                    querySaveStaff.Parameters.Add("@mantaghe", SqlDbType.NVarChar).Value = mantaghe;
                    querySaveStaff.Parameters.Add("@mahale", SqlDbType.NVarChar).Value = mahale;
                    querySaveStaff.Parameters.Add("@area", SqlDbType.Int).Value = area;
                    querySaveStaff.Parameters.Add("@zirbana", SqlDbType.Int).Value = zirbana;
                    querySaveStaff.Parameters.Add("@arzemabar", SqlDbType.Int).Value = arzemabar;
                    querySaveStaff.Parameters.Add("@hashiye", System.Data.SqlDbType.Int).Value = hashiye;
                    querySaveStaff.Parameters.Add("@tarakom", System.Data.SqlDbType.NVarChar).Value = tarakom;
                    querySaveStaff.Parameters.Add("@dastarasi", SqlDbType.NVarChar).Value = dastarasi;
                    querySaveStaff.Parameters.Add("@sakhteman", SqlDbType.NVarChar).Value = sakhteman;
                    querySaveStaff.Parameters.Add("@sanad", SqlDbType.NVarChar).Value = sanad;
                    querySaveStaff.Parameters.Add("@mosha", SqlDbType.Bit).Value = mosha;
                    querySaveStaff.Parameters.Add("@karbari", SqlDbType.NVarChar).Value = karbari;
                    querySaveStaff.Parameters.Add("@tabaghat", SqlDbType.Int).Value = tabaghat;
                    querySaveStaff.Parameters.Add("@tedadkolvahed", SqlDbType.Int).Value = tedadkolvahed;

                    querySaveStaff.Parameters.Add("@tedadvaheddartabaghe", System.Data.SqlDbType.Int).Value = tedadvaheddartabaghe;
                    querySaveStaff.Parameters.Add("@tabaghe", System.Data.SqlDbType.Int).Value = tabaghe;
                    querySaveStaff.Parameters.Add("@salsakht", SqlDbType.NVarChar).Value = salsakht;
                    querySaveStaff.Parameters.Add("@divar", SqlDbType.NVarChar).Value = divar;
                    querySaveStaff.Parameters.Add("@kaf", SqlDbType.NVarChar).Value = kaf;
                    querySaveStaff.Parameters.Add("@garmayesh", SqlDbType.NVarChar).Value = garmayesh;
                    querySaveStaff.Parameters.Add("@sarmayesh", SqlDbType.NVarChar).Value = sarmayesh;
                    querySaveStaff.Parameters.Add("@parking", SqlDbType.NVarChar).Value = parking;
                    querySaveStaff.Parameters.Add("@khab", SqlDbType.Int).Value = khab;

                    querySaveStaff.Parameters.Add("@kabin", System.Data.SqlDbType.NVarChar).Value = kabin;
                    querySaveStaff.Parameters.Add("@asamsor", System.Data.SqlDbType.NVarChar).Value = asamsor;
                    querySaveStaff.Parameters.Add("@anbari", SqlDbType.Bit).Value = anbari;
                    querySaveStaff.Parameters.Add("@balcone", SqlDbType.Bit).Value = balcone;
                    querySaveStaff.Parameters.Add("@roof", SqlDbType.Bit).Value = roof;
                    querySaveStaff.Parameters.Add("@emtiyazat", SqlDbType.Bit).Value = emtiyazat;
                    querySaveStaff.Parameters.Add("@abi", SqlDbType.Bit).Value = abi;
                    querySaveStaff.Parameters.Add("@salon", SqlDbType.Bit).Value = salon;
                    querySaveStaff.Parameters.Add("@master", SqlDbType.Bit).Value = master; 
                    querySaveStaff.Parameters.Add("@user_created_id", SqlDbType.Int).Value = user_created_id;
                    querySaveStaff.Parameters.Add("@comment", SqlDbType.NVarChar).Value = comment;
                    openCon.Open();

                   int resualt= querySaveStaff.ExecuteNonQuery();
                    if(resualt>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            }
    }
}
