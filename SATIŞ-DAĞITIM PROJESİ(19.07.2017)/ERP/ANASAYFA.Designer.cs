namespace ERP
{
    partial class ANASAYFA
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mUSTERITEDARIKCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATISMUSTERIILISKILERIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRUNMALZEMEYONETIMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATISSERVISYONETIMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dAGITIMLOGISTIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uZAKBAGLANTIVERİLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSaatt = new System.Windows.Forms.Label();
            this.btnADMIN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthCalendar1.Location = new System.Drawing.Point(18, 80);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(340, 178);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(80, 64);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.Location = new System.Drawing.Point(340, 80);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(80, 64);
            this.btnAnasayfa.TabIndex = 3;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTime.HideSelection = false;
            this.txtTime.Location = new System.Drawing.Point(21, 24);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(325, 19);
            this.txtTime.TabIndex = 4;
            this.txtTime.Text = "ERP SATIS DAGITIM  PROGRAMı";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.WordWrap = false;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(652, 196);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 14);
            this.lblSaat.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUSTERITEDARIKCIToolStripMenuItem,
            this.sATISMUSTERIILISKILERIToolStripMenuItem,
            this.uRUNMALZEMEYONETIMIToolStripMenuItem,
            this.sATISSERVISYONETIMIToolStripMenuItem,
            this.dAGITIMLOGISTIKToolStripMenuItem,
            this.rAPORLARToolStripMenuItem,
            this.uZAKBAGLANTIVERİLERİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(447, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(171, 489);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mUSTERITEDARIKCIToolStripMenuItem
            // 
            this.mUSTERITEDARIKCIToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUSTERITEDARIKCIToolStripMenuItem.Name = "mUSTERITEDARIKCIToolStripMenuItem";
            this.mUSTERITEDARIKCIToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.mUSTERITEDARIKCIToolStripMenuItem.Text = "MUSTERI TEDARIKCI";
            this.mUSTERITEDARIKCIToolStripMenuItem.Click += new System.EventHandler(this.mUSTERITEDARIKCIToolStripMenuItem_Click);
            // 
            // sATISMUSTERIILISKILERIToolStripMenuItem
            // 
            this.sATISMUSTERIILISKILERIToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sATISMUSTERIILISKILERIToolStripMenuItem.Name = "sATISMUSTERIILISKILERIToolStripMenuItem";
            this.sATISMUSTERIILISKILERIToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.sATISMUSTERIILISKILERIToolStripMenuItem.Text = "SATIS MUSTERI ILISKILERI";
            this.sATISMUSTERIILISKILERIToolStripMenuItem.Click += new System.EventHandler(this.sATISMUSTERIILISKILERIToolStripMenuItem_Click);
            // 
            // uRUNMALZEMEYONETIMIToolStripMenuItem
            // 
            this.uRUNMALZEMEYONETIMIToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uRUNMALZEMEYONETIMIToolStripMenuItem.Name = "uRUNMALZEMEYONETIMIToolStripMenuItem";
            this.uRUNMALZEMEYONETIMIToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.uRUNMALZEMEYONETIMIToolStripMenuItem.Text = "URUN MALZEME YONETIMI ";
            this.uRUNMALZEMEYONETIMIToolStripMenuItem.Click += new System.EventHandler(this.uRUNMALZEMEYONETIMIToolStripMenuItem_Click);
            // 
            // sATISSERVISYONETIMIToolStripMenuItem
            // 
            this.sATISSERVISYONETIMIToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sATISSERVISYONETIMIToolStripMenuItem.Name = "sATISSERVISYONETIMIToolStripMenuItem";
            this.sATISSERVISYONETIMIToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.sATISSERVISYONETIMIToolStripMenuItem.Text = "SATIS SERVIS YONETIMI";
            this.sATISSERVISYONETIMIToolStripMenuItem.Click += new System.EventHandler(this.sATISSERVISYONETIMIToolStripMenuItem_Click);
            // 
            // dAGITIMLOGISTIKToolStripMenuItem
            // 
            this.dAGITIMLOGISTIKToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dAGITIMLOGISTIKToolStripMenuItem.Name = "dAGITIMLOGISTIKToolStripMenuItem";
            this.dAGITIMLOGISTIKToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.dAGITIMLOGISTIKToolStripMenuItem.Text = "DAGITIM LOGISTIK ";
            this.dAGITIMLOGISTIKToolStripMenuItem.Click += new System.EventHandler(this.dAGITIMLOGISTIKToolStripMenuItem_Click);
            // 
            // rAPORLARToolStripMenuItem
            // 
            this.rAPORLARToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rAPORLARToolStripMenuItem.Name = "rAPORLARToolStripMenuItem";
            this.rAPORLARToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.rAPORLARToolStripMenuItem.Text = "RAPORLAR";
            this.rAPORLARToolStripMenuItem.Click += new System.EventHandler(this.rAPORLARToolStripMenuItem_Click);
            // 
            // uZAKBAGLANTIVERİLERİToolStripMenuItem
            // 
            this.uZAKBAGLANTIVERİLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem});
            this.uZAKBAGLANTIVERİLERİToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uZAKBAGLANTIVERİLERİToolStripMenuItem.Name = "uZAKBAGLANTIVERİLERİToolStripMenuItem";
            this.uZAKBAGLANTIVERİLERİToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.uZAKBAGLANTIVERİLERİToolStripMenuItem.Text = "UZAK BAGLANTI VERILERI";
            this.uZAKBAGLANTIVERİLERİToolStripMenuItem.Click += new System.EventHandler(this.uZAKBAGLANTIVERİLERİToolStripMenuItem_Click);
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            // 
            // lblSaatt
            // 
            this.lblSaatt.AutoSize = true;
            this.lblSaatt.Location = new System.Drawing.Point(221, 214);
            this.lblSaatt.Name = "lblSaatt";
            this.lblSaatt.Size = new System.Drawing.Size(0, 14);
            this.lblSaatt.TabIndex = 7;
            // 
            // btnADMIN
            // 
            this.btnADMIN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADMIN.Location = new System.Drawing.Point(0, 464);
            this.btnADMIN.Name = "btnADMIN";
            this.btnADMIN.Size = new System.Drawing.Size(64, 25);
            this.btnADMIN.TabIndex = 8;
            this.btnADMIN.Text = "ADMIN";
            this.btnADMIN.UseVisualStyleBackColor = true;
            this.btnADMIN.Click += new System.EventHandler(this.btnADMIN_Click);
            // 
            // ANASAYFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 489);
            this.Controls.Add(this.btnADMIN);
            this.Controls.Add(this.lblSaatt);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ANASAYFA";
            this.Text = "ANASAYFA ";
            this.Load += new System.EventHandler(this.ANASAYFA_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mUSTERITEDARIKCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sATISMUSTERIILISKILERIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uRUNMALZEMEYONETIMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sATISSERVISYONETIMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dAGITIMLOGISTIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem;
        private System.Windows.Forms.Label lblSaatt;
        private System.Windows.Forms.ToolStripMenuItem uZAKBAGLANTIVERİLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.Button btnADMIN;
    }
}