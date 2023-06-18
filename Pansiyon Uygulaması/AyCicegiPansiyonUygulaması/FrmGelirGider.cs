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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            //PERSONEL MAAŞI
            int personel;
            personel = Convert.ToInt16(TxtPersonelSayisi.Text);
            LblPm.Text = (personel * 5500).ToString();

            //KASA GENEL TOPLAM
            int sonuc;
            sonuc = Convert.ToInt32(LblKtp.Text) - (Convert.ToInt32(LblPm.Text) + Convert.ToInt32(LblGT.Text) + Convert.ToInt32(LblIT.Text) + Convert.ToInt32(LblAT.Text) + Convert.ToInt32(LblE.Text) + Convert.ToInt32(LblS.Text) + Convert.ToInt32(LblI.Text));
            LblSonuc.Text = sonuc.ToString() + " TL";
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //KASADAKİ TOPLAM TUTAR
            baglanti.Open();
            SqlCommand komutHesapla = new SqlCommand("select sum(Ucret) as 'TOPLAM' from MusteriEkle", baglanti);
            SqlDataReader oku = komutHesapla.ExecuteReader();
            while (oku.Read())
            {
                LblKtp.Text = oku["TOPLAM"].ToString();
            }
            baglanti.Close();

            //GIDA GİDERLERİ
            baglanti.Open();
            SqlCommand komutHesapla2 = new SqlCommand("select sum(Gida) as 'TOPLAM1' from Stoklar", baglanti);
            SqlDataReader oku2 = komutHesapla2.ExecuteReader();
            while (oku2.Read())
            {
                LblGT.Text = oku2["TOPLAM1"].ToString();
            }
            baglanti.Close();

            //İÇECEK GİDERLERİ
            baglanti.Open();
            SqlCommand komutHesapla3 = new SqlCommand("select sum(Icecek) as 'TOPLAM2' from Stoklar", baglanti);
            SqlDataReader oku3 = komutHesapla3.ExecuteReader();
            while (oku3.Read())
            {
                LblIT.Text = oku3["TOPLAM2"].ToString();
            }
            baglanti.Close();

            //ÇEREZ GİDERLERİ
            baglanti.Open();
            SqlCommand komutHesapla4 = new SqlCommand("select sum(Cerezler) as 'TOPLAM3' from Stoklar", baglanti);
            SqlDataReader oku4 = komutHesapla4.ExecuteReader();
            while (oku4.Read())
            {
                LblAT.Text = oku4["TOPLAM3"].ToString();
            }
            baglanti.Close();

            //ELEKTRİK FATURASI
            baglanti.Open();
            SqlCommand komutHesapla5 = new SqlCommand("select sum(Elektrik) as 'TOPLAM4' from Faturalar", baglanti);
            SqlDataReader oku5 = komutHesapla5.ExecuteReader();
            while (oku5.Read())
            {
                LblE.Text = oku5["TOPLAM4"].ToString();
            }
            baglanti.Close();

            //SU FATURASI
            baglanti.Open();
            SqlCommand komutHesapla6 = new SqlCommand("select sum(Su) as 'TOPLAM5' from Faturalar", baglanti);
            SqlDataReader oku6 = komutHesapla6.ExecuteReader();
            while (oku6.Read())
            {
                LblS.Text = oku6["TOPLAM5"].ToString();
            }
            baglanti.Close();

            //İNTERNET FATURASI
            baglanti.Open();
            SqlCommand komutHesapla7 = new SqlCommand("select sum(Internet) as 'TOPLAM6' from Faturalar", baglanti);
            SqlDataReader oku7 = komutHesapla7.ExecuteReader();
            while (oku7.Read())
            {
                LblI.Text = oku7["TOPLAM6"].ToString();
            }
            baglanti.Close();
        }
    }
}
