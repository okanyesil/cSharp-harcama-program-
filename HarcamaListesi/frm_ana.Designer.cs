namespace HarcamaListesi
{
    partial class frm_ana
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.btn_istatistik = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_harcama = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.tblaylikHarcamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.harcamalarDataSet = new HarcamaListesi.harcamalarDataSet();
            this.tbl_aylikHarcamaTableAdapter = new HarcamaListesi.harcamalarDataSetTableAdapters.tbl_aylikHarcamaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.btn_cikisYap = new System.Windows.Forms.Button();
            this.harcamalarDataSet1 = new HarcamaListesi.harcamalarDataSet1();
            this.tblaylikHarcamaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_aylikHarcamaTableAdapter1 = new HarcamaListesi.harcamalarDataSet1TableAdapters.tbl_aylikHarcamaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aylikGelirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikFaturasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suFaturasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazFaturasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kredikartiEkstreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_gelir = new System.Windows.Forms.TextBox();
            this.txt_elektrik = new System.Windows.Forms.TextBox();
            this.txt_su = new System.Windows.Forms.TextBox();
            this.txt_gaz = new System.Windows.Forms.TextBox();
            this.txt_kart = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblaylikHarcamaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcamalarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcamalarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblaylikHarcamaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_grafik);
            this.groupBox1.Controls.Add(this.btn_istatistik);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_harcama);
            this.groupBox1.Controls.Add(this.btn_listele);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 521);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btn_grafik
            // 
            this.btn_grafik.Location = new System.Drawing.Point(6, 366);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(231, 57);
            this.btn_grafik.TabIndex = 7;
            this.btn_grafik.Text = "Grafikler";
            this.btn_grafik.UseVisualStyleBackColor = true;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.Location = new System.Drawing.Point(6, 297);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(231, 57);
            this.btn_istatistik.TabIndex = 6;
            this.btn_istatistik.Text = "İstatistik";
            this.btn_istatistik.UseVisualStyleBackColor = true;
            this.btn_istatistik.Click += new System.EventHandler(this.btn_istatistik_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(6, 228);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(231, 57);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Harcama Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(6, 161);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(231, 57);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "Veri Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_harcama
            // 
            this.btn_harcama.Location = new System.Drawing.Point(6, 98);
            this.btn_harcama.Name = "btn_harcama";
            this.btn_harcama.Size = new System.Drawing.Size(231, 57);
            this.btn_harcama.TabIndex = 3;
            this.btn_harcama.Text = "Harcama Gir";
            this.btn_harcama.UseVisualStyleBackColor = true;
            this.btn_harcama.Click += new System.EventHandler(this.btn_harcama_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(6, 35);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(231, 57);
            this.btn_listele.TabIndex = 2;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // tblaylikHarcamaBindingSource
            // 
            this.tblaylikHarcamaBindingSource.DataMember = "tbl_aylikHarcama";
            this.tblaylikHarcamaBindingSource.DataSource = this.harcamalarDataSet;
            // 
            // harcamalarDataSet
            // 
            this.harcamalarDataSet.DataSetName = "harcamalarDataSet";
            this.harcamalarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_aylikHarcamaTableAdapter
            // 
            this.tbl_aylikHarcamaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoşgeldiniz,Sayın";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(652, 12);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(31, 29);
            this.lbl_isim.TabIndex = 3;
            this.lbl_isim.Text = "...";
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.Location = new System.Drawing.Point(1155, 12);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(123, 57);
            this.btn_cikisYap.TabIndex = 8;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.UseVisualStyleBackColor = true;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // harcamalarDataSet1
            // 
            this.harcamalarDataSet1.DataSetName = "harcamalarDataSet1";
            this.harcamalarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblaylikHarcamaBindingSource1
            // 
            this.tblaylikHarcamaBindingSource1.DataMember = "tbl_aylikHarcama";
            this.tblaylikHarcamaBindingSource1.DataSource = this.harcamalarDataSet1;
            // 
            // tbl_aylikHarcamaTableAdapter1
            // 
            this.tbl_aylikHarcamaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.aylikGelirDataGridViewTextBoxColumn,
            this.elektrikFaturasiDataGridViewTextBoxColumn,
            this.suFaturasiDataGridViewTextBoxColumn,
            this.dogalgazFaturasiDataGridViewTextBoxColumn,
            this.kredikartiEkstreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblaylikHarcamaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(261, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 301);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // aylikGelirDataGridViewTextBoxColumn
            // 
            this.aylikGelirDataGridViewTextBoxColumn.DataPropertyName = "aylikGelir";
            this.aylikGelirDataGridViewTextBoxColumn.HeaderText = "aylikGelir";
            this.aylikGelirDataGridViewTextBoxColumn.Name = "aylikGelirDataGridViewTextBoxColumn";
            // 
            // elektrikFaturasiDataGridViewTextBoxColumn
            // 
            this.elektrikFaturasiDataGridViewTextBoxColumn.DataPropertyName = "elektrikFaturasi";
            this.elektrikFaturasiDataGridViewTextBoxColumn.HeaderText = "elektrikFaturasi";
            this.elektrikFaturasiDataGridViewTextBoxColumn.Name = "elektrikFaturasiDataGridViewTextBoxColumn";
            // 
            // suFaturasiDataGridViewTextBoxColumn
            // 
            this.suFaturasiDataGridViewTextBoxColumn.DataPropertyName = "suFaturasi";
            this.suFaturasiDataGridViewTextBoxColumn.HeaderText = "suFaturasi";
            this.suFaturasiDataGridViewTextBoxColumn.Name = "suFaturasiDataGridViewTextBoxColumn";
            // 
            // dogalgazFaturasiDataGridViewTextBoxColumn
            // 
            this.dogalgazFaturasiDataGridViewTextBoxColumn.DataPropertyName = "dogalgazFaturasi";
            this.dogalgazFaturasiDataGridViewTextBoxColumn.HeaderText = "dogalgazFaturasi";
            this.dogalgazFaturasiDataGridViewTextBoxColumn.Name = "dogalgazFaturasiDataGridViewTextBoxColumn";
            // 
            // kredikartiEkstreDataGridViewTextBoxColumn
            // 
            this.kredikartiEkstreDataGridViewTextBoxColumn.DataPropertyName = "kredikartiEkstre";
            this.kredikartiEkstreDataGridViewTextBoxColumn.HeaderText = "kredikartiEkstre";
            this.kredikartiEkstreDataGridViewTextBoxColumn.Name = "kredikartiEkstreDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1113, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Aktif kullanıcılar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(1126, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 312);
            this.listBox1.TabIndex = 11;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(311, 399);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(56, 36);
            this.txt_id.TabIndex = 12;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(390, 399);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 36);
            this.txt_ad.TabIndex = 13;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(496, 399);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 36);
            this.txt_soyad.TabIndex = 14;
            // 
            // txt_gelir
            // 
            this.txt_gelir.Location = new System.Drawing.Point(613, 399);
            this.txt_gelir.Name = "txt_gelir";
            this.txt_gelir.Size = new System.Drawing.Size(70, 36);
            this.txt_gelir.TabIndex = 15;
            // 
            // txt_elektrik
            // 
            this.txt_elektrik.Location = new System.Drawing.Point(727, 399);
            this.txt_elektrik.Name = "txt_elektrik";
            this.txt_elektrik.Size = new System.Drawing.Size(70, 36);
            this.txt_elektrik.TabIndex = 16;
            // 
            // txt_su
            // 
            this.txt_su.Location = new System.Drawing.Point(826, 399);
            this.txt_su.Name = "txt_su";
            this.txt_su.Size = new System.Drawing.Size(70, 36);
            this.txt_su.TabIndex = 17;
            // 
            // txt_gaz
            // 
            this.txt_gaz.Location = new System.Drawing.Point(912, 399);
            this.txt_gaz.Name = "txt_gaz";
            this.txt_gaz.Size = new System.Drawing.Size(70, 36);
            this.txt_gaz.TabIndex = 18;
            // 
            // txt_kart
            // 
            this.txt_kart.Location = new System.Drawing.Point(1017, 399);
            this.txt_kart.Name = "txt_kart";
            this.txt_kart.Size = new System.Drawing.Size(70, 36);
            this.txt_kart.TabIndex = 19;
            // 
            // frm_ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1298, 558);
            this.Controls.Add(this.txt_kart);
            this.Controls.Add(this.txt_gaz);
            this.Controls.Add(this.txt_su);
            this.Controls.Add(this.txt_elektrik);
            this.Controls.Add(this.txt_gelir);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ana";
            this.Text = "İşlemler";
            this.Load += new System.EventHandler(this.frm_ana_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblaylikHarcamaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcamalarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcamalarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblaylikHarcamaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private harcamalarDataSet harcamalarDataSet;
        private System.Windows.Forms.BindingSource tblaylikHarcamaBindingSource;
        private harcamalarDataSetTableAdapters.tbl_aylikHarcamaTableAdapter tbl_aylikHarcamaTableAdapter;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.Button btn_istatistik;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_harcama;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Button btn_cikisYap;
        private harcamalarDataSet1 harcamalarDataSet1;
        private System.Windows.Forms.BindingSource tblaylikHarcamaBindingSource1;
        private harcamalarDataSet1TableAdapters.tbl_aylikHarcamaTableAdapter tbl_aylikHarcamaTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aylikGelirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikFaturasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suFaturasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazFaturasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kredikartiEkstreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_gelir;
        private System.Windows.Forms.TextBox txt_elektrik;
        private System.Windows.Forms.TextBox txt_su;
        private System.Windows.Forms.TextBox txt_gaz;
        private System.Windows.Forms.TextBox txt_kart;
    }
}