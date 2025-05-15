namespace Benim_Doktorum
{
    partial class Kullanici_Girisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_Girisi));
            this.BtnGeri = new System.Windows.Forms.Button();
            this.LblHosgeldiniz = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblSehir = new System.Windows.Forms.Label();
            this.Lble_posta = new System.Windows.Forms.Label();
            this.LblSigorta = new System.Windows.Forms.Label();
            this.LblYas = new System.Windows.Forms.Label();
            this.LblCinsiyet = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBilgiGncelle = new System.Windows.Forms.Button();
            this.BtnRandevu = new System.Windows.Forms.Button();
            this.BtnRandevuGrntle = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtYas = new System.Windows.Forms.TextBox();
            this.Txte_posta = new System.Windows.Forms.TextBox();
            this.CmbSehir = new System.Windows.Forms.ComboBox();
            this.tblSehirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benim_DoktorumDataSet = new Benim_Doktorum.Benim_DoktorumDataSet();
            this.CmbSigorta = new System.Windows.Forms.ComboBox();
            this.tblsigortaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SehirTableAdapter = new Benim_Doktorum.Benim_DoktorumDataSetTableAdapters.Tbl_SehirTableAdapter();
            this.tbl_sigortaTableAdapter = new Benim_Doktorum.Benim_DoktorumDataSetTableAdapters.Tbl_sigortaTableAdapter();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.LblSifre = new System.Windows.Forms.Label();
            this.BtnBilgileriKyt = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSehirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigortaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(432, 475);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(171, 34);
            this.BtnGeri.TabIndex = 7;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // LblHosgeldiniz
            // 
            this.LblHosgeldiniz.AutoSize = true;
            this.LblHosgeldiniz.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHosgeldiniz.Location = new System.Drawing.Point(53, 22);
            this.LblHosgeldiniz.Name = "LblHosgeldiniz";
            this.LblHosgeldiniz.Size = new System.Drawing.Size(100, 40);
            this.LblHosgeldiniz.TabIndex = 8;
            this.LblHosgeldiniz.Text = "label0";
            this.LblHosgeldiniz.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyad.Location = new System.Drawing.Point(56, 159);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(73, 24);
            this.LblSoyad.TabIndex = 9;
            this.LblSoyad.Text = "Soyad..";
            // 
            // LblSehir
            // 
            this.LblSehir.AutoSize = true;
            this.LblSehir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSehir.Location = new System.Drawing.Point(438, 159);
            this.LblSehir.Name = "LblSehir";
            this.LblSehir.Size = new System.Drawing.Size(63, 24);
            this.LblSehir.TabIndex = 10;
            this.LblSehir.Text = "Sehir..";
            this.LblSehir.Click += new System.EventHandler(this.LblSehir_Click);
            // 
            // Lble_posta
            // 
            this.Lble_posta.AutoSize = true;
            this.Lble_posta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lble_posta.Location = new System.Drawing.Point(56, 286);
            this.Lble_posta.Name = "Lble_posta";
            this.Lble_posta.Size = new System.Drawing.Size(87, 24);
            this.Lble_posta.TabIndex = 11;
            this.Lble_posta.Text = "e_posta..";
            // 
            // LblSigorta
            // 
            this.LblSigorta.AutoSize = true;
            this.LblSigorta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSigorta.Location = new System.Drawing.Point(419, 210);
            this.LblSigorta.Name = "LblSigorta";
            this.LblSigorta.Size = new System.Drawing.Size(82, 24);
            this.LblSigorta.TabIndex = 12;
            this.LblSigorta.Text = "Sigorta..";
            // 
            // LblYas
            // 
            this.LblYas.AutoSize = true;
            this.LblYas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYas.Location = new System.Drawing.Point(56, 210);
            this.LblYas.Name = "LblYas";
            this.LblYas.Size = new System.Drawing.Size(48, 24);
            this.LblYas.TabIndex = 13;
            this.LblYas.Text = "yas..";
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.AutoSize = true;
            this.LblCinsiyet.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCinsiyet.Location = new System.Drawing.Point(423, 106);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(88, 24);
            this.LblCinsiyet.TabIndex = 14;
            this.LblCinsiyet.Text = "Cinsiyet..";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTel.Location = new System.Drawing.Point(56, 250);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(42, 24);
            this.LblTel.TabIndex = 15;
            this.LblTel.Text = "tel..";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Location = new System.Drawing.Point(60, 108);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(34, 24);
            this.LblAd.TabIndex = 16;
            this.LblAd.Text = "Ad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(769, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBilgiGncelle
            // 
            this.BtnBilgiGncelle.Location = new System.Drawing.Point(255, 472);
            this.BtnBilgiGncelle.Name = "BtnBilgiGncelle";
            this.BtnBilgiGncelle.Size = new System.Drawing.Size(171, 37);
            this.BtnBilgiGncelle.TabIndex = 18;
            this.BtnBilgiGncelle.Text = "Bilgilerimi Güncelle";
            this.BtnBilgiGncelle.UseVisualStyleBackColor = true;
            this.BtnBilgiGncelle.Click += new System.EventHandler(this.BtnBilgiGncelle_Click);
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.Location = new System.Drawing.Point(255, 432);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(171, 34);
            this.BtnRandevu.TabIndex = 19;
            this.BtnRandevu.Text = "Randevu Al";
            this.BtnRandevu.UseVisualStyleBackColor = true;
            this.BtnRandevu.Click += new System.EventHandler(this.BtnRandevu_Click);
            // 
            // BtnRandevuGrntle
            // 
            this.BtnRandevuGrntle.Location = new System.Drawing.Point(432, 432);
            this.BtnRandevuGrntle.Name = "BtnRandevuGrntle";
            this.BtnRandevuGrntle.Size = new System.Drawing.Size(171, 34);
            this.BtnRandevuGrntle.TabIndex = 20;
            this.BtnRandevuGrntle.Text = "Randevularım";
            this.BtnRandevuGrntle.UseVisualStyleBackColor = true;
            this.BtnRandevuGrntle.Click += new System.EventHandler(this.BtnRandevuGrntle_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(240, 109);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 22);
            this.TxtAd.TabIndex = 21;
            this.TxtAd.Visible = false;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(240, 162);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyad.TabIndex = 22;
            this.TxtSoyad.Visible = false;
            // 
            // TxtYas
            // 
            this.TxtYas.Location = new System.Drawing.Point(240, 213);
            this.TxtYas.Name = "TxtYas";
            this.TxtYas.Size = new System.Drawing.Size(100, 22);
            this.TxtYas.TabIndex = 23;
            this.TxtYas.Visible = false;
            // 
            // Txte_posta
            // 
            this.Txte_posta.Location = new System.Drawing.Point(240, 289);
            this.Txte_posta.Name = "Txte_posta";
            this.Txte_posta.Size = new System.Drawing.Size(100, 22);
            this.Txte_posta.TabIndex = 25;
            this.Txte_posta.Visible = false;
            // 
            // CmbSehir
            // 
            this.CmbSehir.DataSource = this.tblSehirBindingSource;
            this.CmbSehir.DisplayMember = "sehir";
            this.CmbSehir.FormattingEnabled = true;
            this.CmbSehir.Location = new System.Drawing.Point(543, 159);
            this.CmbSehir.Name = "CmbSehir";
            this.CmbSehir.Size = new System.Drawing.Size(121, 24);
            this.CmbSehir.TabIndex = 28;
            this.CmbSehir.ValueMember = "id";
            this.CmbSehir.Visible = false;
            // 
            // tblSehirBindingSource
            // 
            this.tblSehirBindingSource.DataMember = "Tbl_Sehir";
            this.tblSehirBindingSource.DataSource = this.benim_DoktorumDataSet;
            // 
            // benim_DoktorumDataSet
            // 
            this.benim_DoktorumDataSet.DataSetName = "Benim_DoktorumDataSet";
            this.benim_DoktorumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmbSigorta
            // 
            this.CmbSigorta.DataSource = this.tblsigortaBindingSource;
            this.CmbSigorta.DisplayMember = "sigorta_turu";
            this.CmbSigorta.FormattingEnabled = true;
            this.CmbSigorta.Location = new System.Drawing.Point(543, 210);
            this.CmbSigorta.Name = "CmbSigorta";
            this.CmbSigorta.Size = new System.Drawing.Size(121, 24);
            this.CmbSigorta.TabIndex = 29;
            this.CmbSigorta.ValueMember = "id";
            this.CmbSigorta.Visible = false;
            // 
            // tblsigortaBindingSource
            // 
            this.tblsigortaBindingSource.DataMember = "Tbl_sigorta";
            this.tblsigortaBindingSource.DataSource = this.benim_DoktorumDataSet;
            // 
            // tbl_SehirTableAdapter
            // 
            this.tbl_SehirTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_sigortaTableAdapter
            // 
            this.tbl_sigortaTableAdapter.ClearBeforeFill = true;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(240, 250);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(100, 22);
            this.MskTel.TabIndex = 30;
            this.MskTel.Visible = false;
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(56, 332);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(54, 24);
            this.LblSifre.TabIndex = 31;
            this.LblSifre.Text = "Şifre:";
            this.LblSifre.Visible = false;
            // 
            // BtnBilgileriKyt
            // 
            this.BtnBilgileriKyt.Location = new System.Drawing.Point(353, 392);
            this.BtnBilgileriKyt.Name = "BtnBilgileriKyt";
            this.BtnBilgileriKyt.Size = new System.Drawing.Size(171, 34);
            this.BtnBilgileriKyt.TabIndex = 32;
            this.BtnBilgileriKyt.Text = "Bilgileri Kaydet";
            this.BtnBilgileriKyt.UseVisualStyleBackColor = true;
            this.BtnBilgileriKyt.Visible = false;
            this.BtnBilgileriKyt.Click += new System.EventHandler(this.BtnBilgileriKyt_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(240, 333);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(100, 22);
            this.TxtSifre.TabIndex = 33;
            this.TxtSifre.Visible = false;
            // 
            // Kullanici_Girisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(985, 588);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.BtnBilgileriKyt);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.CmbSigorta);
            this.Controls.Add(this.CmbSehir);
            this.Controls.Add(this.Txte_posta);
            this.Controls.Add(this.TxtYas);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.BtnRandevuGrntle);
            this.Controls.Add(this.BtnRandevu);
            this.Controls.Add(this.BtnBilgiGncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.LblCinsiyet);
            this.Controls.Add(this.LblYas);
            this.Controls.Add(this.LblSigorta);
            this.Controls.Add(this.Lble_posta);
            this.Controls.Add(this.LblSehir);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblHosgeldiniz);
            this.Controls.Add(this.BtnGeri);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Kullanici_Girisi";
            this.Text = "Kullanici_Girisi";
            this.Load += new System.EventHandler(this.Kullanici_Girisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSehirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsigortaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label LblHosgeldiniz;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblSehir;
        private System.Windows.Forms.Label Lble_posta;
        private System.Windows.Forms.Label LblSigorta;
        private System.Windows.Forms.Label LblYas;
        private System.Windows.Forms.Label LblCinsiyet;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBilgiGncelle;
        private System.Windows.Forms.Button BtnRandevu;
        private System.Windows.Forms.Button BtnRandevuGrntle;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtYas;
        private System.Windows.Forms.TextBox Txte_posta;
        private System.Windows.Forms.ComboBox CmbSehir;
        private System.Windows.Forms.ComboBox CmbSigorta;
        private Benim_DoktorumDataSet benim_DoktorumDataSet;
        private System.Windows.Forms.BindingSource tblSehirBindingSource;
        private Benim_DoktorumDataSetTableAdapters.Tbl_SehirTableAdapter tbl_SehirTableAdapter;
        private System.Windows.Forms.BindingSource tblsigortaBindingSource;
        private Benim_DoktorumDataSetTableAdapters.Tbl_sigortaTableAdapter tbl_sigortaTableAdapter;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.Button BtnBilgileriKyt;
        private System.Windows.Forms.TextBox TxtSifre;
    }
}