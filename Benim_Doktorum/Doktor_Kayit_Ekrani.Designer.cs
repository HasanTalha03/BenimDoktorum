namespace Benim_Doktorum
{
    partial class Doktor_Kayit_Ekrani
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
            this.CmbSehir = new System.Windows.Forms.ComboBox();
            this.tblSehirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benimDoktorumDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benim_DoktorumDataSet = new Benim_Doktorum.Benim_DoktorumDataSet();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.Txte_posta = new System.Windows.Forms.TextBox();
            this.TxtYas = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbUzmanlik = new System.Windows.Forms.ComboBox();
            this.tblUzmanlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benim_DoktorumDataSet2 = new Benim_Doktorum.Benim_DoktorumDataSet2();
            this.CmbUniversite = new System.Windows.Forms.ComboBox();
            this.tblUniversiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benim_DoktorumDataSet1 = new Benim_Doktorum.Benim_DoktorumDataSet1();
            this.label12 = new System.Windows.Forms.Label();
            this.PcrResim = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbl_SehirTableAdapter = new Benim_Doktorum.Benim_DoktorumDataSetTableAdapters.Tbl_SehirTableAdapter();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbl_UniversiteTableAdapter = new Benim_Doktorum.Benim_DoktorumDataSet1TableAdapters.Tbl_UniversiteTableAdapter();
            this.tbl_UzmanlikTableAdapter = new Benim_Doktorum.Benim_DoktorumDataSet2TableAdapters.Tbl_UzmanlikTableAdapter();
            this.CmbHastane = new System.Windows.Forms.ComboBox();
            this.tblHastaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benimDoktorumDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benim_DoktorumDataSet5 = new Benim_Doktorum.Benim_DoktorumDataSet5();
            this.tbl_HastaneTableAdapter = new Benim_Doktorum.Benim_DoktorumDataSet5TableAdapters.Tbl_HastaneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblSehirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benimDoktorumDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUniversiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcrResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benimDoktorumDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbSehir
            // 
            this.CmbSehir.DataSource = this.tblSehirBindingSource;
            this.CmbSehir.DisplayMember = "sehir";
            this.CmbSehir.FormattingEnabled = true;
            this.CmbSehir.Location = new System.Drawing.Point(566, 261);
            this.CmbSehir.Name = "CmbSehir";
            this.CmbSehir.Size = new System.Drawing.Size(179, 24);
            this.CmbSehir.TabIndex = 37;
            this.CmbSehir.ValueMember = "id";
            // 
            // tblSehirBindingSource
            // 
            this.tblSehirBindingSource.DataMember = "Tbl_Sehir";
            this.tblSehirBindingSource.DataSource = this.benimDoktorumDataSetBindingSource;
            // 
            // benimDoktorumDataSetBindingSource
            // 
            this.benimDoktorumDataSetBindingSource.DataSource = this.benim_DoktorumDataSet;
            this.benimDoktorumDataSetBindingSource.Position = 0;
            // 
            // benim_DoktorumDataSet
            // 
            this.benim_DoktorumDataSet.DataSetName = "Benim_DoktorumDataSet";
            this.benim_DoktorumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(199, 223);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 20);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kadın";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(130, 223);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 20);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Erkek";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(295, 477);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(123, 42);
            this.BtnGeri.TabIndex = 34;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(130, 346);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(100, 22);
            this.TxtSifre.TabIndex = 33;
            // 
            // Txte_posta
            // 
            this.Txte_posta.Location = new System.Drawing.Point(130, 307);
            this.Txte_posta.Name = "Txte_posta";
            this.Txte_posta.Size = new System.Drawing.Size(100, 22);
            this.Txte_posta.TabIndex = 32;
            // 
            // TxtYas
            // 
            this.TxtYas.Location = new System.Drawing.Point(130, 189);
            this.TxtYas.Name = "TxtYas";
            this.TxtYas.Size = new System.Drawing.Size(100, 22);
            this.TxtYas.TabIndex = 30;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(130, 151);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyad.TabIndex = 29;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(130, 116);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 22);
            this.TxtAd.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "e_posta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Yaş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soy İsim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "İsim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Uzmanlık/Uzmanlıklar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Mezun Olunan Üniversite/Üniversiteler";
            // 
            // CmbUzmanlik
            // 
            this.CmbUzmanlik.DataSource = this.tblUzmanlikBindingSource;
            this.CmbUzmanlik.DisplayMember = "uzmanlik";
            this.CmbUzmanlik.FormattingEnabled = true;
            this.CmbUzmanlik.Location = new System.Drawing.Point(566, 289);
            this.CmbUzmanlik.Name = "CmbUzmanlik";
            this.CmbUzmanlik.Size = new System.Drawing.Size(179, 24);
            this.CmbUzmanlik.TabIndex = 40;
            this.CmbUzmanlik.ValueMember = "id";
            // 
            // tblUzmanlikBindingSource
            // 
            this.tblUzmanlikBindingSource.DataMember = "Tbl_Uzmanlik";
            this.tblUzmanlikBindingSource.DataSource = this.benim_DoktorumDataSet2;
            // 
            // benim_DoktorumDataSet2
            // 
            this.benim_DoktorumDataSet2.DataSetName = "Benim_DoktorumDataSet2";
            this.benim_DoktorumDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmbUniversite
            // 
            this.CmbUniversite.DataSource = this.tblUniversiteBindingSource;
            this.CmbUniversite.DisplayMember = "universite_adi";
            this.CmbUniversite.FormattingEnabled = true;
            this.CmbUniversite.Location = new System.Drawing.Point(566, 319);
            this.CmbUniversite.Name = "CmbUniversite";
            this.CmbUniversite.Size = new System.Drawing.Size(179, 24);
            this.CmbUniversite.TabIndex = 41;
            this.CmbUniversite.ValueMember = "id";
            // 
            // tblUniversiteBindingSource
            // 
            this.tblUniversiteBindingSource.DataMember = "Tbl_Universite";
            this.tblUniversiteBindingSource.DataSource = this.benim_DoktorumDataSet1;
            // 
            // benim_DoktorumDataSet1
            // 
            this.benim_DoktorumDataSet1.DataSetName = "Benim_DoktorumDataSet1";
            this.benim_DoktorumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Hastane Adı:";
            // 
            // PcrResim
            // 
            this.PcrResim.Location = new System.Drawing.Point(566, 74);
            this.PcrResim.Name = "PcrResim";
            this.PcrResim.Size = new System.Drawing.Size(157, 131);
            this.PcrResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcrResim.TabIndex = 46;
            this.PcrResim.TabStop = false;
            this.PcrResim.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(60, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(298, 38);
            this.label14.TabIndex = 48;
            this.label14.Text = "Doktor Kayıt Ekranı";
            // 
            // tbl_SehirTableAdapter
            // 
            this.tbl_SehirTableAdapter.ClearBeforeFill = true;
            // 
            // BtnKayit
            // 
            this.BtnKayit.Location = new System.Drawing.Point(295, 429);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(123, 42);
            this.BtnKayit.TabIndex = 51;
            this.BtnKayit.Text = "Kayıt Ol";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(130, 261);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(100, 22);
            this.MskTel.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "radiobutonkontrol";
            this.label15.Visible = false;
            // 
            // tbl_UniversiteTableAdapter
            // 
            this.tbl_UniversiteTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_UzmanlikTableAdapter
            // 
            this.tbl_UzmanlikTableAdapter.ClearBeforeFill = true;
            // 
            // CmbHastane
            // 
            this.CmbHastane.DataSource = this.tblHastaneBindingSource;
            this.CmbHastane.DisplayMember = "Hastane_adi";
            this.CmbHastane.FormattingEnabled = true;
            this.CmbHastane.Location = new System.Drawing.Point(566, 349);
            this.CmbHastane.Name = "CmbHastane";
            this.CmbHastane.Size = new System.Drawing.Size(179, 24);
            this.CmbHastane.TabIndex = 54;
            this.CmbHastane.ValueMember = "id";
            // 
            // tblHastaneBindingSource
            // 
            this.tblHastaneBindingSource.DataMember = "Tbl_Hastane";
            this.tblHastaneBindingSource.DataSource = this.benimDoktorumDataSet5BindingSource;
            // 
            // benimDoktorumDataSet5BindingSource
            // 
            this.benimDoktorumDataSet5BindingSource.DataSource = this.benim_DoktorumDataSet5;
            this.benimDoktorumDataSet5BindingSource.Position = 0;
            // 
            // benim_DoktorumDataSet5
            // 
            this.benim_DoktorumDataSet5.DataSetName = "Benim_DoktorumDataSet5";
            this.benim_DoktorumDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_HastaneTableAdapter
            // 
            this.tbl_HastaneTableAdapter.ClearBeforeFill = true;
            // 
            // Doktor_Kayit_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.CmbHastane);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PcrResim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CmbUniversite);
            this.Controls.Add(this.CmbUzmanlik);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbSehir);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.Txte_posta);
            this.Controls.Add(this.TxtYas);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Doktor_Kayit_Ekrani";
            this.Text = "Doktor_Kayit_Ekrani";
            this.Load += new System.EventHandler(this.Doktor_Kayit_Ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSehirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benimDoktorumDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUniversiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcrResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benimDoktorumDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbSehir;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox Txte_posta;
        private System.Windows.Forms.TextBox TxtYas;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbUzmanlik;
        private System.Windows.Forms.ComboBox CmbUniversite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox PcrResim;
        private System.Windows.Forms.Label label14;
        private Benim_DoktorumDataSet benim_DoktorumDataSet;
        private System.Windows.Forms.BindingSource benimDoktorumDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblSehirBindingSource;
        private Benim_DoktorumDataSetTableAdapters.Tbl_SehirTableAdapter tbl_SehirTableAdapter;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.Label label15;
        private Benim_DoktorumDataSet1 benim_DoktorumDataSet1;
        private System.Windows.Forms.BindingSource tblUniversiteBindingSource;
        private Benim_DoktorumDataSet1TableAdapters.Tbl_UniversiteTableAdapter tbl_UniversiteTableAdapter;
        private Benim_DoktorumDataSet2 benim_DoktorumDataSet2;
        private System.Windows.Forms.BindingSource tblUzmanlikBindingSource;
        private Benim_DoktorumDataSet2TableAdapters.Tbl_UzmanlikTableAdapter tbl_UzmanlikTableAdapter;
        private System.Windows.Forms.ComboBox CmbHastane;
        private Benim_DoktorumDataSet5 benim_DoktorumDataSet5;
        private System.Windows.Forms.BindingSource benimDoktorumDataSet5BindingSource;
        private System.Windows.Forms.BindingSource tblHastaneBindingSource;
        private Benim_DoktorumDataSet5TableAdapters.Tbl_HastaneTableAdapter tbl_HastaneTableAdapter;
    }
}