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
    public partial class M_T_ILISKILER : Form
    {
        public M_T_ILISKILER()
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

        private void M_T_ILISKILER_Load(object sender, EventArgs e)
        {

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into M_T_ILISKILER (FATURA_ALAN,URUNU_ALAN,FATURA_KESEN,URUN_GONDEREN,GONDERIM_SURESI) values (' " + txtFATURA_ALAN.Text + "','" + txtURUN_ALAN.Text + "','" + txtFATURA_KESEN.Text + "','" + txtURUN_GONDEREN.Text + "','" + txtGONDERIM_SURESI.Text +  "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from M_T_ILISKILER", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["FATURA_ALAN"].ToString());
                ekle.SubItems.Add(oku["URUNU_ALAN"].ToString());
                ekle.SubItems.Add(oku["FATURA_KESEN"].ToString());
                ekle.SubItems.Add(oku["URUN_GONDEREN"].ToString());
                ekle.SubItems.Add(oku["GONDERIM_SURESI"].ToString());
                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into M_T_ILISKILER (FATURA_ALAN,URUNU_ALAN,FATURA_KESEN,URUN_GONDEREN,GONDERIM_SURESI) values (' " + txtFATURA_ALAN.Text + "','" + txtURUN_ALAN.Text + "','" + txtFATURA_KESEN.Text + "','" + txtURUN_GONDEREN.Text + "','" + txtGONDERIM_SURESI.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtFATURA_ALAN.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtURUN_ALAN.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtFATURA_KESEN.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtURUN_GONDEREN.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtGONDERIM_SURESI.Text = listView1.SelectedItems[0].SubItems[5].Text;

           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from M_T_ILISKILER where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update M_T_ILISKILER set FATURA_ALAN= '" + txtFATURA_ALAN.Text + "',URUNU_ALAN='" + txtURUN_ALAN.Text + "',FATURA_KESEN= '" + txtFATURA_KESEN.Text + "',URUN_GONDEREN='" + txtURUN_GONDEREN.Text + "',GONDERIM_SURESI='" + txtGONDERIM_SURESI.Text + "' where ID=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtFATURA_ALAN.Clear();
            txtFATURA_KESEN.Clear();
            txtGONDERIM_SURESI.Clear();
            txtURUN_ALAN.Clear();
            txtURUN_GONDEREN.Clear();

        }


    }
}
