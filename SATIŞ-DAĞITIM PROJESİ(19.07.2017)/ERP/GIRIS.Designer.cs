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
            this.btnGiris.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(279, 136);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(159, 51);
            this.btnGiris.TabIndex = 24;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSifre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSifre.Location = new System.Drawing.Point(339, 51);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(126, 21);
            this.txtSifre.TabIndex = 23;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanici
            // 
            this.txtKullanici.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKullanici.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtKullanici.Location = new System.Drawing.Point(339, 16);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(126, 21);
            this.txtKullanici.TabIndex = 22;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(250, 51);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(61, 26);
            this.lblSifre.TabIndex = 21;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanici.Location = new System.Drawing.Point(183, 11);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(128, 26);
            this.lblkullanici.TabIndex = 20;
            this.lblkullanici.Text = "Kullanıcı Adı :";
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(570, 364);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 44);
            this.btnCikis.TabIndex = 25;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // GIRIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 420);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblkullanici);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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