namespace ERP
{
    partial class GIRIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GIRIS));
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Location = new System.Drawing.Point(276, 82);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(159, 70);
            this.btnGiris.TabIndex = 24;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtSifre.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtSifre.Location = new System.Drawing.Point(382, 51);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(126, 20);
            this.txtSifre.TabIndex = 23;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanici
            // 
            this.txtKullanici.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtKullanici.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtKullanici.Location = new System.Drawing.Point(382, 11);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(126, 20);
            this.txtKullanici.TabIndex = 22;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(301, 51);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(75, 28);
            this.lblSifre.TabIndex = 21;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkullanici.Location = new System.Drawing.Point(183, 11);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(182, 28);
            this.lblkullanici.TabIndex = 20;
            this.lblkullanici.Text = "Kullanıcı Adı :";
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(570, 349);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 59);
            this.btnCikis.TabIndex = 25;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // GIRIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 420);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblkullanici);
            this.Name = "GIRIS";
            this.Text = "GIRIS";
            this.Load += new System.EventHandler(this.GIRIS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Button btnCikis;
    }
}