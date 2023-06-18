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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void verileriGoster()//LISTVIEW KULLANARAK VERİLERİ LİSTELEDİK
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komutListele = new SqlCommand("select * from Mesajlar", baglanti);
            SqlDataReader oku = komutListele.ExecuteReader();            
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj) values('"+TxtAdSoyad.Text+"','"+RchMesaj.Text+"')",baglanti);
            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            RchMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
