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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void Veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komutListele = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komutListele.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString() + " TL";
                ekle.SubItems.Add(oku["Icecek"].ToString() + " TL");
                ekle.SubItems.Add(oku["Cerezler"].ToString() + " TL");
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void Veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komutListele2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = komutListele2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = oku2["Elektrik"].ToString() + " TL";
                ekle2.SubItems.Add(oku2["Su"].ToString() + " TL");
                ekle2.SubItems.Add(oku2["Internet"].ToString() + " TL");
                listView2.Items.Add(ekle2);
            }
            baglanti.Close();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            Veriler();
            Veriler2();
        }

        private void BtnMutfak_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into Stoklar(Gida,Icecek,Cerezler) values('" + TxtGT.Text + "','" + TxtIT.Text + "','" + TxtA.Text + "')", baglanti);
            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            Veriler();
            MessageBox.Show("Mutfak Tutarları Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnFaturalar_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet2 = new SqlCommand("insert into Faturalar(Elektrik,Su,Internet) values('" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + TxtInternet.Text + "')", baglanti);
            komutKaydet2.ExecuteNonQuery();
            baglanti.Close();
            Veriler2();
            MessageBox.Show("Fatura Tutarları Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
