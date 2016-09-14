namespace Kar_Zarar_Takip_Sistemi
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sirketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kar_zararDataSet = new Kar_Zarar_Takip_Sistemi.kar_zararDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kar_zararDataSet2 = new Kar_Zarar_Takip_Sistemi.kar_zararDataSet2();
            this.gelirGiderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gelirGiderTableAdapter = new Kar_Zarar_Takip_Sistemi.kar_zararDataSet2TableAdapters.GelirGiderTableAdapter();
            this.kar_zararDataSet1 = new Kar_Zarar_Takip_Sistemi.kar_zararDataSet1();
            this.gelirGiderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gelirGiderTableAdapter1 = new Kar_Zarar_Takip_Sistemi.kar_zararDataSet1TableAdapters.GelirGiderTableAdapter();
            this.sirketTableAdapter = new Kar_Zarar_Takip_Sistemi.kar_zararDataSetTableAdapters.SirketTableAdapter();
            this.sirketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sirketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sirketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şirket Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sirketBindingSource;
            this.comboBox1.DisplayMember = "isim";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 2;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::Kar_Zarar_Takip_Sistemi.Properties.Resources.Cancel_25;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(316, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "ÇIKIŞ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 279);
            this.dataGridView1.TabIndex = 30;
            // 
            // kar_zararDataSet2
            // 
            this.kar_zararDataSet2.DataSetName = "kar_zararDataSet2";
            this.kar_zararDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gelirGiderBindingSource
            // 
            this.gelirGiderBindingSource.DataMember = "GelirGider";
            this.gelirGiderBindingSource.DataSource = this.kar_zararDataSet2;
            // 
            // gelirGiderTableAdapter
            // 
            this.gelirGiderTableAdapter.ClearBeforeFill = true;
            // 
            // kar_zararDataSet1
            // 
            this.kar_zararDataSet1.DataSetName = "kar_zararDataSet1";
            this.kar_zararDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gelirGiderBindingSource1
            // 
            this.gelirGiderBindingSource1.DataMember = "GelirGider";
            this.gelirGiderBindingSource1.DataSource = this.kar_zararDataSet1;
            // 
            // gelirGiderTableAdapter1
            // 
            this.gelirGiderTableAdapter1.ClearBeforeFill = true;
            // 
            // sirketTableAdapter
            // 
            this.sirketTableAdapter.ClearBeforeFill = true;
            // 
            // sirketBindingSource1
            // 
            this.sirketBindingSource1.DataMember = "Sirket";
            this.sirketBindingSource1.DataSource = this.kar_zararDataSet;
            // 
            // sirketBindingSource2
            // 
            this.sirketBindingSource2.DataMember = "Sirket";
            this.sirketBindingSource2.DataSource = this.kar_zararDataSet;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form6";
            this.Text = "GELİR GİDER ANALİZİ";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sirketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar_zararDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kar_zararDataSet2 kar_zararDataSet2;
        private System.Windows.Forms.BindingSource gelirGiderBindingSource;
        private kar_zararDataSet2TableAdapters.GelirGiderTableAdapter gelirGiderTableAdapter;
        private kar_zararDataSet1 kar_zararDataSet1;
        private System.Windows.Forms.BindingSource gelirGiderBindingSource1;
        private kar_zararDataSet1TableAdapters.GelirGiderTableAdapter gelirGiderTableAdapter1;
        private kar_zararDataSet kar_zararDataSet;
        private System.Windows.Forms.BindingSource sirketBindingSource;
        private kar_zararDataSetTableAdapters.SirketTableAdapter sirketTableAdapter;
        private System.Windows.Forms.BindingSource sirketBindingSource1;
        private System.Windows.Forms.BindingSource sirketBindingSource2;
    }
}