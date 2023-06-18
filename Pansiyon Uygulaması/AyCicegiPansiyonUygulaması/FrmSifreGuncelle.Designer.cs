namespace AyCicegiPansiyonUygulaması
{
    partial class FrmSifreGuncelle
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
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(295, 172);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(155, 39);
            this.BtnGuncelle.TabIndex = 16;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.LightYellow;
            this.TxtSifre.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(259, 119);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(229, 34);
            this.TxtSifre.TabIndex = 15;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.LightYellow;
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(259, 59);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(229, 34);
            this.TxtKullaniciAdi.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(166, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "ŞİFRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "KULLANICI ADI";
            // 
            // FrmSifreGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(599, 269);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSifreGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN ŞİFRE GÜNCELLEME PANELİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}