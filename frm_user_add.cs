using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abadgaran
{
    public partial class frm_user_add : Form
    {
        public frm_user_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_db_helper.db_user_add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, DateTime.Now, DateTime.Now, 0, 2, "");
        }
    }
}
