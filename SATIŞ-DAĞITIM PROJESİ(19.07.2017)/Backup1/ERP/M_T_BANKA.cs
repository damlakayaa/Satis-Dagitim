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
    public partial class M_T_BANKA : Form
    {
        public M_T_BANKA()
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

        private void mUHASEBEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M_T_MUHASEBE muhasebe = new M_T_MUHASEBE();
            muhasebe.Show();
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

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into M_T_BANKA (BANKA_ADI,BANKA_ADRESI,BANKA_NUMARASI,BANKA_HESABI,PARA_BIRIMI,TUTAR) values (' " +txtBANKA_ADI.Text + "','" + txtBANKA_ADRESI.Text + "','" +txtBANKA_NUMARASI.Text + "','" + txtBANKA_HESABI.Text + "','" + txtPARA_BIRIMI.Text + "','" + txtTUTAR.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }

        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from M_T_BANKA", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["BANKA_ADI"].ToString());
                ekle.SubItems.Add(oku["BANKA_ADRESI"].ToString());
                ekle.SubItems.Add(oku["BANKA_NUMARASI"].ToString());
                ekle.SubItems.Add(oku["BANKA_HESABI"].ToString());
                ekle.SubItems.Add(oku["PARA_BIRIMI"].ToString());
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
            txtBANKA_ADI.Text = listView1.SelectedItems[0].SubItems[1].Text;
           txtBANKA_ADRESI.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtBANKA_NUMARASI.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtBANKA_HESABI.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtPARA_BIRIMI.Text = listView1.SelectedItems[0].SubItems[5].Text;

            txtTUTAR.Text = listView1.SelectedItems[0].SubItems[6].Text;
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from M_T_BANKA where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBANKA_ADI.Clear();
            txtBANKA_ADRESI.Clear();
            txtBANKA_HESABI.Clear();
            txtBANKA_NUMARASI.Clear();
            txtPARA_BIRIMI.Clear();
            txtTUTAR.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update M_T_BANKA set BANKA_ADI= '" + txtBANKA_ADI.Text + "',BANKA_ADRESI='" + txtBANKA_ADRESI.Text + "',BANKA_NUMARASI= '" + txtBANKA_NUMARASI.Text + "',BANKA_HESABI='" + txtBANKA_HESABI.Text  + "',PARA_BIRIMI='" + txtPARA_BIRIMI.Text + "',TUTAR='" + txtTUTAR.Text + "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }
    }
}
