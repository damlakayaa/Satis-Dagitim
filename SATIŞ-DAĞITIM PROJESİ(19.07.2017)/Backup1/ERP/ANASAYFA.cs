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
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
          
           // KULLANICI_GIRISI muko = new KULLANICI_GIRISI();
            //muko.Show();
           // this.Hide();
            
        }

        private void muToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ANASAYFA A = new ANASAYFA();
           // A.Show();
            //this.Hide();
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void satin_alma_yönetimi_Click(object sender, EventArgs e)
        {
           
        }

        private void Satis_ve_Müsteri_iliskileri_Click(object sender, EventArgs e)
        {
           
        }

        private void ürün_tasarimi_yönetimi_Click(object sender, EventArgs e)
        {
            
        }

        private void malzeme_yönetimi_Click(object sender, EventArgs e)
        {
            
        }

        private void Servis_Bakim_Yönetimi_Click(object sender, EventArgs e)
        {
            
        }

        private void Finans_Click(object sender, EventArgs e)
        {
           
        }

        private void insan_Kaynaklari_Click(object sender, EventArgs e)
        {
            
        }

        private void Dokuman_Yönetimi_Click(object sender, EventArgs e)
        { }

        private void is_sürecleri_yönetimi_Click(object sender, EventArgs e)
        {
           
        }

        private void Yazilim_Altyapisi_Click(object sender, EventArgs e)
        {
            
        }

        private void Kurumsal_Karneler_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            ANASAYFA anasayfa = new ANASAYFA();
            anasayfa.Show();
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

        private void btnERP_Click(object sender, EventArgs e)
        {
            ERP_NEDIR erp = new ERP_NEDIR();
            erp.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = txtTime.Text.Substring(1) + txtTime.Text.Substring(0, 1);

            lblSaatt.Text = DateTime.Now.ToLongTimeString();
        }

        private void mUSTERITEDARIKCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MUSTERİ_TEDARIKCI musteri_tedarikci = new MUSTERİ_TEDARIKCI();
            musteri_tedarikci.Show();
            this.Hide();

        }

        private void sATISMUSTERIILISKILERIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SATIS_VE_MUSTERI_ILISKILERI satis_musteri_iliskileri = new SATIS_VE_MUSTERI_ILISKILERI();
            satis_musteri_iliskileri.Show();
            this.Hide();
        }

        private void uRUNMALZEMEYONETIMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URUN_VE_MALZEME_YONETIMI urun_malzeme = new URUN_VE_MALZEME_YONETIMI();
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

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void uZAKBAGLANTIVERİLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UZAK_BAGLANTI_VERILERI uzak = new UZAK_BAGLANTI_VERILERI();
            uzak.Show();
            
        }

        private void btnADMIN_Click(object sender, EventArgs e)
        {
            KULLANICI_ISLEMLERI kullanici = new KULLANICI_ISLEMLERI();
            kullanici.Show();
            this.Hide();


        }
    }
}
