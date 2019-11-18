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
    public partial class SATIS_VE_SERVIS_YONETIMI : Form
    {
        public SATIS_VE_SERVIS_YONETIMI()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ERP;Integrated Security=True");

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

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            ANASAYFA anasayfa = new ANASAYFA();
            anasayfa.Show();
            this.Hide();
        }

        private void SATIS_VE_SERVIS_YONETIMI_Load(object sender, EventArgs e)
        {

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into SATIS_SERVIS_YONETIMII (SERVIS_NUMARASI,MUSTERI_NO,MUSTERI_AD,SERVISTEKI_URUN,SURESI,ILGILI_PERSONEL,ACIKLAMA) values (' " + txtSERVIS_NUMARASI.Text + "','" +txtMUSTERI_NO.Text + "','" + txtMUSTERI_AD.Text + "','" + txtSERVISTEKI_URUN.Text + "','" + txtSURESI.Text + "','" + txtILGILI_PERSONEL.Text + "','" + txtACIKLAMA.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SATIS_SERVIS_YONETIMII", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["SERVIS_NUMARASI"].ToString());
                ekle.SubItems.Add(oku["MUSTERI_NO"].ToString());
                ekle.SubItems.Add(oku["MUSTERI_AD"].ToString());
                ekle.SubItems.Add(oku["SERVISTEKI_URUN"].ToString());
                ekle.SubItems.Add(oku["SURESI"].ToString());
                ekle.SubItems.Add(oku["ILGILI_PERSONEL"].ToString());
                ekle.SubItems.Add(oku["ACIKLAMA"].ToString());
               
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
            txtSERVIS_NUMARASI.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtMUSTERI_NO.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtMUSTERI_AD.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtSERVISTEKI_URUN.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtSURESI.Text = listView1.SelectedItems[0].SubItems[5].Text;

            txtILGILI_PERSONEL.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtACIKLAMA.Text = listView1.SelectedItems[0].SubItems[7].Text;
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from SATIS_SERVIS_YONETIMII where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update SATIS_SERVIS_YONETIMII set SERVIS_NUMARASI= '" + txtSERVIS_NUMARASI.Text + "',MUSTERI_NO='" + txtMUSTERI_NO.Text + "',MUSTERI_AD= '" + txtMUSTERI_AD.Text + "',SERVISTEKI_URUN='" + txtSERVISTEKI_URUN.Text + "',SURESI='" + txtSURESI.Text + "',ILGILI_PERSONEL='" + txtILGILI_PERSONEL.Text + "',ACIKLAMA='" + txtACIKLAMA.Text + "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtACIKLAMA.Clear();
            txtILGILI_PERSONEL.Clear();
            txtMUSTERI_AD.Clear();
            txtMUSTERI_NO.Clear();
            txtSERVIS_NUMARASI.Clear();
            txtSERVISTEKI_URUN.Clear();
            txtSURESI.Clear();

        }



    }
}
