using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ERP
{
    public partial class GIRIS : Form
    {
        public GIRIS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
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

        private void GIRIS_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {     
                baglanti.Open();
                string sql = "SELECT * FROM GIRIS WHERE KULLANICIADI=@KULLANICIADI AND PAROLA =@PAROLA ";
                SqlParameter prm1 = new SqlParameter("KULLANICIADI", txtKullanici.Text);
                SqlParameter prm2 = new SqlParameter("PAROLA", txtSifre.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);


                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                /* this.FormBorderStyle = FormBorderStyle.None;
                 txtKullanici.Text = "ADMIN";
                 txtSifre.Text = "1234";
                */
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ANASAYFA ANA = new ANASAYFA();
                    ANA.Show();
                    this.Hide();
                }

                baglanti.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Hatalı Giriş Yaptınız Kullanıcı Adınızı veya Parolanızı Kontrol Ediniz ");
                /*      this.FormBorderStyle = FormBorderStyle.None;
                     txtKullanici.Text = "ADMIN";
                     txtSifre.Text = "1234";
                     */
            }

        }
    }
}
