namespace Benim_Doktorum
{
    partial class RandevuAl
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
            this.BtnGeri = new System.Windows.Forms.Button();
            this.LblHosGeldiniz = new System.Windows.Forms.Label();
            this.CmbUzmanlik = new System.Windows.Forms.ComboBox();
            this.benim_DoktorumDataSet71 = new Benim_Doktorum.Benim_DoktorumDataSet7();
            this.tblUzmanlikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.benimDoktorumDataSet101BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benim_DoktorumDataSet101 = new Benim_Doktorum.Benim_DoktorumDataSet10();
            this.tblUzmanlikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUzmanlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UzmanlikTableAdapter = new Benim_Doktorum.Benim_DoktorumDataSet7TableAdapters.Tbl_UzmanlikTableAdapter();
            this.LblBolum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LstDoktorlar = new System.Windows.Forms.ListBox();
            this.BtnRandevu = new System.Windows.Forms.Button();
            this.benim_DoktorumDataSet72 = new Benim_Doktorum.Benim_DoktorumDataSet7();
            this.tbl_UzmanlikTableAdapter1 = new Benim_Doktorum.Benim_DoktorumDataSet10TableAdapters.Tbl_UzmanlikTableAdapter();
            this.tblUzmanlikBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.DTP_Tarih = new System.Windows.Forms.DateTimePicker();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rd10 = new System.Windows.Forms.RadioButton();
            this.Rd11 = new System.Windows.Forms.RadioButton();
            this.Rd12 = new System.Windows.Forms.RadioButton();
            this.Rd13 = new System.Windows.Forms.RadioButton();
            this.Rd14 = new System.Windows.Forms.RadioButton();
            this.Rd15 = new System.Windows.Forms.RadioButton();
            this.Rd16 = new System.Windows.Forms.RadioButton();
            this.Rd17 = new System.Windows.Forms.RadioButton();
            this.LblSaat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benimDoktorumDataSet101BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(613, 242);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(129, 37);
            this.BtnGeri.TabIndex = 0;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblHosGeldiniz
            // 
            this.LblHosGeldiniz.AutoSize = true;
            this.LblHosGeldiniz.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHosGeldiniz.Location = new System.Drawing.Point(49, 36);
            this.LblHosGeldiniz.Name = "LblHosGeldiniz";
            this.LblHosGeldiniz.Size = new System.Drawing.Size(82, 40);
            this.LblHosGeldiniz.TabIndex = 1;
            this.LblHosGeldiniz.Text = "giriş ";
            // 
            // CmbUzmanlik
            // 
            this.CmbUzmanlik.DataSource = this.benim_DoktorumDataSet71;
            this.CmbUzmanlik.DisplayMember = "Tbl_Uzmanlik.uzmanlik";
            this.CmbUzmanlik.FormattingEnabled = true;
            this.CmbUzmanlik.Location = new System.Drawing.Point(420, 135);
            this.CmbUzmanlik.Name = "CmbUzmanlik";
            this.CmbUzmanlik.Size = new System.Drawing.Size(121, 24);
            this.CmbUzmanlik.TabIndex = 2;
            this.CmbUzmanlik.ValueMember = "id";
            this.CmbUzmanlik.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // benim_DoktorumDataSet71
            // 
            this.benim_DoktorumDataSet71.DataSetName = "Benim_DoktorumDataSet7";
            this.benim_DoktorumDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUzmanlikBindingSource2
            // 
            this.tblUzmanlikBindingSource2.DataMember = "Tbl_Uzmanlik";
            this.tblUzmanlikBindingSource2.DataSource = this.benimDoktorumDataSet101BindingSource;
            // 
            // benimDoktorumDataSet101BindingSource
            // 
            this.benimDoktorumDataSet101BindingSource.DataSource = this.benim_DoktorumDataSet101;
            this.benimDoktorumDataSet101BindingSource.Position = 0;
            // 
            // benim_DoktorumDataSet101
            // 
            this.benim_DoktorumDataSet101.DataSetName = "Benim_DoktorumDataSet10";
            this.benim_DoktorumDataSet101.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UzmanlikTableAdapter
            // 
            this.tbl_UzmanlikTableAdapter.ClearBeforeFill = true;
            // 
            // LblBolum
            // 
            this.LblBolum.AutoSize = true;
            this.LblBolum.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBolum.Location = new System.Drawing.Point(52, 135);
            this.LblBolum.Name = "LblBolum";
            this.LblBolum.Size = new System.Drawing.Size(329, 24);
            this.LblBolum.TabIndex = 3;
            this.LblBolum.Text = "Hangi bölüm için randevu alacaksınız: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Doktorları Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LstDoktorlar
            // 
            this.LstDoktorlar.FormattingEnabled = true;
            this.LstDoktorlar.HorizontalScrollbar = true;
            this.LstDoktorlar.ItemHeight = 16;
            this.LstDoktorlar.Location = new System.Drawing.Point(47, 353);
            this.LstDoktorlar.Name = "LstDoktorlar";
            this.LstDoktorlar.Size = new System.Drawing.Size(732, 228);
            this.LstDoktorlar.TabIndex = 9;
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.Location = new System.Drawing.Point(613, 190);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(129, 32);
            this.BtnRandevu.TabIndex = 10;
            this.BtnRandevu.Text = "Randevu Al";
            this.BtnRandevu.UseVisualStyleBackColor = true;
            this.BtnRandevu.Click += new System.EventHandler(this.BtnRandevu_Click);
            // 
            // benim_DoktorumDataSet72
            // 
            this.benim_DoktorumDataSet72.DataSetName = "Benim_DoktorumDataSet7";
            this.benim_DoktorumDataSet72.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UzmanlikTableAdapter1
            // 
            this.tbl_UzmanlikTableAdapter1.ClearBeforeFill = true;
            // 
            // tblUzmanlikBindingSource3
            // 
            this.tblUzmanlikBindingSource3.DataMember = "Tbl_Uzmanlik";
            this.tblUzmanlikBindingSource3.DataSource = this.benimDoktorumDataSet101BindingSource;
            // 
            // DTP_Tarih
            // 
            this.DTP_Tarih.Location = new System.Drawing.Point(341, 231);
            this.DTP_Tarih.Name = "DTP_Tarih";
            this.DTP_Tarih.Size = new System.Drawing.Size(200, 22);
            this.DTP_Tarih.TabIndex = 19;
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(420, 190);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(121, 24);
            this.CmbDoktor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Randevu almak istediğiniz doktoru seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tarih seçin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Randevu saati seçin:";
            // 
            // Rd10
            // 
            this.Rd10.AutoSize = true;
            this.Rd10.Location = new System.Drawing.Point(298, 277);
            this.Rd10.Name = "Rd10";
            this.Rd10.Size = new System.Drawing.Size(59, 20);
            this.Rd10.TabIndex = 24;
            this.Rd10.TabStop = true;
            this.Rd10.Text = "10.00";
            this.Rd10.UseVisualStyleBackColor = true;
            // 
            // Rd11
            // 
            this.Rd11.AutoSize = true;
            this.Rd11.Location = new System.Drawing.Point(363, 277);
            this.Rd11.Name = "Rd11";
            this.Rd11.Size = new System.Drawing.Size(59, 20);
            this.Rd11.TabIndex = 25;
            this.Rd11.TabStop = true;
            this.Rd11.Text = "11.00";
            this.Rd11.UseVisualStyleBackColor = true;
            // 
            // Rd12
            // 
            this.Rd12.AutoSize = true;
            this.Rd12.Location = new System.Drawing.Point(428, 277);
            this.Rd12.Name = "Rd12";
            this.Rd12.Size = new System.Drawing.Size(59, 20);
            this.Rd12.TabIndex = 26;
            this.Rd12.TabStop = true;
            this.Rd12.Text = "12.00";
            this.Rd12.UseVisualStyleBackColor = true;
            // 
            // Rd13
            // 
            this.Rd13.AutoSize = true;
            this.Rd13.Location = new System.Drawing.Point(493, 277);
            this.Rd13.Name = "Rd13";
            this.Rd13.Size = new System.Drawing.Size(59, 20);
            this.Rd13.TabIndex = 27;
            this.Rd13.TabStop = true;
            this.Rd13.Text = "13.00";
            this.Rd13.UseVisualStyleBackColor = true;
            // 
            // Rd14
            // 
            this.Rd14.AutoSize = true;
            this.Rd14.Location = new System.Drawing.Point(298, 303);
            this.Rd14.Name = "Rd14";
            this.Rd14.Size = new System.Drawing.Size(59, 20);
            this.Rd14.TabIndex = 28;
            this.Rd14.TabStop = true;
            this.Rd14.Text = "14.00";
            this.Rd14.UseVisualStyleBackColor = true;
            // 
            // Rd15
            // 
            this.Rd15.AutoSize = true;
            this.Rd15.Location = new System.Drawing.Point(363, 303);
            this.Rd15.Name = "Rd15";
            this.Rd15.Size = new System.Drawing.Size(59, 20);
            this.Rd15.TabIndex = 29;
            this.Rd15.TabStop = true;
            this.Rd15.Text = "15.00";
            this.Rd15.UseVisualStyleBackColor = true;
            // 
            // Rd16
            // 
            this.Rd16.AutoSize = true;
            this.Rd16.Location = new System.Drawing.Point(428, 303);
            this.Rd16.Name = "Rd16";
            this.Rd16.Size = new System.Drawing.Size(59, 20);
            this.Rd16.TabIndex = 30;
            this.Rd16.TabStop = true;
            this.Rd16.Text = "16.00";
            this.Rd16.UseVisualStyleBackColor = true;
            // 
            // Rd17
            // 
            this.Rd17.AutoSize = true;
            this.Rd17.Location = new System.Drawing.Point(493, 303);
            this.Rd17.Name = "Rd17";
            this.Rd17.Size = new System.Drawing.Size(59, 20);
            this.Rd17.TabIndex = 31;
            this.Rd17.TabStop = true;
            this.Rd17.Text = "17.00";
            this.Rd17.UseVisualStyleBackColor = true;
            // 
            // LblSaat
            // 
            this.LblSaat.AutoSize = true;
            this.LblSaat.Location = new System.Drawing.Point(796, 9);
            this.LblSaat.Name = "LblSaat";
            this.LblSaat.Size = new System.Drawing.Size(76, 16);
            this.LblSaat.TabIndex = 32;
            this.LblSaat.Text = "SaatKontrol";
            this.LblSaat.Visible = false;
            // 
            // RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(884, 593);
            this.Controls.Add(this.LblSaat);
            this.Controls.Add(this.Rd17);
            this.Controls.Add(this.Rd16);
            this.Controls.Add(this.Rd15);
            this.Controls.Add(this.Rd14);
            this.Controls.Add(this.Rd13);
            this.Controls.Add(this.Rd12);
            this.Controls.Add(this.Rd11);
            this.Controls.Add(this.Rd10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbDoktor);
            this.Controls.Add(this.DTP_Tarih);
            this.Controls.Add(this.BtnRandevu);
            this.Controls.Add(this.LstDoktorlar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblBolum);
            this.Controls.Add(this.CmbUzmanlik);
            this.Controls.Add(this.LblHosGeldiniz);
            this.Controls.Add(this.BtnGeri);
            this.Name = "RandevuAl";
            this.Text = "RandevuAl";
            this.Load += new System.EventHandler(this.RandevuAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benimDoktorumDataSet101BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUzmanlikBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label LblHosGeldiniz;
        private System.Windows.Forms.ComboBox CmbUzmanlik;
        private System.Windows.Forms.BindingSource tblUzmanlikBindingSource;
        private Benim_DoktorumDataSet7TableAdapters.Tbl_UzmanlikTableAdapter tbl_UzmanlikTableAdapter;
        private System.Windows.Forms.Label LblBolum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LstDoktorlar;
        private System.Windows.Forms.BindingSource tblUzmanlikBindingSource1;
        private System.Windows.Forms.Button BtnRandevu;
        private Benim_DoktorumDataSet10 benim_DoktorumDataSet101;
        private Benim_DoktorumDataSet7 benim_DoktorumDataSet71;
        private Benim_DoktorumDataSet7 benim_DoktorumDataSet72;
        private System.Windows.Forms.BindingSource benimDoktorumDataSet101BindingSource;
        private System.Windows.Forms.BindingSource tblUzmanlikBindingSource2;
        private Benim_DoktorumDataSet10TableAdapters.Tbl_UzmanlikTableAdapter tbl_UzmanlikTableAdapter1;
        private System.Windows.Forms.BindingSource tblUzmanlikBindingSource3;
        private System.Windows.Forms.DateTimePicker DTP_Tarih;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Rd10;
        private System.Windows.Forms.RadioButton Rd11;
        private System.Windows.Forms.RadioButton Rd12;
        private System.Windows.Forms.RadioButton Rd13;
        private System.Windows.Forms.RadioButton Rd14;
        private System.Windows.Forms.RadioButton Rd15;
        private System.Windows.Forms.RadioButton Rd16;
        private System.Windows.Forms.RadioButton Rd17;
        private System.Windows.Forms.Label LblSaat;
    }
}