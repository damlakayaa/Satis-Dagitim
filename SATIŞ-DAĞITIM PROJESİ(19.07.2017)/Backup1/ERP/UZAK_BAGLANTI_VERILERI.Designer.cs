namespace ERP
{
    partial class UZAK_BAGLANTI_VERILERI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UZAK_BAGLANTI_VERILERI));
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLISTELE = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTRG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEXCEL.Location = new System.Drawing.Point(310, 401);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(145, 33);
            this.btnEXCEL.TabIndex = 25;
            this.btnEXCEL.Text = "Excel\'e Aktar";
            this.btnEXCEL.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 312);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnLISTELE
            // 
            this.btnLISTELE.Location = new System.Drawing.Point(274, 54);
            this.btnLISTELE.Name = "btnLISTELE";
            this.btnLISTELE.Size = new System.Drawing.Size(100, 23);
            this.btnLISTELE.TabIndex = 23;
            this.btnLISTELE.Text = "...: LISTELE :...";
            this.btnLISTELE.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Müşteri GENEL Bilgilerini Listele",
            "Müşteri ilişkileri Bilgilerini Listele",
            "Muhasebe Bilgilerini Listele",
            "Banka Bilgilerini Listele",
            "Adres Bilgilerini Listele",
            "Notlar Bilgilerini Listele",
            "Satış & Müşteri Bilgilerini Listele",
            "Ürün & Malzeme Bilgilerini Listele",
            "Satış & Servis Bilgilerini Listele",
            "Dağıtım & Lojistik Bilgilerini Listele"});
            this.comboBox1.Location = new System.Drawing.Point(237, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(234, 5);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(193, 13);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "....Yapılacak Listeleme işlemini seçiniz...";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(681, 407);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 59);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.BackgroundImage")));
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.Location = new System.Drawing.Point(22, 8);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(80, 59);
            this.btnAnasayfa.TabIndex = 19;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTRG
            // 
            this.lblTRG.AutoSize = true;
            this.lblTRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTRG.Location = new System.Drawing.Point(481, 9);
            this.lblTRG.Name = "lblTRG";
            this.lblTRG.Size = new System.Drawing.Size(285, 16);
            this.lblTRG.TabIndex = 26;
            this.lblTRG.Text = ".....TRIGGER ILE OLUSAN TABLOLAR....";
            // 
            // UZAK_BAGLANTI_VERILERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 463);
            this.Controls.Add(this.lblTRG);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLISTELE);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnasayfa);
            this.Name = "UZAK_BAGLANTI_VERILERI";
            this.Text = "UZAK_BAGLANTI_VERILERI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLISTELE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTRG;
    }
}