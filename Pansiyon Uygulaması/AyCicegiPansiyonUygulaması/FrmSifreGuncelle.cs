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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("update AdminGiris set KullaniciAdi='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text + "'", baglanti);            
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şifre Güncelleme İşleminiz Başarılı Bir Şekilde Gerçekleşti.\nYeni Şifrenizi Kullanabilmek için Lütfen Sistemden Çıkıp Tekrar Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
