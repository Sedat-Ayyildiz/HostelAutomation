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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void BtnHurriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.hurriyet.com.tr");
        }

        private void BtnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.milliyet.com.tr");
        }

        private void BtnSozcu_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sozcu.com.tr");
        }

        private void BtnHaberturk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.haberturk.com");
        }

        private void BtnFanatik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.fanatik.com.tr");
        }
    }
}
