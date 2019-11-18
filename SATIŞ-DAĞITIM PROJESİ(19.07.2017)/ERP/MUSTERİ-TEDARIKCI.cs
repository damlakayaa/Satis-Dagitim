using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class MUSTERİ_TEDARIKCI : Form
    {
        public MUSTERİ_TEDARIKCI()
        {
            InitializeComponent();
        }

        private void sATISMUSTERIILISKILERIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SATIS_VE_MUSTERI_ILISKILERI satis_musteri_iliskileri = new SATIS_VE_MUSTERI_ILISKILERI();
            satis_musteri_iliskileri.Show();
            this.Hide();
        }

        private void uRUNMALZEMEYONETIMIToolStripMenuItem_Click(object sender, EventArgs e)
        {

            URUNVEMALZEMEYONETIMI urun_malzeme = new URUNVEMALZEMEYONETIMI();
            urun_malzeme.Show();
            this.Hide();
        }

        private void sATISSERVISYONETIMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SATIS_VE_SERVIS_YONETIMI satis_servis = new SATIS_VE_SERVIS_YONETIMI();
            satis_servis.Show();
            this.Hide();
        }

        private void dAGITIMLOGISTIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAGITIM_VE_LOGISTIK dagitim = new DAGITIM_VE_LOGISTIK();
            dagitim.Show();
            this.Hide();
        }

        private void rAPORLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAPORLAR raporlar = new RAPORLAR();
            raporlar.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?", "Çıkış Ekranı !!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //don't do anything
            }
        }

        private void gENELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M_T_GENEL genel = new M_T_GENEL();
            genel.Show();
            this.Hide();
        }

        private void ıLISKILERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M_T_ILISKILER iliskiler = new M_T_ILISKILER();
            iliskiler.Show();
            this.Hide();

        }

        private void mUHASEBEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M_T_MUHASEBE muhasebe = new M_T_MUHASEBE();
            muhasebe.Show();
            this.Hide();

        }

        private void bANKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M_T_BANKA banka = new M_T_BANKA();
            banka.Show();
            this.Hide();
        }

        private void aDRESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M_T_ADRES adres = new M_T_ADRES();
            adres.Show();
            this.Hide();
        }

        private void nOTLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M_T_NOTLAR notlar = new M_T_NOTLAR();
            notlar.Show();
            this.Hide();
        }

        private void btnGenel_Click(object sender, EventArgs e)
        {
            M_T_GENEL genel = new M_T_GENEL();
            genel.Show();
            this.Hide();
        }

        private void btnILISKILER_Click(object sender, EventArgs e)
        {
            M_T_ILISKILER iliskiler = new M_T_ILISKILER();
            iliskiler.Show();
            this.Hide();
        }

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            M_T_MUHASEBE muhasebe = new M_T_MUHASEBE();
            muhasebe.Show();
            this.Hide();
        }

        private void btnBanka_Click(object sender, EventArgs e)
        {
            M_T_BANKA banka = new M_T_BANKA();
            banka.Show();
            this.Hide();
        }

        private void btnAdres_Click(object sender, EventArgs e)
        {
            M_T_ADRES adres = new M_T_ADRES();
            adres.Show();
            this.Hide();
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            M_T_NOTLAR notlar = new M_T_NOTLAR();
            notlar.Show();
            this.Hide();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            ANASAYFA anasayfa = new ANASAYFA();
            anasayfa.Show();
            this.Hide();
        }
    }
}
