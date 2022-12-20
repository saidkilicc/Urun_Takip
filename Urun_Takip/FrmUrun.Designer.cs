namespace Urun_Takip
{
    partial class FrmUrun
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NmrcStok = new System.Windows.Forms.NumericUpDown();
            this.TxtCmbKategori = new System.Windows.Forms.ComboBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSatisFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(759, 561);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(151, 280);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(155, 49);
            this.BtnListele.TabIndex = 7;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NmrcStok);
            this.groupBox2.Controls.Add(this.TxtCmbKategori);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtUrunAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtSatisFiyat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtAlisFiyat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.TxtUrunId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(777, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 561);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // NmrcStok
            // 
            this.NmrcStok.Location = new System.Drawing.Point(155, 125);
            this.NmrcStok.Name = "NmrcStok";
            this.NmrcStok.Size = new System.Drawing.Size(151, 22);
            this.NmrcStok.TabIndex = 3;
            // 
            // TxtCmbKategori
            // 
            this.TxtCmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCmbKategori.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCmbKategori.FormattingEnabled = true;
            this.TxtCmbKategori.Location = new System.Drawing.Point(155, 236);
            this.TxtCmbKategori.Name = "TxtCmbKategori";
            this.TxtCmbKategori.Size = new System.Drawing.Size(151, 24);
            this.TxtCmbKategori.TabIndex = 6;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(151, 445);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(155, 49);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(151, 390);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(155, 49);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(151, 335);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(155, 49);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kategori :";
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(155, 88);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(151, 22);
            this.TxtUrunAdi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Adı :";
            // 
            // TxtSatisFiyat
            // 
            this.TxtSatisFiyat.Location = new System.Drawing.Point(155, 200);
            this.TxtSatisFiyat.Name = "TxtSatisFiyat";
            this.TxtSatisFiyat.Size = new System.Drawing.Size(151, 22);
            this.TxtSatisFiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stok :";
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.Location = new System.Drawing.Point(155, 162);
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            this.TxtAlisFiyat.Size = new System.Drawing.Size(151, 22);
            this.TxtAlisFiyat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Satış Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alış Fiyatı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 3;
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(155, 51);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(151, 22);
            this.TxtUrunId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün ID :";
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FrmUrun";
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSatisFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAlisFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NmrcStok;
        private System.Windows.Forms.ComboBox TxtCmbKategori;
    }
}