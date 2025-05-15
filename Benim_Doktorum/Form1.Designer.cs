namespace Benim_Doktorum
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKullaniciKyt = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDoktorKyt = new System.Windows.Forms.Button();
            this.Txte_posta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.benim_DoktorumDataSet1 = new Benim_Doktorum.Benim_DoktorumDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(294, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // BtnKullaniciKyt
            // 
            this.BtnKullaniciKyt.Location = new System.Drawing.Point(225, 393);
            this.BtnKullaniciKyt.Name = "BtnKullaniciKyt";
            this.BtnKullaniciKyt.Size = new System.Drawing.Size(125, 40);
            this.BtnKullaniciKyt.TabIndex = 3;
            this.BtnKullaniciKyt.Text = "Kullanıcı Kayıt";
            this.BtnKullaniciKyt.UseVisualStyleBackColor = true;
            this.BtnKullaniciKyt.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(318, 459);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(123, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Çıkış";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDoktorKyt
            // 
            this.BtnDoktorKyt.Location = new System.Drawing.Point(406, 393);
            this.BtnDoktorKyt.Name = "BtnDoktorKyt";
            this.BtnDoktorKyt.Size = new System.Drawing.Size(123, 40);
            this.BtnDoktorKyt.TabIndex = 5;
            this.BtnDoktorKyt.Text = "Doktor Kayıt";
            this.BtnDoktorKyt.UseVisualStyleBackColor = true;
            this.BtnDoktorKyt.Click += new System.EventHandler(this.BtnDoktorKyt_Click);
            // 
            // Txte_posta
            // 
            this.Txte_posta.Location = new System.Drawing.Point(287, 147);
            this.Txte_posta.Name = "Txte_posta";
            this.Txte_posta.Size = new System.Drawing.Size(242, 22);
            this.Txte_posta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "e_posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(209, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre:";
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.Location = new System.Drawing.Point(287, 190);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(242, 22);
            this.Txt_sifre.TabIndex = 9;
            this.Txt_sifre.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(225, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // benim_DoktorumDataSet1
            // 
            this.benim_DoktorumDataSet1.DataSetName = "Benim_DoktorumDataSet";
            this.benim_DoktorumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txte_posta);
            this.Controls.Add(this.BtnDoktorKyt);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnKullaniciKyt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benim_DoktorumDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKullaniciKyt;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDoktorKyt;
        private System.Windows.Forms.TextBox Txte_posta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Benim_DoktorumDataSet benim_DoktorumDataSet1;
    }
}

