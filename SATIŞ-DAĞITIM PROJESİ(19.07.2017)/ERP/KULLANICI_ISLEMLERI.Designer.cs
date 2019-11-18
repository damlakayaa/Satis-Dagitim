namespace ERP
{
    partial class KULLANICI_ISLEMLERI
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
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ADMINID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KULLANICIADI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PAROLA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KULLANICITIPI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboTIP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.Location = new System.Drawing.Point(30, 19);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(80, 45);
            this.btnAnasayfa.TabIndex = 126;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(668, 19);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 45);
            this.btnCikis.TabIndex = 125;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(243, 223);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(65, 45);
            this.btnTemizle.TabIndex = 124;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(329, 223);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(64, 45);
            this.btnGuncelle.TabIndex = 123;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(420, 223);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 45);
            this.btnSil.TabIndex = 122;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniKayit.Location = new System.Drawing.Point(75, 223);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(64, 45);
            this.btnYeniKayit.TabIndex = 121;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoruntule.Location = new System.Drawing.Point(154, 223);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(65, 45);
            this.btnGoruntule.TabIndex = 120;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ADMINID,
            this.KULLANICIADI,
            this.PAROLA,
            this.KULLANICITIPI});
            this.listView1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(75, 274);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(606, 176);
            this.listView1.TabIndex = 119;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ADMINID
            // 
            this.ADMINID.Text = "ADMIN  ID";
            this.ADMINID.Width = 106;
            // 
            // KULLANICIADI
            // 
            this.KULLANICIADI.Text = "KULLANICI  ADI";
            this.KULLANICIADI.Width = 165;
            // 
            // PAROLA
            // 
            this.PAROLA.Text = "PAROLA";
            this.PAROLA.Width = 113;
            // 
            // KULLANICITIPI
            // 
            this.KULLANICITIPI.Text = "KULLANICI   TIPI";
            this.KULLANICITIPI.Width = 187;
            // 
            // comboTIP
            // 
            this.comboTIP.BackColor = System.Drawing.Color.White;
            this.comboTIP.FormattingEnabled = true;
            this.comboTIP.Items.AddRange(new object[] {
            "ADMIN",
            "PERSONEL",
            "MISAFIR"});
            this.comboTIP.Location = new System.Drawing.Point(399, 154);
            this.comboTIP.Name = "comboTIP";
            this.comboTIP.Size = new System.Drawing.Size(126, 21);
            this.comboTIP.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 117;
            this.label2.Text = "Kullanıcı Tipi  :";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSifre.Location = new System.Drawing.Point(399, 112);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(126, 20);
            this.txtSifre.TabIndex = 115;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(70, 112);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(64, 25);
            this.lblSifre.TabIndex = 113;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanici.Location = new System.Drawing.Point(70, 72);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(138, 25);
            this.lblkullanici.TabIndex = 112;
            this.lblkullanici.Text = "Kullanıcı Adı :";
            // 
            // txtKullanici
            // 
            this.txtKullanici.BackColor = System.Drawing.Color.White;
            this.txtKullanici.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtKullanici.Location = new System.Drawing.Point(399, 72);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(126, 20);
            this.txtKullanici.TabIndex = 114;
            // 
            // KULLANICI_ISLEMLERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 462);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboTIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.txtKullanici);
            this.Name = "KULLANICI_ISLEMLERI";
            this.Text = "KULLANICI_ISLEMLERI";
            this.Load += new System.EventHandler(this.KULLANICI_ISLEMLERI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ADMINID;
        private System.Windows.Forms.ColumnHeader KULLANICIADI;
        private System.Windows.Forms.ColumnHeader PAROLA;
        private System.Windows.Forms.ColumnHeader KULLANICITIPI;
        private System.Windows.Forms.ComboBox comboTIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.TextBox txtKullanici;
    }
}