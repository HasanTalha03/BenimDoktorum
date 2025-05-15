namespace Benim_Doktorum
{
    partial class FrmRandevularım
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUrlAl = new System.Windows.Forms.TextBox();
            this.BtnRandevuGrn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Btniptal = new System.Windows.Forms.Button();
            this.tblRandevuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.benim_Doktorum_Son_DataSet = new Benim_Doktorum.Benim_Doktorum_Son_DataSet();
            this.tblRandevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RandevuTableAdapter = new Benim_Doktorum.Benim_Doktorum_Son_DataSetTableAdapters.Tbl_RandevuTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.benim_DoktorumDataSet10 = new Benim_Doktorum.Benim_DoktorumDataSet10();
            this.tblHastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_HastaTableAdapter = new Benim_Doktorum.Benim_DoktorumDataSet10TableAdapters.Tbl_HastaTableAdapter();
            this.tblHastaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_HastaTableAdapter1 = new Benim_Doktorum.Benim_Doktorum_Son_DataSetTableAdapters.Tbl_HastaTableAdapter();
            this.sonDataSet = new Benim_Doktorum.SonDataSet();
            this.tblHastaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_HastaTableAdapter2 = new Benim_Doktorum.SonDataSetTableAdapters.Tbl_HastaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_Doktorum_Son_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevularım:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(313, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(429, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doktor Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(702, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Randevu Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(879, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Randevu Saati";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(38, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(981, 180);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(434, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aktif Randevuma Git";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.ForeColor = System.Drawing.Color.Black;
            this.BtnGeri.Location = new System.Drawing.Point(434, 556);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(179, 37);
            this.BtnGeri.TabIndex = 8;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(599, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bölüm";
            // 
            // TxtUrlAl
            // 
            this.TxtUrlAl.Location = new System.Drawing.Point(38, 353);
            this.TxtUrlAl.Name = "TxtUrlAl";
            this.TxtUrlAl.Size = new System.Drawing.Size(981, 22);
            this.TxtUrlAl.TabIndex = 10;
            // 
            // BtnRandevuGrn
            // 
            this.BtnRandevuGrn.ForeColor = System.Drawing.Color.Black;
            this.BtnRandevuGrn.Location = new System.Drawing.Point(434, 418);
            this.BtnRandevuGrn.Name = "BtnRandevuGrn";
            this.BtnRandevuGrn.Size = new System.Drawing.Size(179, 46);
            this.BtnRandevuGrn.TabIndex = 11;
            this.BtnRandevuGrn.Text = "Aktif Randevularımı Görüntüle";
            this.BtnRandevuGrn.UseVisualStyleBackColor = true;
            this.BtnRandevuGrn.Click += new System.EventHandler(this.BtnRandevuGrn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(244, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(572, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Aktif Randevularnızın Url\'sini Buradan Görebilirsiniz. Gitmek İçin Randevuma Git " +
    "Demeniz Yeterli";
            // 
            // Btniptal
            // 
            this.Btniptal.Location = new System.Drawing.Point(434, 513);
            this.Btniptal.Name = "Btniptal";
            this.Btniptal.Size = new System.Drawing.Size(179, 37);
            this.Btniptal.TabIndex = 13;
            this.Btniptal.Text = "Randevumu iptal et";
            this.Btniptal.UseVisualStyleBackColor = true;
            this.Btniptal.Click += new System.EventHandler(this.Btniptal_Click);
            // 
            // tblRandevuBindingSource1
            // 
            this.tblRandevuBindingSource1.DataMember = "Tbl_Randevu";
            this.tblRandevuBindingSource1.DataSource = this.benim_Doktorum_Son_DataSet;
            // 
            // benim_Doktorum_Son_DataSet
            // 
            this.benim_Doktorum_Son_DataSet.DataSetName = "Benim_Doktorum_Son_DataSet";
            this.benim_Doktorum_Son_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRandevuBindingSource
            // 
            this.tblRandevuBindingSource.DataMember = "Tbl_Randevu";
            this.tblRandevuBindingSource.DataSource = this.benim_Doktorum_Son_DataSet;
            // 
            // tbl_RandevuTableAdapter
            // 
            this.tbl_RandevuTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(33, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Randevu ID";
            // 
            // benim_DoktorumDataSet10
            // 
            this.benim_DoktorumDataSet10.DataSetName = "Benim_DoktorumDataSet10";
            this.benim_DoktorumDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHastaBindingSource
            // 
            this.tblHastaBindingSource.DataMember = "Tbl_Hasta";
            this.tblHastaBindingSource.DataSource = this.benim_DoktorumDataSet10;
            // 
            // tbl_HastaTableAdapter
            // 
            this.tbl_HastaTableAdapter.ClearBeforeFill = true;
            // 
            // tblHastaBindingSource1
            // 
            this.tblHastaBindingSource1.DataMember = "Tbl_Hasta";
            this.tblHastaBindingSource1.DataSource = this.benim_Doktorum_Son_DataSet;
            // 
            // tbl_HastaTableAdapter1
            // 
            this.tbl_HastaTableAdapter1.ClearBeforeFill = true;
            // 
            // sonDataSet
            // 
            this.sonDataSet.DataSetName = "SonDataSet";
            this.sonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHastaBindingSource2
            // 
            this.tblHastaBindingSource2.DataMember = "Tbl_Hasta";
            this.tblHastaBindingSource2.DataSource = this.sonDataSet;
            // 
            // tbl_HastaTableAdapter2
            // 
            this.tbl_HastaTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmRandevularım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1055, 606);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Btniptal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnRandevuGrn);
            this.Controls.Add(this.TxtUrlAl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmRandevularım";
            this.Text = "FrmRandevularım";
            this.Load += new System.EventHandler(this.FrmRandevularım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_Doktorum_Son_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaBindingSource2)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUrlAl;
        private System.Windows.Forms.Button BtnRandevuGrn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btniptal;
        private Benim_Doktorum_Son_DataSet benim_Doktorum_Son_DataSet;
        private System.Windows.Forms.BindingSource tblRandevuBindingSource;
        private Benim_Doktorum_Son_DataSetTableAdapters.Tbl_RandevuTableAdapter tbl_RandevuTableAdapter;
        private System.Windows.Forms.Label label9;
        private Benim_DoktorumDataSet10 benim_DoktorumDataSet10;
        private System.Windows.Forms.BindingSource tblHastaBindingSource;
        private Benim_DoktorumDataSet10TableAdapters.Tbl_HastaTableAdapter tbl_HastaTableAdapter;
        private System.Windows.Forms.BindingSource tblHastaBindingSource1;
        private Benim_Doktorum_Son_DataSetTableAdapters.Tbl_HastaTableAdapter tbl_HastaTableAdapter1;
        private SonDataSet sonDataSet;
        private System.Windows.Forms.BindingSource tblHastaBindingSource2;
        private SonDataSetTableAdapters.Tbl_HastaTableAdapter tbl_HastaTableAdapter2;
        private System.Windows.Forms.BindingSource tblRandevuBindingSource1;
    }
}