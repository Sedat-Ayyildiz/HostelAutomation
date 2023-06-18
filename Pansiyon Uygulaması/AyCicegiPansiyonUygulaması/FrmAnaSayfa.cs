using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyCicegiPansiyonUygulaması
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }        

        private void BtnYeniMüsteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frym = new FrmYeniMusteri();
            frym.Show();
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fro = new FrmOdalar();
            fro.Show();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.Show();
        }

        private void BtnGelirGiderFormu_Click(object sender, EventArgs e)
        {
            FrmGelirGider frmg = new FrmGelirGider();
            frmg.Show();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            FrmStoklar frs = new FrmStoklar();
            frs.Show();
        }

        private void BtnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği Pansiyon Kayıt Uygulaması / 2022 - İSTANBUL", "TELİF HAKLARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMusteriMesajlari_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.Show();
        }

        private void BtnGazeteler_Click(object sender, EventArgs e)
        {
            FrmGazeteler frg = new FrmGazeteler();
            frg.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle frs = new FrmSifreGuncelle();
            frs.Show();
        }
    }
}
