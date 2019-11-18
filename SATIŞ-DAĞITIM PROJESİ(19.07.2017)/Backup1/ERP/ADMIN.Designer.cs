namespace ERP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ADMINID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KULLANICIADI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PAROLA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KULLANICITIPI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboTIP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ADMINID,
            this.KULLANICIADI,
            this.PAROLA,
            this.KULLANICITIPI});
            this.listView1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(46, 199);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(667, 168);
            this.listView1.TabIndex = 104;
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
            this.comboTIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboTIP.FormattingEnabled = true;
            this.comboTIP.Items.AddRange(new object[] {
            "ADMIN",
            "PERSONEL",
            "MISAFIR"});
            this.comboTIP.Location = new System.Drawing.Point(370, 147);
            this.comboTIP.Name = "comboTIP";
            this.comboTIP.Size = new System.Drawing.Size(126, 21);
            this.comboTIP.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(175, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 102;
            this.label2.Text = "Kullanıcı Tipi  :";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Location = new System.Drawing.Point(46, 38);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(125, 150);
            this.btnGiris.TabIndex = 101;
            this.btnGiris.UseVisualStyleBackColor = false;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSifre.Location = new System.Drawing.Point(370, 105);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(126, 20);
            this.txtSifre.TabIndex = 100;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanici
            // 
            this.txtKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtKullanici.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtKullanici.Location = new System.Drawing.Point(370, 65);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(126, 20);
            this.txtKullanici.TabIndex = 99;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(293, 102);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(75, 28);
            this.lblSifre.TabIndex = 98;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkullanici.Location = new System.Drawing.Point(175, 62);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(182, 28);
            this.lblkullanici.TabIndex = 97;
            this.lblkullanici.Text = "Kullanıcı Adı :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(591, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(52, 45);
            this.btnTemizle.TabIndex = 109;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(454, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(52, 45);
            this.btnGuncelle.TabIndex = 108;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(661, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(52, 45);
            this.btnSil.TabIndex = 107;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYeniKayit.BackgroundImage")));
            this.btnYeniKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniKayit.Location = new System.Drawing.Point(523, 12);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(52, 45);
            this.btnYeniKayit.TabIndex = 106;
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoruntule.BackgroundImage")));
            this.btnGoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoruntule.Location = new System.Drawing.Point(384, 12);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(52, 45);
            this.btnGoruntule.TabIndex = 105;
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(628, 378);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 59);
            this.btnCikis.TabIndex = 110;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.BackgroundImage")));
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.Location = new System.Drawing.Point(12, 378);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(80, 59);
            this.btnAnasayfa.TabIndex = 111;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 449);
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
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblkullanici);
            this.Name = "Form1";
            this.Text = "KULLANICI ISLEMLERI ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ADMINID;
        private System.Windows.Forms.ColumnHeader KULLANICIADI;
        private System.Windows.Forms.ColumnHeader PAROLA;
        private System.Windows.Forms.ColumnHeader KULLANICITIPI;
        private System.Windows.Forms.ComboBox comboTIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnasayfa;

    }
}

