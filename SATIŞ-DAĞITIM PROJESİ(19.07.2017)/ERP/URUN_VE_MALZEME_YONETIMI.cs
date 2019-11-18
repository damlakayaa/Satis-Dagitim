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
    public partial class URUNVEMALZEMEYONETIMI : Form
    {
        public URUNVEMALZEMEYONETIMI()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");

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

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            ANASAYFA anasayfa = new ANASAYFA();
            anasayfa.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into URUN_MALZEME_YONETIMI (URUN_NO,URUN_AD,URUN_KATEGORI,STOK_DURUMU,URUN_FIYATI) values (' " + txtURUN_NO.Text + "','" + txtURUN_AD.Text + "','" + txtURUN_KATEGORI.Text + "','" + txtSTOK.Text + "','" + txtURUN_FIYATI.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from URUN_MALZEME_YONETIMI", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["URUN_NO"].ToString());
                ekle.SubItems.Add(oku["URUN_AD"].ToString());
                ekle.SubItems.Add(oku["URUN_KATEGORI"].ToString());
                ekle.SubItems.Add(oku["STOK_DURUMU"].ToString());
                ekle.SubItems.Add(oku["URUN_FIYATI"].ToString());
                
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
            txtURUN_NO.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtURUN_AD.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtURUN_KATEGORI.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtSTOK.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtURUN_FIYATI.Text = listView1.SelectedItems[0].SubItems[5].Text;

            
        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from URUN_MALZEME_YONETIMI where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update URUN_MALZEME_YONETIMI set URUN_NO= '" + txtURUN_NO.Text + "',URUN_AD='" + txtURUN_AD.Text + "',URUN_KATEGORI= '" + txtURUN_KATEGORI.Text + "',STOK_DURUMU='" + txtSTOK.Text + "',URUN_FIYATI='" + txtURUN_FIYATI.Text +  "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSTOK.Clear();
            txtURUN_AD.Clear();
            txtURUN_FIYATI.Clear();
            txtURUN_KATEGORI.Clear();
            txtURUN_NO.Clear();
        }

        private void lblURUN_KATEGORI_Click(object sender, EventArgs e)
        {

        }


    }
}
