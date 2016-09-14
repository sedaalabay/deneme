namespace Kar_Zarar_Takip_Sistemi
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iŞLEMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şirketBilgisiDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fİNANSALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderTakibiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.lblSirketKodu = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblFaxNo = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblYetkiliKisi = new System.Windows.Forms.Label();
            this.dgvSirketler = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirketler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şirket İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(258, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şirket Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(258, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(258, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fax Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(259, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Eposta Adresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(258, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yetkili Kişi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iŞLEMLERToolStripMenuItem,
            this.fİNANSALToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            this.iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirGiderKaydıToolStripMenuItem,
            this.şirketBilgisiDüzenlemeToolStripMenuItem});
            this.iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            this.iŞLEMLERToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            this.iŞLEMLERToolStripMenuItem.Click += new System.EventHandler(this.iŞLEMLERToolStripMenuItem_Click);
            // 
            // gelirGiderKaydıToolStripMenuItem
            // 
            this.gelirGiderKaydıToolStripMenuItem.Name = "gelirGiderKaydıToolStripMenuItem";
            this.gelirGiderKaydıToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.gelirGiderKaydıToolStripMenuItem.Text = "Gelir Gider Kaydı";
            this.gelirGiderKaydıToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderKaydıToolStripMenuItem_Click);
            // 
            // şirketBilgisiDüzenlemeToolStripMenuItem
            // 
            this.şirketBilgisiDüzenlemeToolStripMenuItem.Name = "şirketBilgisiDüzenlemeToolStripMenuItem";
            this.şirketBilgisiDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.şirketBilgisiDüzenlemeToolStripMenuItem.Text = "Şirket Bilgisi Düzenleme";
            this.şirketBilgisiDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.şirketBilgisiDüzenlemeToolStripMenuItem_Click);
            // 
            // fİNANSALToolStripMenuItem
            // 
            this.fİNANSALToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirGiderTakibiToolStripMenuItem});
            this.fİNANSALToolStripMenuItem.Name = "fİNANSALToolStripMenuItem";
            this.fİNANSALToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fİNANSALToolStripMenuItem.Text = "FİNANSAL";
            // 
            // gelirGiderTakibiToolStripMenuItem
            // 
            this.gelirGiderTakibiToolStripMenuItem.Name = "gelirGiderTakibiToolStripMenuItem";
            this.gelirGiderTakibiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.gelirGiderTakibiToolStripMenuItem.Text = "Gelir Gider Analizi";
            this.gelirGiderTakibiToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderTakibiToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.AutoSize = true;
            this.lblSirketAdi.Location = new System.Drawing.Point(394, 56);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(0, 13);
            this.lblSirketAdi.TabIndex = 23;
            // 
            // lblSirketKodu
            // 
            this.lblSirketKodu.AutoSize = true;
            this.lblSirketKodu.Location = new System.Drawing.Point(394, 104);
            this.lblSirketKodu.Name = "lblSirketKodu";
            this.lblSirketKodu.Size = new System.Drawing.Size(0, 13);
            this.lblSirketKodu.TabIndex = 24;
            this.lblSirketKodu.Click += new System.EventHandler(this.lblSirketKodu_Click);
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(394, 149);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(0, 13);
            this.lblTelNo.TabIndex = 25;
            // 
            // lblFaxNo
            // 
            this.lblFaxNo.AutoSize = true;
            this.lblFaxNo.Location = new System.Drawing.Point(394, 193);
            this.lblFaxNo.Name = "lblFaxNo";
            this.lblFaxNo.Size = new System.Drawing.Size(0, 13);
            this.lblFaxNo.TabIndex = 26;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(394, 238);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(0, 13);
            this.lblEposta.TabIndex = 27;
            // 
            // lblYetkiliKisi
            // 
            this.lblYetkiliKisi.AutoSize = true;
            this.lblYetkiliKisi.Location = new System.Drawing.Point(394, 279);
            this.lblYetkiliKisi.Name = "lblYetkiliKisi";
            this.lblYetkiliKisi.Size = new System.Drawing.Size(0, 13);
            this.lblYetkiliKisi.TabIndex = 28;
            // 
            // dgvSirketler
            // 
            this.dgvSirketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSirketler.Location = new System.Drawing.Point(12, 53);
            this.dgvSirketler.Name = "dgvSirketler";
            this.dgvSirketler.Size = new System.Drawing.Size(230, 239);
            this.dgvSirketler.TabIndex = 29;
            this.dgvSirketler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSirketler_CellContentClick);
            this.dgvSirketler.DoubleClick += new System.EventHandler(this.dgvSirketler_DoubleClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 330);
            this.Controls.Add(this.dgvSirketler);
            this.Controls.Add(this.lblYetkiliKisi);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblFaxNo);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblSirketKodu);
            this.Controls.Add(this.lblSirketAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞİRKET BİLGİLERİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirketler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şirketBilgisiDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fİNANSALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderTakibiToolStripMenuItem;
        private System.Windows.Forms.Label lblSirketAdi;
        private System.Windows.Forms.Label lblSirketKodu;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblFaxNo;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblYetkiliKisi;
        private System.Windows.Forms.DataGridView dgvSirketler;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}