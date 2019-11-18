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
    public partial class DAGITIM_VE_LOGISTIK : Form
    {
        public DAGITIM_VE_LOGISTIK()
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

        private void sATISSERVISYONETIMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SATIS_VE_SERVIS_YONETIMI satis_servis = new SATIS_VE_SERVIS_YONETIMI();
            satis_servis.Show();
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

        private void DAGITIM_VE_LOGISTIK_Load(object sender, EventArgs e)
        {

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into DAGITIM_LOGISTIK (MUSTERI_NO,SEHIR,SURE,URUN,DAGITIM_SORUMLUSU,ACIKLAMA) values (' " + txtMusteriNO.Text + "','" +txtSEHIR.Text + "','" + txtSURE.Text + "','" + txtURUN.Text + "','" + txtDAGITIM_SORUMLUSU.Text + "','" + txtACIKLAMA.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from DAGITIM_LOGISTIK", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["MUSTERI_NO"].ToString());
                ekle.SubItems.Add(oku["SEHIR"].ToString());
                ekle.SubItems.Add(oku["SURE"].ToString());
                ekle.SubItems.Add(oku["URUN"].ToString());
                ekle.SubItems.Add(oku["DAGITIM_SORUMLUSU"].ToString());
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
            txtMusteriNO.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSEHIR.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtSURE.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtURUN.Text = listView1.SelectedItems[0].SubItems[4].Text;
           txtDAGITIM_SORUMLUSU.Text = listView1.SelectedItems[0].SubItems[5].Text;

            txtACIKLAMA.Text = listView1.SelectedItems[0].SubItems[6].Text;
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from DAGITIM_LOGISTIK where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update DAGITIM_LOGISTIK set MUSTERI_NO= '" + txtMusteriNO.Text + "',SEHIR='" + txtSEHIR.Text + "',SURE= '" + txtSURE.Text + "',URUN='" + txtURUN.Text + "',DAGITIM_SORUMLUSU='" +txtDAGITIM_SORUMLUSU.Text + "',ACIKLAMA='" + txtACIKLAMA.Text + "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtACIKLAMA.Clear();
            txtDAGITIM_SORUMLUSU.Clear();
            txtMusteriNO.Clear();
            txtSEHIR.Clear();
            txtSURE.Clear();
            txtURUN.Clear();

        }

    }
}
