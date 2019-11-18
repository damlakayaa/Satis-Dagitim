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
    public partial class M_T_NOTLAR : Form
    {
        public M_T_NOTLAR()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");

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

        private void M_T_NOTLAR_Load(object sender, EventArgs e)
        {

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into M_T_NOTLAR(MUSTERI_NO,AD_SOYAD,GONDERILEN_KISI,[NOT]) values (' " + txtMusteriNO.Text + "','" + txtAD_SOYAD.Text + "','" + txtGONDEREN_KISI.Text + "','" + txtNOT.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from M_T_NOTLAR", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["MUSTERI_NO"].ToString());
                ekle.SubItems.Add(oku["AD_SOYAD"].ToString());
                ekle.SubItems.Add(oku["GONDERILEN_KISI"].ToString());
                ekle.SubItems.Add(oku["NOT"].ToString());
               
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
            txtAD_SOYAD.Text = listView1.SelectedItems[0].SubItems[2].Text;
       txtGONDEREN_KISI.Text= listView1.SelectedItems[0].SubItems[3].Text;
            txtNOT.Text = listView1.SelectedItems[0].SubItems[4].Text;
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from M_T_NOTLAR where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update M_T_NOTLAR set MUSTERI_NO= '" + txtMusteriNO.Text + "',AD_SOYAD='" + txtAD_SOYAD.Text + "',GONDERILEN_KISI= '" + txtGONDEREN_KISI.Text + "',[NOT]='" + txtNOT.Text +  "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAD_SOYAD.Clear();
            txtGONDEREN_KISI.Clear();
            txtMusteriNO.Clear();
            txtNOT.Clear();

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {

        }

        private void btnARAMA_Click(object sender, EventArgs e)
        {

        }


    }
}
