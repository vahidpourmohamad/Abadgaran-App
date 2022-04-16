namespace Abadgaran
{
    partial class frm_ejare_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ejare_view));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_mahale = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cmb_mantaghe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.rdi_pezeshk = new System.Windows.Forms.RadioButton();
            this.rdi_fullapartment = new System.Windows.Forms.RadioButton();
            this.rdi_store = new System.Windows.Forms.RadioButton();
            this.rdi_bagh = new System.Windows.Forms.RadioButton();
            this.rdi_apartment = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.chk_mojarad = new System.Windows.Forms.CheckBox();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_minarea = new System.Windows.Forms.TextBox();
            this.txt_maxarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rahn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_mahale);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.cmb_mantaghe);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.rdi_pezeshk);
            this.groupBox1.Controls.Add(this.rdi_fullapartment);
            this.groupBox1.Controls.Add(this.rdi_store);
            this.groupBox1.Controls.Add(this.rdi_bagh);
            this.groupBox1.Controls.Add(this.rdi_apartment);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chk_mojarad);
            this.groupBox1.Controls.Add(this.txt_rent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_minarea);
            this.groupBox1.Controls.Add(this.txt_maxarea);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_rahn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(951, 172);
            this.groupBox1.TabIndex = 8;
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
            this.cmb_mahale.Location = new System.Drawing.Point(386, 116);
            this.cmb_mahale.Name = "cmb_mahale";
            this.cmb_mahale.Size = new System.Drawing.Size(194, 35);
            this.cmb_mahale.TabIndex = 54;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(609, 121);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 27);
            this.label34.TabIndex = 53;
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
            this.cmb_mantaghe.Location = new System.Drawing.Point(683, 116);
            this.cmb_mantaghe.Name = "cmb_mantaghe";
            this.cmb_mantaghe.Size = new System.Drawing.Size(165, 35);
            this.cmb_mantaghe.TabIndex = 51;
            this.cmb_mantaghe.SelectedIndexChanged += new System.EventHandler(this.cmb_mantaghe_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(888, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 27);
            this.label9.TabIndex = 50;
            this.label9.Text = "منطقه ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSans", 8F);
            this.label7.Location = new System.Drawing.Point(760, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "متر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSans", 8F);
            this.label6.Location = new System.Drawing.Point(760, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "متر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans", 8F);
            this.label5.Location = new System.Drawing.Point(489, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "تومان";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("IRANSans", 8F);
            this.label37.Location = new System.Drawing.Point(489, 43);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(33, 19);
            this.label37.TabIndex = 46;
            this.label37.Text = "تومان";
            // 
            // rdi_pezeshk
            // 
            this.rdi_pezeshk.AutoSize = true;
            this.rdi_pezeshk.Location = new System.Drawing.Point(206, 37);
            this.rdi_pezeshk.Name = "rdi_pezeshk";
            this.rdi_pezeshk.Size = new System.Drawing.Size(117, 31);
            this.rdi_pezeshk.TabIndex = 45;
            this.rdi_pezeshk.TabStop = true;
            this.rdi_pezeshk.Text = "آپارتمان اداری";
            this.rdi_pezeshk.UseVisualStyleBackColor = true;
            // 
            // rdi_fullapartment
            // 
            this.rdi_fullapartment.AutoSize = true;
            this.rdi_fullapartment.Location = new System.Drawing.Point(337, 37);
            this.rdi_fullapartment.Name = "rdi_fullapartment";
            this.rdi_fullapartment.Size = new System.Drawing.Size(132, 31);
            this.rdi_fullapartment.TabIndex = 44;
            this.rdi_fullapartment.TabStop = true;
            this.rdi_fullapartment.Text = "مجتمع آپارتمانی";
            this.rdi_fullapartment.UseVisualStyleBackColor = true;
            // 
            // rdi_store
            // 
            this.rdi_store.AutoSize = true;
            this.rdi_store.Location = new System.Drawing.Point(407, 77);
            this.rdi_store.Name = "rdi_store";
            this.rdi_store.Size = new System.Drawing.Size(62, 31);
            this.rdi_store.TabIndex = 43;
            this.rdi_store.TabStop = true;
            this.rdi_store.Text = "مغازه";
            this.rdi_store.UseVisualStyleBackColor = true;
            // 
            // rdi_bagh
            // 
            this.rdi_bagh.AutoSize = true;
            this.rdi_bagh.Location = new System.Drawing.Point(246, 75);
            this.rdi_bagh.Name = "rdi_bagh";
            this.rdi_bagh.Size = new System.Drawing.Size(77, 31);
            this.rdi_bagh.TabIndex = 40;
            this.rdi_bagh.TabStop = true;
            this.rdi_bagh.Text = "باغ ویلا";
            this.rdi_bagh.UseVisualStyleBackColor = true;
            // 
            // rdi_apartment
            // 
            this.rdi_apartment.AutoSize = true;
            this.rdi_apartment.Location = new System.Drawing.Point(113, 77);
            this.rdi_apartment.Name = "rdi_apartment";
            this.rdi_apartment.Size = new System.Drawing.Size(79, 31);
            this.rdi_apartment.TabIndex = 38;
            this.rdi_apartment.TabStop = true;
            this.rdi_apartment.Text = "آپارتمان";
            this.rdi_apartment.UseVisualStyleBackColor = true;
            this.rdi_apartment.CheckedChanged += new System.EventHandler(this.rdi_apartment_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "فیلتر";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_mojarad
            // 
            this.chk_mojarad.AutoSize = true;
            this.chk_mojarad.Location = new System.Drawing.Point(79, 37);
            this.chk_mojarad.Name = "chk_mojarad";
            this.chk_mojarad.Size = new System.Drawing.Size(113, 31);
            this.chk_mojarad.TabIndex = 18;
            this.chk_mojarad.Text = "مناسب مجرد";
            this.chk_mojarad.UseVisualStyleBackColor = true;
            // 
            // txt_rent
            // 
            this.txt_rent.Location = new System.Drawing.Point(529, 75);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_rent.Size = new System.Drawing.Size(120, 35);
            this.txt_rent.TabIndex = 16;
            this.txt_rent.TextChanged += new System.EventHandler(this.txt_rent_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "حداکثر اجاره";
            // 
            // txt_minarea
            // 
            this.txt_minarea.Location = new System.Drawing.Point(790, 39);
            this.txt_minarea.Name = "txt_minarea";
            this.txt_minarea.Size = new System.Drawing.Size(58, 35);
            this.txt_minarea.TabIndex = 10;
            // 
            // txt_maxarea
            // 
            this.txt_maxarea.Location = new System.Drawing.Point(790, 77);
            this.txt_maxarea.Name = "txt_maxarea";
            this.txt_maxarea.Size = new System.Drawing.Size(58, 35);
            this.txt_maxarea.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "حداکثر ودیعه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "حداقل متراژ";
            // 
            // txt_rahn
            // 
            this.txt_rahn.Location = new System.Drawing.Point(529, 35);
            this.txt_rahn.Name = "txt_rahn";
            this.txt_rahn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_rahn.Size = new System.Drawing.Size(120, 35);
            this.txt_rahn.TabIndex = 14;
            this.txt_rahn.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "حداکثر متراژ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(951, 319);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // detail
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.detail.DefaultCellStyle = dataGridViewCellStyle1;
            this.detail.HeaderText = "نمایش جزییات";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Text = "جزئیات";
            this.detail.Width = 113;
            // 
            // frm_ejare_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_ejare_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اجاره";
            this.Load += new System.EventHandler(this.frm_ejare_view_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_mojarad;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_minarea;
        private System.Windows.Forms.TextBox txt_maxarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rahn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdi_pezeshk;
        private System.Windows.Forms.RadioButton rdi_fullapartment;
        private System.Windows.Forms.RadioButton rdi_store;
        private System.Windows.Forms.RadioButton rdi_bagh;
        private System.Windows.Forms.RadioButton rdi_apartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cmb_mahale;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cmb_mantaghe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
    }
}