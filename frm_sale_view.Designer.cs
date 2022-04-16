namespace Abadgaran
{
    partial class frm_sale_view
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sale_view));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.توافقی = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_mahale = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cmb_mantaghe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.rdi_hotel = new System.Windows.Forms.RadioButton();
            this.rdi_sole = new System.Windows.Forms.RadioButton();
            this.rdi_pezeshk = new System.Windows.Forms.RadioButton();
            this.rdi_fullapartment = new System.Windows.Forms.RadioButton();
            this.rdi_store = new System.Windows.Forms.RadioButton();
            this.rdi_farm = new System.Windows.Forms.RadioButton();
            this.rdi_bagh = new System.Windows.Forms.RadioButton();
            this.rdi_kolangi = new System.Windows.Forms.RadioButton();
            this.rdi_apartment = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.chk_moaveze = new System.Windows.Forms.CheckBox();
            this.txt_salesakht = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_minarea = new System.Windows.Forms.TextBox();
            this.txt_maxarea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maxprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail,
            this.توافقی});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(960, 293);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // detail
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.detail.DefaultCellStyle = dataGridViewCellStyle1;
            this.detail.HeaderText = "جزئیات ملک";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Text = "کلیک کنید";
            this.detail.Width = 97;
            // 
            // توافقی
            // 
            this.توافقی.HeaderText = "قیمت توافقی";
            this.توافقی.Name = "توافقی";
            this.توافقی.ReadOnly = true;
            this.توافقی.Width = 103;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_mahale);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.cmb_mantaghe);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.rdi_hotel);
            this.groupBox1.Controls.Add(this.rdi_sole);
            this.groupBox1.Controls.Add(this.rdi_pezeshk);
            this.groupBox1.Controls.Add(this.rdi_fullapartment);
            this.groupBox1.Controls.Add(this.rdi_store);
            this.groupBox1.Controls.Add(this.rdi_farm);
            this.groupBox1.Controls.Add(this.rdi_bagh);
            this.groupBox1.Controls.Add(this.rdi_kolangi);
            this.groupBox1.Controls.Add(this.rdi_apartment);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.chk_moaveze);
            this.groupBox1.Controls.Add(this.txt_salesakht);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_minarea);
            this.groupBox1.Controls.Add(this.txt_maxarea);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_maxprice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(960, 167);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_mahale
            // 
            this.cmb_mahale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_mahale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_mahale.Enabled = false;
            this.cmb_mahale.FormattingEnabled = true;
            this.cmb_mahale.Items.AddRange(new object[] {
            "اعلام نشده"});
            this.cmb_mahale.Location = new System.Drawing.Point(310, 111);
            this.cmb_mahale.Name = "cmb_mahale";
            this.cmb_mahale.Size = new System.Drawing.Size(274, 35);
            this.cmb_mahale.TabIndex = 59;
            this.cmb_mahale.SelectedIndexChanged += new System.EventHandler(this.cmb_mahale_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(596, 114);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 27);
            this.label34.TabIndex = 58;
            this.label34.Text = "محله";
            // 
            // cmb_mantaghe
            // 
            this.cmb_mantaghe.FormattingEnabled = true;
            this.cmb_mantaghe.Items.AddRange(new object[] {
            "مشهد",
            "شاندیز",
            "طرقبه",
            "گلبهار",
            "خارج از محدوده شهری"});
            this.cmb_mantaghe.Location = new System.Drawing.Point(659, 111);
            this.cmb_mantaghe.Name = "cmb_mantaghe";
            this.cmb_mantaghe.Size = new System.Drawing.Size(193, 35);
            this.cmb_mantaghe.TabIndex = 57;
            this.cmb_mantaghe.SelectedIndexChanged += new System.EventHandler(this.cmb_mantaghe_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(892, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 27);
            this.label9.TabIndex = 56;
            this.label9.Text = "منطقه ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 8F);
            this.label2.Location = new System.Drawing.Point(760, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "متر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 8F);
            this.label1.Location = new System.Drawing.Point(580, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "متر";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("IRANSans", 8F);
            this.label37.Location = new System.Drawing.Point(296, 41);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(33, 19);
            this.label37.TabIndex = 47;
            this.label37.Text = "تومان";
            // 
            // rdi_hotel
            // 
            this.rdi_hotel.AutoSize = true;
            this.rdi_hotel.Location = new System.Drawing.Point(515, 74);
            this.rdi_hotel.Name = "rdi_hotel";
            this.rdi_hotel.Size = new System.Drawing.Size(61, 31);
            this.rdi_hotel.TabIndex = 37;
            this.rdi_hotel.TabStop = true;
            this.rdi_hotel.Text = "هتل ";
            this.rdi_hotel.UseVisualStyleBackColor = true;
            // 
            // rdi_sole
            // 
            this.rdi_sole.AutoSize = true;
            this.rdi_sole.Location = new System.Drawing.Point(296, 74);
            this.rdi_sole.Name = "rdi_sole";
            this.rdi_sole.Size = new System.Drawing.Size(60, 31);
            this.rdi_sole.TabIndex = 36;
            this.rdi_sole.TabStop = true;
            this.rdi_sole.Text = "سوله";
            this.rdi_sole.UseVisualStyleBackColor = true;
            // 
            // rdi_pezeshk
            // 
            this.rdi_pezeshk.AutoSize = true;
            this.rdi_pezeshk.Location = new System.Drawing.Point(596, 74);
            this.rdi_pezeshk.Name = "rdi_pezeshk";
            this.rdi_pezeshk.Size = new System.Drawing.Size(117, 31);
            this.rdi_pezeshk.TabIndex = 35;
            this.rdi_pezeshk.TabStop = true;
            this.rdi_pezeshk.Text = "آپارتمان اداری";
            this.rdi_pezeshk.UseVisualStyleBackColor = true;
            // 
            // rdi_fullapartment
            // 
            this.rdi_fullapartment.AutoSize = true;
            this.rdi_fullapartment.Location = new System.Drawing.Point(815, 74);
            this.rdi_fullapartment.Name = "rdi_fullapartment";
            this.rdi_fullapartment.Size = new System.Drawing.Size(132, 31);
            this.rdi_fullapartment.TabIndex = 34;
            this.rdi_fullapartment.TabStop = true;
            this.rdi_fullapartment.Text = "مجتمع آپارتمانی";
            this.rdi_fullapartment.UseVisualStyleBackColor = true;
            // 
            // rdi_store
            // 
            this.rdi_store.AutoSize = true;
            this.rdi_store.Location = new System.Drawing.Point(733, 74);
            this.rdi_store.Name = "rdi_store";
            this.rdi_store.Size = new System.Drawing.Size(70, 31);
            this.rdi_store.TabIndex = 33;
            this.rdi_store.TabStop = true;
            this.rdi_store.Text = "تجاری";
            this.rdi_store.UseVisualStyleBackColor = true;
            // 
            // rdi_farm
            // 
            this.rdi_farm.AutoSize = true;
            this.rdi_farm.Location = new System.Drawing.Point(376, 74);
            this.rdi_farm.Name = "rdi_farm";
            this.rdi_farm.Size = new System.Drawing.Size(119, 31);
            this.rdi_farm.TabIndex = 32;
            this.rdi_farm.TabStop = true;
            this.rdi_farm.Text = "زمین کشاورزی";
            this.rdi_farm.UseVisualStyleBackColor = true;
            // 
            // rdi_bagh
            // 
            this.rdi_bagh.AutoSize = true;
            this.rdi_bagh.Location = new System.Drawing.Point(199, 74);
            this.rdi_bagh.Name = "rdi_bagh";
            this.rdi_bagh.Size = new System.Drawing.Size(77, 31);
            this.rdi_bagh.TabIndex = 31;
            this.rdi_bagh.TabStop = true;
            this.rdi_bagh.Text = "باغ ویلا";
            this.rdi_bagh.UseVisualStyleBackColor = true;
            // 
            // rdi_kolangi
            // 
            this.rdi_kolangi.AutoSize = true;
            this.rdi_kolangi.Location = new System.Drawing.Point(112, 74);
            this.rdi_kolangi.Name = "rdi_kolangi";
            this.rdi_kolangi.Size = new System.Drawing.Size(67, 31);
            this.rdi_kolangi.TabIndex = 30;
            this.rdi_kolangi.TabStop = true;
            this.rdi_kolangi.Text = "کلنگی";
            this.rdi_kolangi.UseVisualStyleBackColor = true;
            // 
            // rdi_apartment
            // 
            this.rdi_apartment.AutoSize = true;
            this.rdi_apartment.Location = new System.Drawing.Point(13, 74);
            this.rdi_apartment.Name = "rdi_apartment";
            this.rdi_apartment.Size = new System.Drawing.Size(79, 31);
            this.rdi_apartment.TabIndex = 29;
            this.rdi_apartment.TabStop = true;
            this.rdi_apartment.Text = "آپارتمان";
            this.rdi_apartment.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 41);
            this.button2.TabIndex = 28;
            this.button2.Text = "فیلتر";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chk_moaveze
            // 
            this.chk_moaveze.AutoSize = true;
            this.chk_moaveze.Location = new System.Drawing.Point(13, 37);
            this.chk_moaveze.Name = "chk_moaveze";
            this.chk_moaveze.Size = new System.Drawing.Size(79, 31);
            this.chk_moaveze.TabIndex = 27;
            this.chk_moaveze.Text = "معاوضه";
            this.chk_moaveze.UseVisualStyleBackColor = true;
            // 
            // txt_salesakht
            // 
            this.txt_salesakht.Location = new System.Drawing.Point(95, 34);
            this.txt_salesakht.Name = "txt_salesakht";
            this.txt_salesakht.Size = new System.Drawing.Size(64, 35);
            this.txt_salesakht.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "حداکثر سن بنا";
            // 
            // txt_minarea
            // 
            this.txt_minarea.Location = new System.Drawing.Point(786, 34);
            this.txt_minarea.Name = "txt_minarea";
            this.txt_minarea.Size = new System.Drawing.Size(58, 35);
            this.txt_minarea.TabIndex = 19;
            // 
            // txt_maxarea
            // 
            this.txt_maxarea.Location = new System.Drawing.Point(606, 33);
            this.txt_maxarea.Name = "txt_maxarea";
            this.txt_maxarea.Size = new System.Drawing.Size(58, 35);
            this.txt_maxarea.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "حداکثر قیمت";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(847, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "حداقل متراژ";
            // 
            // txt_maxprice
            // 
            this.txt_maxprice.Location = new System.Drawing.Point(332, 34);
            this.txt_maxprice.Name = "txt_maxprice";
            this.txt_maxprice.Size = new System.Drawing.Size(145, 35);
            this.txt_maxprice.TabIndex = 23;
            this.txt_maxprice.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 27);
            this.label8.TabIndex = 22;
            this.label8.Text = "حداکثر متراژ";
            // 
            // frm_sale_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_sale_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جهت فروش";
            this.Load += new System.EventHandler(this.frm_sale_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chk_moaveze;
        private System.Windows.Forms.TextBox txt_salesakht;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_minarea;
        private System.Windows.Forms.TextBox txt_maxarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maxprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdi_hotel;
        private System.Windows.Forms.RadioButton rdi_sole;
        private System.Windows.Forms.RadioButton rdi_pezeshk;
        private System.Windows.Forms.RadioButton rdi_fullapartment;
        private System.Windows.Forms.RadioButton rdi_store;
        private System.Windows.Forms.RadioButton rdi_farm;
        private System.Windows.Forms.RadioButton rdi_bagh;
        private System.Windows.Forms.RadioButton rdi_kolangi;
        private System.Windows.Forms.RadioButton rdi_apartment;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_mahale;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cmb_mantaghe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn توافقی;
    }
}