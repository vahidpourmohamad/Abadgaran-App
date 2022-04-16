namespace Abadgaran
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgw_gold = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.outline_label2 = new Abadgaran.outline_label();
            this.lbl_version = new Abadgaran.outline_label();
            this.lbl_date = new Abadgaran.outline_label();
            this.lbl_name = new Abadgaran.outline_label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_gold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "معاملات املاک فروشی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 572);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = " املاک اجاره ای";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(830, 573);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 67);
            this.button3.TabIndex = 4;
            this.button3.Text = "ثبت ملک";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 460);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(962, 103);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // dgw_gold
            // 
            this.dgw_gold.AllowUserToAddRows = false;
            this.dgw_gold.AllowUserToDeleteRows = false;
            this.dgw_gold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_gold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail});
            this.dgw_gold.Location = new System.Drawing.Point(144, 199);
            this.dgw_gold.Name = "dgw_gold";
            this.dgw_gold.ReadOnly = true;
            this.dgw_gold.Size = new System.Drawing.Size(280, 180);
            this.dgw_gold.TabIndex = 8;
            this.dgw_gold.Visible = false;
            this.dgw_gold.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // detail
            // 
            this.detail.HeaderText = "جزییات";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(182, 573);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 67);
            this.button4.TabIndex = 9;
            this.button4.Text = "اتاق املاک درخواستی";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(20, 573);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 68);
            this.button5.TabIndex = 10;
            this.button5.Text = "پیش فروش";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(344, 572);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 68);
            this.button6.TabIndex = 20;
            this.button6.Text = "املاک من";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 140);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(468, 140);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(514, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(468, 140);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(514, 286);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(468, 140);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(20, 73);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 40);
            this.button7.TabIndex = 29;
            this.button7.Text = "خروج";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // outline_label2
            // 
            this.outline_label2.AutoSize = true;
            this.outline_label2.BackColor = System.Drawing.Color.Transparent;
            this.outline_label2.ForeColor = System.Drawing.Color.White;
            this.outline_label2.Location = new System.Drawing.Point(881, 430);
            this.outline_label2.Name = "outline_label2";
            this.outline_label2.OutlineForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outline_label2.OutlineWidth = 2F;
            this.outline_label2.Size = new System.Drawing.Size(93, 27);
            this.outline_label2.TabIndex = 28;
            this.outline_label2.Text = "پیغام سیستم";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_version.ForeColor = System.Drawing.Color.White;
            this.lbl_version.Location = new System.Drawing.Point(320, 645);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.OutlineForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_version.OutlineWidth = 2F;
            this.lbl_version.Size = new System.Drawing.Size(104, 27);
            this.lbl_version.TabIndex = 27;
            this.lbl_version.Text = "وحید پورمحمد";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("IRANSans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(113, 96);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.OutlineForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_date.OutlineWidth = 2F;
            this.lbl_date.Size = new System.Drawing.Size(135, 36);
            this.lbl_date.TabIndex = 26;
            this.lbl_date.Text = "وحید پورمحمد";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("IRANSans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(113, 60);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.OutlineForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.OutlineWidth = 2F;
            this.lbl_name.Size = new System.Drawing.Size(135, 36);
            this.lbl_name.TabIndex = 25;
            this.lbl_name.Text = "وحید پورمحمد";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 681);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.outline_label2);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgw_gold);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_main";
            this.RightToLeftLayout = true;
            this.Text = "سیستم هوشمند املاکی نو";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_gold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgw_gold;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private outline_label lbl_name;
        private outline_label lbl_date;
        private outline_label lbl_version;
        private outline_label outline_label2;
        private System.Windows.Forms.Button button7;
    }
}