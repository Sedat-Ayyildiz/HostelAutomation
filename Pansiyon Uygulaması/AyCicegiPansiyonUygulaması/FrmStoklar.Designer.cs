namespace AyCicegiPansiyonUygulaması
{
    partial class FrmStoklar
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
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFaturalar = new System.Windows.Forms.Button();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIT = new System.Windows.Forms.TextBox();
            this.TxtGT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnMutfak = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 201;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 160;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(498, 249);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(494, 262);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "İçecek Tutarı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gıda Tutarı :";
            // 
            // BtnFaturalar
            // 
            this.BtnFaturalar.Location = new System.Drawing.Point(227, 192);
            this.BtnFaturalar.Name = "BtnFaturalar";
            this.BtnFaturalar.Size = new System.Drawing.Size(123, 33);
            this.BtnFaturalar.TabIndex = 21;
            this.BtnFaturalar.Text = "Kaydet";
            this.BtnFaturalar.UseVisualStyleBackColor = true;
            this.BtnFaturalar.Click += new System.EventHandler(this.BtnFaturalar_Click);
            // 
            // TxtInternet
            // 
            this.TxtInternet.Location = new System.Drawing.Point(185, 149);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(208, 27);
            this.TxtInternet.TabIndex = 20;
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(185, 87);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(208, 27);
            this.TxtSu.TabIndex = 19;
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Location = new System.Drawing.Point(185, 26);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(208, 27);
            this.TxtElektrik.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "İnternet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Su :";
            // 
            // TxtIT
            // 
            this.TxtIT.Location = new System.Drawing.Point(199, 83);
            this.TxtIT.Name = "TxtIT";
            this.TxtIT.Size = new System.Drawing.Size(208, 27);
            this.TxtIT.TabIndex = 12;
            // 
            // TxtGT
            // 
            this.TxtGT.Location = new System.Drawing.Point(199, 22);
            this.TxtGT.Name = "TxtGT";
            this.TxtGT.Size = new System.Drawing.Size(208, 27);
            this.TxtGT.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Atıştırmalıklar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Elektrik :";
            // 
            // BtnMutfak
            // 
            this.BtnMutfak.Location = new System.Drawing.Point(241, 188);
            this.BtnMutfak.Name = "BtnMutfak";
            this.BtnMutfak.Size = new System.Drawing.Size(123, 33);
            this.BtnMutfak.TabIndex = 14;
            this.BtnMutfak.Text = "Kaydet";
            this.BtnMutfak.UseVisualStyleBackColor = true;
            this.BtnMutfak.Click += new System.EventHandler(this.BtnMutfak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMutfak);
            this.groupBox2.Controls.Add(this.TxtA);
            this.groupBox2.Controls.Add(this.TxtIT);
            this.groupBox2.Controls.Add(this.TxtGT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(-2, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 236);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MUTFAK";
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(199, 145);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(208, 27);
            this.TxtA.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFaturalar);
            this.groupBox1.Controls.Add(this.TxtInternet);
            this.groupBox1.Controls.Add(this.TxtSu);
            this.groupBox1.Controls.Add(this.TxtElektrik);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(498, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 236);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FATURALAR";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 171;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 117;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-2, 249);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 262);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(991, 516);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOKLAR & FATURALAR PANELİ";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFaturalar;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIT;
        private System.Windows.Forms.TextBox TxtGT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnMutfak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
    }
}