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
    public partial class SATIS_VE_MUSTERI_ILISKILERI : Form
    {
        public SATIS_VE_MUSTERI_ILISKILERI()
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

        private void sATISMUSTERIILISKILERIToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void SATIS_VE_MUSTERI_ILISKILERI_Load(object sender, EventArgs e)
        {

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into SATIS_MUSTERI_ILISKILERI (ID,MUSTERI_HESAP,FIRMA_AD,SEHIR,POSTA_KODU,TEL) values (' " + txtID.Text + "',' " + txtMUSTERI_HESAP.Text + "','" + txtFIRMA.Text + "','" + txtSEHIR.Text + "','" + txtPOSTA.Text + "','" + txtTEL.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SATIS_MUSTERI_ILISKILERI", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["MUSTERI_NO"].ToString());
                ekle.SubItems.Add(oku["MUSTERI_HESAP"].ToString());
                ekle.SubItems.Add(oku["FIRMA_AD"].ToString());
                ekle.SubItems.Add(oku["SEHIR"].ToString());
                ekle.SubItems.Add(oku["POSTA_KODU"].ToString());
               
                ekle.SubItems.Add(oku["TEL"].ToString());
              

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
            txtID.Text = listView1.SelectedItems[0].SubItems[1].Text;
           txtMUSTERI_HESAP.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtFIRMA.Text= listView1.SelectedItems[0].SubItems[3].Text;
           txtSEHIR.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtPOSTA.Text = listView1.SelectedItems[0].SubItems[5].Text;

            txtTEL.Text = listView1.SelectedItems[0].SubItems[6].Text;
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from SATIS_MUSTERI_ILISKILERI where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update SATIS_MUSTERI_ILISKILERI set ID= '" + txtID.Text + "',MUSTERI_HESAP='" + txtMUSTERI_HESAP.Text + "',FIRMA_AD= '" + txtFIRMA.Text + "',SEHIR='" + txtSEHIR.Text + "',POSTA_KODU='" + txtPOSTA.Text + "',TEL='" + txtTEL.Text + "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtFIRMA.Clear();
            txtID.Clear();
            txtMUSTERI_HESAP.Clear();
            txtPOSTA.Clear();
            txtSEHIR.Clear();
            txtTEL.Clear();



        }




    }
}
