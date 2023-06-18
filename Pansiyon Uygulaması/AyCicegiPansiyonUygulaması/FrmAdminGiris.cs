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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void BtnGirisYap_Click_1(object sender, EventArgs e)//PARAMETRE VE TRY-CATCH ile GİRİŞ PANELİ OLUŞTURDUK !
        {
            try//İki Kere Tıklayınca Giriş Bilgileri Yanlışsa Uyarı Veriyor.Tek Tıklama da Bilgiler Doğruysa Giriyor !
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where KullaniciAdi=@KullaniciIsmi and Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciIsmi", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komutGirisYap = new SqlCommand(sql, baglanti);
                komutGirisYap.Parameters.Add(prm1);
                komutGirisYap.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komutGirisYap);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAnaSayfa fra = new FrmAnaSayfa();
                    fra.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
