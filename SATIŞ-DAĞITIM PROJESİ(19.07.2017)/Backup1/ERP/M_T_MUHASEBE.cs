using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ERP
{
    public partial class M_T_MUHASEBE : Form
    {
        public M_T_MUHASEBE()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ERP;Integrated Security=True");

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

        private void M_T_MUHASEBE_Load(object sender, EventArgs e)
        {

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into M_T_MUHASEBE (HESAP_TIPI,HESAP_NUMARASI,ISLEM_TARIHI,KDV,ODEME_TIPI,SECILEN_BANKA,TUTAR) values (' " + txtHesap_Tipi.Text + "','" + txtHESAP_NUMARASI.Text + "','" + txtISLEM_TARIHI+ "','" + txtKDV.Text + "','" + txtOdeme.Text + "','" + txtSecilen_Banka.Text + "','" + txtTUTAR.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from M_T_MUHASEBE", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["HESAP_TIPI"].ToString());
                ekle.SubItems.Add(oku["HESAP_NUMARASI"].ToString());
                ekle.SubItems.Add(oku["ISLEM_TARIHI"].ToString());
                ekle.SubItems.Add(oku["KDV"].ToString());
                ekle.SubItems.Add(oku["ODEME_TIPI"].ToString());
                ekle.SubItems.Add(oku["SECILEN_BANKA"].ToString());
                ekle.SubItems.Add(oku["TUTAR"].ToString());
                
                listView1.Items.Add(ekle);

            }

            baglanti.Close();


        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtHesap_Tipi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtHESAP_NUMARASI.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtISLEM_TARIHI.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtKDV.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtOdeme.Text = listView1.SelectedItems[0].SubItems[5].Text;

            txtSecilen_Banka.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtTUTAR.Text = listView1.SelectedItems[0].SubItems[7].Text;
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from M_T_MUHASEBE where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update M_T_MUHASEBE set HESAP_TIPI= '" + txtHesap_Tipi.Text + "',HESAP_NUMARASI='" + txtHESAP_NUMARASI.Text + "',ISLEM_TARIHI= '" + txtISLEM_TARIHI.Text + "',KDV='" + txtKDV.Text + "',ODEME_TIPI='" + txtOdeme.Text + "',SECILEN_BANKA='" + txtSecilen_Banka.Text + "',TUTAR='" + txtTUTAR.Text+  "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtHESAP_NUMARASI.Clear();
            txtISLEM_TARIHI.Clear();
            txtTUTAR.Clear();
            txtSecilen_Banka.Clear();
            txtHesap_Tipi.Clear();
            txtKDV.Clear();
            txtOdeme.Clear();
            
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into M_T_MUHASEBE (HESAP_TIPI,HESAP_NUMARASI,ISLEM_TARIHI,KDV,ODEME_TIPI,SECILEN_BANKA,TUTAR) values (' " + txtHesap_Tipi.Text + "','" + txtHESAP_NUMARASI.Text + "','" + txtISLEM_TARIHI + "','" + txtKDV.Text + "','" + txtOdeme.Text + "','" + txtSecilen_Banka.Text + "','" + txtTUTAR.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }

    }
}
