namespace AyCicegiPansiyonUygulaması
{
    partial class FrmMusteriler
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
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.TxtTcNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnVerileriListele = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(1131, 310);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(147, 25);
            this.BtnTemizle.TabIndex = 71;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtIsim
            // 
            this.TxtIsim.BackColor = System.Drawing.SystemColors.Info;
            this.TxtIsim.Location = new System.Drawing.Point(749, 310);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(303, 25);
            this.TxtIsim.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(688, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 69;
            this.label11.Text = "İSİM :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 68;
            this.label10.Text = "Cinsiyet :";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.BackColor = System.Drawing.SystemColors.Info;
            this.CmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(162, 78);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(303, 26);
            this.CmbCinsiyet.TabIndex = 67;
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.SystemColors.Info;
            this.TxtUcret.Enabled = false;
            this.TxtUcret.Location = new System.Drawing.Point(162, 244);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(303, 25);
            this.TxtUcret.TabIndex = 66;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Çıkış Tarihi";
            this.columnHeader11.Width = 195;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giriş Tarihi";
            this.columnHeader10.Width = 182;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ücret";
            this.columnHeader9.Width = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 65;
            this.label9.Text = "Ücret :";
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(162, 310);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(303, 25);
            this.DtpCikisTarihi.TabIndex = 64;
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(162, 277);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(303, 25);
            this.DtpGirisTarihi.TabIndex = 63;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtOdaNo.Enabled = false;
            this.TxtOdaNo.Location = new System.Drawing.Point(162, 211);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(303, 25);
            this.TxtOdaNo.TabIndex = 62;
            // 
            // TxtTcNo
            // 
            this.TxtTcNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtTcNo.Location = new System.Drawing.Point(162, 178);
            this.TxtTcNo.MaxLength = 11;
            this.TxtTcNo.Name = "TxtTcNo";
            this.TxtTcNo.Size = new System.Drawing.Size(303, 25);
            this.TxtTcNo.TabIndex = 61;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMail.Location = new System.Drawing.Point(162, 145);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(303, 25);
            this.TxtMail.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Giriş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Adı :";
            // 
            // BtnAra
            // 
            this.BtnAra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Location = new System.Drawing.Point(476, 234);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(802, 67);
            this.BtnAra.TabIndex = 48;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(476, 86);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(802, 68);
            this.BtnGuncelle.TabIndex = 46;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnVerileriListele
            // 
            this.BtnVerileriListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVerileriListele.Location = new System.Drawing.Point(476, 12);
            this.BtnVerileriListele.Name = "BtnVerileriListele";
            this.BtnVerileriListele.Size = new System.Drawing.Size(802, 68);
            this.BtnVerileriListele.TabIndex = 45;
            this.BtnVerileriListele.Text = "Verileri Listele";
            this.BtnVerileriListele.UseVisualStyleBackColor = true;
            this.BtnVerileriListele.Click += new System.EventHandler(this.BtnVerileriListele_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 47;
            // 
            // MskTelefon
            // 
            this.MskTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.MskTelefon.Location = new System.Drawing.Point(162, 112);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(303, 25);
            this.MskTelefon.TabIndex = 59;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSoyadi.Location = new System.Drawing.Point(162, 45);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(303, 25);
            this.TxtSoyadi.TabIndex = 58;
            // 
            // TxtAdi
            // 
            this.TxtAdi.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAdi.Location = new System.Drawing.Point(162, 12);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(303, 25);
            this.TxtAdi.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Çıkış Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Oda Numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "T.C Kimlik No :";
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(476, 160);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(802, 68);
            this.BtnSil.TabIndex = 47;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 348);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1290, 287);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 144;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 203;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TC";
            this.columnHeader7.Width = 108;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Oda No";
            this.columnHeader8.Width = 79;
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1285, 634);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtpCikisTarihi);
            this.Controls.Add(this.DtpGirisTarihi);
            this.Controls.Add(this.TxtOdaNo);
            this.Controls.Add(this.TxtTcNo);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnVerileriListele);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.TxtSoyadi);
            this.Controls.Add(this.TxtAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ BİLGİLERİ PANELİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.TextBox TxtTcNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnVerileriListele;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}