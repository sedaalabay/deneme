namespace Kar_Zarar_Takip_Sistemi
{
    partial class Form2
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
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.txtSirketKodu = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtFaxNo = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtYetkiliKisi = new System.Windows.Forms.TextBox();
            this.btnSirketKaydet = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şirket İsmi *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şirket Kodu *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası *";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fax Numarası";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.label5.Location = new System.Drawing.Point(33, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail Adresi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.label6.Location = new System.Drawing.Point(33, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yetkili Kişi *";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.BackColor = System.Drawing.SystemColors.Window;
            this.txtSirketAdi.Location = new System.Drawing.Point(145, 34);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(198, 20);
            this.txtSirketAdi.TabIndex = 6;
            this.txtSirketAdi.TextChanged += new System.EventHandler(this.txtSirketAdi_TextChanged);
            // 
            // txtSirketKodu
            // 
            this.txtSirketKodu.Location = new System.Drawing.Point(145, 69);
            this.txtSirketKodu.Name = "txtSirketKodu";
            this.txtSirketKodu.Size = new System.Drawing.Size(198, 20);
            this.txtSirketKodu.TabIndex = 7;
            this.txtSirketKodu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(145, 110);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(198, 20);
            this.txtTelNo.TabIndex = 8;
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.Location = new System.Drawing.Point(145, 148);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(198, 20);
            this.txtFaxNo.TabIndex = 9;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(145, 186);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(198, 20);
            this.txtEposta.TabIndex = 10;
            this.txtEposta.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtYetkiliKisi
            // 
            this.txtYetkiliKisi.Location = new System.Drawing.Point(145, 227);
            this.txtYetkiliKisi.Name = "txtYetkiliKisi";
            this.txtYetkiliKisi.Size = new System.Drawing.Size(198, 20);
            this.txtYetkiliKisi.TabIndex = 11;
            this.txtYetkiliKisi.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnSirketKaydet
            // 
            this.btnSirketKaydet.BackColor = System.Drawing.SystemColors.Info;
            this.btnSirketKaydet.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketKaydet.Image = global::Kar_Zarar_Takip_Sistemi.Properties.Resources.Save_as_Filled_25;
            this.btnSirketKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSirketKaydet.Location = new System.Drawing.Point(36, 281);
            this.btnSirketKaydet.Name = "btnSirketKaydet";
            this.btnSirketKaydet.Size = new System.Drawing.Size(95, 34);
            this.btnSirketKaydet.TabIndex = 12;
            this.btnSirketKaydet.Text = "KAYDET";
            this.btnSirketKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSirketKaydet.UseVisualStyleBackColor = false;
            this.btnSirketKaydet.Click += new System.EventHandler(this.btnSirketKaydet_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::Kar_Zarar_Takip_Sistemi.Properties.Resources.Cancel_25;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(248, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 27;
            this.button3.Text = "ÇIKIŞ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 338);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSirketKaydet);
            this.Controls.Add(this.txtYetkiliKisi);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtFaxNo);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtSirketKodu);
            this.Controls.Add(this.txtSirketAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ ŞİRKET KAYDI";
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
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.TextBox txtSirketKodu;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtFaxNo;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtYetkiliKisi;
        private System.Windows.Forms.Button btnSirketKaydet;
        private System.Windows.Forms.Button button3;
    }
}