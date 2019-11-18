namespace ERP
{
    partial class RAPORLAR
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
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLISTELE = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.Location = new System.Drawing.Point(547, 12);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(80, 29);
            this.btnAnasayfa.TabIndex = 4;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(646, 392);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 46);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEXCEL.Location = new System.Drawing.Point(15, 392);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(145, 33);
            this.btnEXCEL.TabIndex = 18;
            this.btnEXCEL.Text = "Excel\'e Aktar";
            this.btnEXCEL.UseVisualStyleBackColor = false;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 228);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnLISTELE
            // 
            this.btnLISTELE.Location = new System.Drawing.Point(249, 76);
            this.btnLISTELE.Name = "btnLISTELE";
            this.btnLISTELE.Size = new System.Drawing.Size(100, 23);
            this.btnLISTELE.TabIndex = 16;
            this.btnLISTELE.Text = " LISTELE";
            this.btnLISTELE.UseVisualStyleBackColor = true;
            this.btnLISTELE.Click += new System.EventHandler(this.btnLISTELE_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(171, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(131, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Yapılacak işlemini seçiniz :";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RAPORLAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 468);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLISTELE);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnasayfa);
            this.Name = "RAPORLAR";
            this.Text = "RAPORLAR";
            this.Load += new System.EventHandler(this.RAPORLAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLISTELE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}