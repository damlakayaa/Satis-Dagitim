using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class UZAK_BAGLANTI_VERILERI : Form
    {
        public UZAK_BAGLANTI_VERILERI()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = lblTime.Text.Substring(1) + lblTime.Text.Substring(0, 1);

             lblTRG.Text = lblTRG.Text.Substring(1) + lblTRG.Text.Substring(0, 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UZAK_BAGLANTI_VERILERI_Load(object sender, EventArgs e)
        {

        }

        private void btnLISTELE_Click(object sender, EventArgs e)
        {

        }
    }
}
