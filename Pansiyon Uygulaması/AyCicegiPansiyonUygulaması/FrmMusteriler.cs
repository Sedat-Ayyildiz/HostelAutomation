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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void verileriGoster()//LISTVIEW KULLANARAK VERİLERİ LİSTELEDİK
        {
            baglanti.Open();
            SqlCommand komutListele = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komutListele.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);//SubItems diger sütunlar.Bu satır id kökü seçilcek sütun.
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTcNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnVerileriListele_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //ODA101
            if (TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda101", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("101 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ODA102
            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda102", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("102 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ODA103
            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda103", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("103 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ODA104
            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda104", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("104 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ODA105
            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda105", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("105 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ODA106
            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda106", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("106 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ODA107
            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda107", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("107 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ODA108
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda108", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("108 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ODA109
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komutSil = new SqlCommand("delete from Oda109", baglanti);
                komutSil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("109 No'lu Odanın Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /*verileriGoster();            
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CmbCinsiyet.Text = null;
            MskTelefon.Text = null;
            TxtMail.Clear();
            TxtTcNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";*/
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

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("update MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "'," +
            "Cinsiyet='" + CmbCinsiyet.Text + "',Telefon='" + MskTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtTcNo.Text + "',OdaNo='" + TxtOdaNo.Text + "'," +
            "Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "'," +
            "CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id + "", baglanti);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşleminiz Başarılı Bir Şekilde Gerçekleşti.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            verileriGoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komutListele = new SqlCommand("select * from MusteriEkle where Adi like '%" + TxtIsim.Text + "%'", baglanti);
            SqlDataReader oku = komutListele.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
