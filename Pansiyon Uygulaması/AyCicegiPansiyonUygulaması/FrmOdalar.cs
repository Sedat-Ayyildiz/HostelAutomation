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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
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
