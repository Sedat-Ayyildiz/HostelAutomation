using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AyCicegiPansiyonUygulaması
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + CmbCinsiyet.Text + "','" + MskTelefon.Text + "','" + TxtMail.Text + "','" + TxtTcNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müsteri Kaydı Başarılı Bir Şekilde Yapıldı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CmbCinsiyet.Text = null;
            MskTelefon.Text = null;
            TxtMail.Clear();
            TxtTcNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut101 = new SqlCommand("insert into Oda101(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut101.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("101 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut102 = new SqlCommand("insert into Oda102(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut102.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("102 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut103 = new SqlCommand("insert into Oda103(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut103.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("103 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut104 = new SqlCommand("insert into Oda104(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut104.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("104 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut105 = new SqlCommand("insert into Oda105(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut105.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("105 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut106 = new SqlCommand("insert into Oda106(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut106.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("106 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut107 = new SqlCommand("insert into Oda107(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut107.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("107 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut108 = new SqlCommand("insert into Oda108(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut108.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("108 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut109 = new SqlCommand("insert into Oda109(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut109.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("109 Numaralı Oda Kaydı Odalar Paneline Eklenmiştir.\nŞimdi Kayıt Edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;//TimeSpan Tarihler Arası Farkı Hesaplar.
            label11.Text = sonuc.TotalDays.ToString();//Toplam Günü Label'a Aktardık ve Hesapladık.
            ucret = Convert.ToInt32(label11.Text) * 25;//Tarihi int'e Çevirip Gunlük Fiyat ile Çarptık.
            TxtUcret.Text = ucret.ToString();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            //ODA101
            baglanti.Open();
            SqlCommand komut101 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut101.ExecuteReader();
            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.ForeColor = Color.White;
                BtnOda101.Enabled = false;
            }

            //ODA102
            baglanti.Open();
            SqlCommand komut102 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut102.ExecuteReader();
            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.ForeColor = Color.White;
                BtnOda102.Enabled = false;
            }

            //ODA103
            baglanti.Open();
            SqlCommand komut103 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut103.ExecuteReader();
            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.ForeColor = Color.White;
                BtnOda103.Enabled = false;
            }

            //ODA104
            baglanti.Open();
            SqlCommand komut104 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut104.ExecuteReader();
            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.ForeColor = Color.White;
                BtnOda104.Enabled = false;
            }

            //ODA105
            baglanti.Open();
            SqlCommand komut105 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut105.ExecuteReader();
            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.ForeColor = Color.White;
                BtnOda105.Enabled = false;
            }

            //ODA106
            baglanti.Open();
            SqlCommand komut106 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut106.ExecuteReader();
            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.ForeColor = Color.White;
                BtnOda106.Enabled = false;
            }

            //ODA107
            baglanti.Open();
            SqlCommand komut107 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut107.ExecuteReader();
            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.ForeColor = Color.White;
                BtnOda107.Enabled = false;
            }

            //ODA108
            baglanti.Open();
            SqlCommand komut108 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut108.ExecuteReader();
            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.ForeColor = Color.White;
                BtnOda108.Enabled = false;
            }

            //ODA109
            baglanti.Open();
            SqlCommand komut109 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut109.ExecuteReader();
            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.ForeColor = Color.White;
                BtnOda109.Enabled = false;
            }
        }
    }
}
