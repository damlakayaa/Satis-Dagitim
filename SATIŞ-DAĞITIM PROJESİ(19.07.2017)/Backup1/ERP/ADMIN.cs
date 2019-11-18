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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOKO;Initial Catalog=ERP;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ADMIN (KULLANICIADI,PAROLA,KULLANICITIPI) values (' " + txtKullanici.Text + "','" + txtSifre.Text + "','" + comboTIP.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kayit başarılı bir sekilde gerceklestirilmistir..");
        }
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ADMIN", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ADMINID"].ToString();
                ekle.SubItems.Add(oku["KULLANICIADI"].ToString());
                ekle.SubItems.Add(oku["PAROLA"].ToString());
                ekle.SubItems.Add(oku["KULLANICITIPI"].ToString());

                listView1.Items.Add(ekle);


            }

            baglanti.Close();

        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }
        int ID = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtKullanici.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSifre.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboTIP.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from ADMIN where ADMINID=(" + ID + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSifre.Clear();
            txtKullanici.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ADMIN set KULLANICIADI= '" + txtKullanici.Text + "',PAROLA='" + txtSifre.Text + "',KULLANICITIPI='" + comboTIP.Text + "' where ADMINID=" + ID + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigöster();
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
    }
}
