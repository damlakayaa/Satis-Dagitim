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
namespace ERP
{
    public partial class RAPORLAR : Form
    {
        public RAPORLAR()
        {
            InitializeComponent();
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
        string menü;
        private void btnLISTELE_Click(object sender, EventArgs e)
        {
            menü = comboBox1.SelectedItem.ToString();

            if (menü == "Müşteri GENEL Bilgilerini Listele ")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from M_T_GENEL ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
            else if (menü == "Müşteri ilişkileri Bilgilerini Listele")
            {
                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from M_T_ILISKILER ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();



            }
            else if (menü == "Muhasebe Bilgilerini Listele")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from M_T_MUHASEBE ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (menü == "Banka Bilgilerini Listele")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from M_T_BANKA ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (menü == "Adres Bilgilerini Listele")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from M_T_ADRES", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (menü == "Notlar Bilgilerini Listele")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from M_T_NOTLAR", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (menü == "Satış & Müşteri Bilgilerini Listele")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from SATIS_MUSTERI_ILISKILERI", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (menü == "Ürün & Malzeme Bilgilerini Listele")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from URUN_MALZEME_YONETIMI", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (menü == "Satış & Servis Bilgilerini Listele")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from SATIS_SERVIS_YONETIMII", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (menü == "Dağıtım & Lojistik Bilgilerini Listele")
            {

                SqlConnection con = new SqlConnection(@"Data Source=ASUS-BILGISAYAR;Initial Catalog=Erp_Test;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from DAGITIM_LOGISTIK", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1;

            int StartRow = 1;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dataGridView1.Columns[j].HeaderText;

            }

            StartRow++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    try
                    {

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];

                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;

                    }

                    catch
                    { ;}

                }

            }
        }

        private void RAPORLAR_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = lblTime.Text.Substring(1) + lblTime.Text.Substring(0, 1);
        }
    }
}
