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
    public partial class M_T_GENEL : Form
    {
        public M_T_GENEL()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");

        //Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True
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

        private void M_T_GENEL_Load(object sender, EventArgs e)
        {

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            try
            {
                if(baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            }
            catch (Exception)
            {
                
                throw;
            }
            SqlCommand komut = new SqlCommand("insert into M_T_GENEL (MUSTERI_NO,AD_SOYAD,FIRMA,ILGILI_KISI,ADRES,SINIF,TEL,MAIL) values (' " + txtMusteriNO.Text + "','" + txtAD_SOYAD.Text + "','" + txtFIRMA.Text + "','" + txtILGILI_KISI.Text + "','" + txtADRES.Text + "','" + txtSINIF.Text + "','" + txtTEL.Text + "','" + txtMAIL.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            try
            {
                baglanti.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }

        private void verilerigöster()
        {
            listView1.Items.Clear();
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {
                
                throw;
            }
            SqlCommand komut = new SqlCommand("select * from M_T_GENEL", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["MUSTERI_NO"].ToString());
                ekle.SubItems.Add(oku["AD_SOYAD"].ToString());
                ekle.SubItems.Add(oku["FIRMA"].ToString());
                ekle.SubItems.Add(oku["ILGILI_KISI"].ToString());
                ekle.SubItems.Add(oku["ADRES"].ToString());
                ekle.SubItems.Add(oku["SINIF"].ToString());
                ekle.SubItems.Add(oku["TEL"].ToString());
                ekle.SubItems.Add(oku["MAIL"].ToString());

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
            txtFIRMA.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtILGILI_KISI.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtADRES.Text = listView1.SelectedItems[0].SubItems[5].Text;

            txtSINIF.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtTEL.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtMAIL.Text = listView1.SelectedItems[0].SubItems[8].Text;
        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from M_T_GENEL where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMusteriNO.Clear();
            txtAD_SOYAD.Clear();
            txtFIRMA.Clear();
            txtILGILI_KISI.Clear();
            txtADRES.Clear();
            txtSINIF.Clear();
            txtTEL.Clear();
            txtMAIL.Clear();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update M_T_GENEL set MUSTERI_NO= '" + txtMusteriNO.Text + "',AD_SOYAD='" + txtAD_SOYAD.Text + "',FIRMA= '" + txtFIRMA.Text + "',ILGILI_KISI='" + txtILGILI_KISI.Text + "',ADRES='" + txtADRES.Text + "',SINIF='" + txtSINIF.Text + "',TEL='" + txtTEL.Text + "',MAIL='" + txtMAIL.Text + "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void txtARA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblARAMA_Click(object sender, EventArgs e)
        {

        }

        private void btnARAMA_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from M_T_GENEL where MUSTERI_NO like '½ " + txtARA.Text + "½'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["MUSTERI_NO"].ToString());
                ekle.SubItems.Add(oku["AD_SOYAD"].ToString());
                ekle.SubItems.Add(oku["FIRMA"].ToString());
                ekle.SubItems.Add(oku["ILGILI_KISI"].ToString());
                ekle.SubItems.Add(oku["ADRES"].ToString());
                ekle.SubItems.Add(oku["SINIF"].ToString());
                ekle.SubItems.Add(oku["TEL"].ToString());
                ekle.SubItems.Add(oku["MAIL"].ToString());


                listView1.Items.Add(ekle);

            }

            baglanti.Close();

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into M_T_GENEL (MUSTERI_NO,AD_SOYAD,FIRMA,ILGILI_KISI,ADRES,SINIF,TEL,MAIL) values (' " + txtMusteriNO.Text + "','" + txtAD_SOYAD.Text + "','" + txtFIRMA.Text + "','" + txtILGILI_KISI.Text + "','" + txtADRES.Text + "','" + txtSINIF.Text + "','" + txtTEL.Text + "','" + txtMAIL.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }

    }
}
