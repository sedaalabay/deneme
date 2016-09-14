namespace Kar_Zarar_Takip_Sistemi
{
    partial class Form4
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sirketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kar_zararDataSet = new Kar_Zarar_Takip_Sistemi.kar_zararDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgelir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgider = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dTpdate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.btnonayla = new System.Windows.Forms.Button();
            this.sirketTableAdapter = new Kar_Zarar_Takip_Sistemi.kar_zararDataSetTableAdapters.SirketTableAdapter();
            this.dgvgelirgider = new System.Windows.Forms.DataGridView();
            this.kar_zararDataSet1 = new Kar_Zarar_Takip_Sistemi.kar_zararDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.sirketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgelirgider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sirketBindingSource;
            this.comboBox1.DisplayMember = "isim";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sirketBindingSource
            // 
            this.sirketBindingSource.DataMember = "Sirket";
            this.sirketBindingSource.DataSource = this.kar_zararDataSet;
            // 
            // kar_zararDataSet
            // 
            this.kar_zararDataSet.DataSetName = "kar_zararDataSet";
            this.kar_zararDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şirket Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "GELİR";
            // 
            // txtgelir
            // 
            this.txtgelir.Location = new System.Drawing.Point(152, 77);
            this.txtgelir.Name = "txtgelir";
            this.txtgelir.Size = new System.Drawing.Size(130, 20);
            this.txtgelir.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(62, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "GİDER";
            // 
            // txtgider
            // 
            this.txtgider.Location = new System.Drawing.Point(152, 118);
            this.txtgider.Name = "txtgider";
            this.txtgider.Size = new System.Drawing.Size(130, 20);
            this.txtgider.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(62, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "TARİH";
            // 
            // dTpdate
            // 
            this.dTpdate.Location = new System.Drawing.Point(152, 163);
            this.dTpdate.Name = "dTpdate";
            this.dTpdate.Size = new System.Drawing.Size(200, 20);
            this.dTpdate.TabIndex = 10;
            this.dTpdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::Kar_Zarar_Takip_Sistemi.Properties.Resources.Cancel_25;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(379, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 30;
            this.button3.Text = "ÇIKIŞ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnonayla
            // 
            this.btnonayla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnonayla.Image = global::Kar_Zarar_Takip_Sistemi.Properties.Resources.Check_File_20;
            this.btnonayla.Location = new System.Drawing.Point(377, 157);
            this.btnonayla.Name = "btnonayla";
            this.btnonayla.Size = new System.Drawing.Size(35, 28);
            this.btnonayla.TabIndex = 7;
            this.btnonayla.UseVisualStyleBackColor = false;
            this.btnonayla.Click += new System.EventHandler(this.btnonayla_Click);
            // 
            // sirketTableAdapter
            // 
            this.sirketTableAdapter.ClearBeforeFill = true;
            // 
            // dgvgelirgider
            // 
            this.dgvgelirgider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgelirgider.Location = new System.Drawing.Point(65, 214);
            this.dgvgelirgider.Name = "dgvgelirgider";
            this.dgvgelirgider.Size = new System.Drawing.Size(409, 191);
            this.dgvgelirgider.TabIndex = 33;
            this.dgvgelirgider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kar_zararDataSet1
            // 
            this.kar_zararDataSet1.DataSetName = "kar_zararDataSet1";
            this.kar_zararDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 490);
            this.Controls.Add(this.dgvgelirgider);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dTpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnonayla);
            this.Controls.Add(this.txtgider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgelir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form4";
            this.Text = "GELİR GİDER KAYDI";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sirketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgelirgider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgelir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgider;
        private System.Windows.Forms.Button btnonayla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTpdate;
        private System.Windows.Forms.Button button3;
        private kar_zararDataSet kar_zararDataSet;
        private System.Windows.Forms.BindingSource sirketBindingSource;
        private kar_zararDataSetTableAdapters.SirketTableAdapter sirketTableAdapter;
        private System.Windows.Forms.DataGridView dgvgelirgider;
        private kar_zararDataSet1 kar_zararDataSet1;
    }
}