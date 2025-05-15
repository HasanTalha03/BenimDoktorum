using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Benim_Doktorum
{
    public partial class Doktor_Kayit_Ekrani : Form
    {
        public Doktor_Kayit_Ekrani()
        {
            InitializeComponent();
        }

        // bağlantı nesnesi oluşturuyoruz sql komutlarını kullanmak için 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");


        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();

        }

        private void Doktor_Kayit_Ekrani_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'benim_DoktorumDataSet5.Tbl_Hastane' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_HastaneTableAdapter.Fill(this.benim_DoktorumDataSet5.Tbl_Hastane);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet2.Tbl_Uzmanlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UzmanlikTableAdapter.Fill(this.benim_DoktorumDataSet2.Tbl_Uzmanlik);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet1.Tbl_Universite' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UniversiteTableAdapter.Fill(this.benim_DoktorumDataSet1.Tbl_Universite);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet.Tbl_Sehir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_SehirTableAdapter.Fill(this.benim_DoktorumDataSet.Tbl_Sehir);

        }




        private void BtnKayit_Click(object sender, EventArgs e)
        {
            PcrResim.Visible = true;



            // kayıt ekranında tüm alanların doldurulmasını sağlıyor 
            //ad soyad ve diğer textboxların boş geçilmemesini ve comboboxlardan da bir verinin seçilip seçilmediğini kontrol ediyor 
            if (string.IsNullOrWhiteSpace(TxtAd.Text) || string.IsNullOrWhiteSpace(TxtSoyad.Text) ||
               CmbSehir.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Txte_posta.Text) ||
               string.IsNullOrWhiteSpace(TxtSifre.Text) ||
               string.IsNullOrWhiteSpace(MskTel.Text) || string.IsNullOrWhiteSpace(TxtYas.Text) ||
               label10.Text == "" || CmbUniversite.SelectedIndex==-1 || CmbHastane.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return; // Eğer bir alan boşsa fonksiyonu durdur
            }

            // OpenFileDialog ile resim seçme işlemi
            OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen resmi PictureBox'a yükleme
                    PcrResim.Image = Image.FromFile(openFileDialog.FileName);

                    // Resmi byte dizisine dönüştürme
                    byte[] resimBytes = File.ReadAllBytes(openFileDialog.FileName);




                try
                {
                    // Bağlantıyı aç
                    baglanti.Open();



                    // SQL sorgusu
                    SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Doktor (isim, soy_isim, universite, e_posta, sifre, telefon, yas, cinsiyet, sehir, uzmanlik, resim, hastane) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12)", baglanti);




                    // Parametreleri ekle
                    komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", CmbUniversite.SelectedValue);
                    komut.Parameters.AddWithValue("@p4", Txte_posta.Text);
                    komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
                    komut.Parameters.AddWithValue("@p6", MskTel.Text);
                    komut.Parameters.AddWithValue("@p7", TxtYas.Text);
                    komut.Parameters.AddWithValue("@p8", label15.Text);
                    komut.Parameters.AddWithValue("@p9", CmbSehir.SelectedValue);
                    komut.Parameters.AddWithValue("@p10", CmbUzmanlik.SelectedValue);
                    komut.Parameters.AddWithValue("@p12", CmbHastane.SelectedValue);
                    komut.Parameters.AddWithValue("@p11", resimBytes);



                    // Komutu çalıştır
                    komut.ExecuteNonQuery();




                    // Başarı mesajı
                    MessageBox.Show("Kayıt Başarılı");
                    MessageBox.Show("Ana Menüye Yönlendiriliyorsunuz");




                    // Ana menüye dön
                    this.Hide();
                    Form1 dönüs = new Form1();
                    dönüs.ShowDialog();




                }
                catch (SqlException ex)
                {


                    // Hata kontrolü: UNIQUE kısıtlaması hatası
                    if (ex.Number == 2627) // UNIQUE constraint ihlali için hata kodu
                  
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kayıtlı. Lütfen başka bir e-posta adresi kullanın.");
                    }
                 
                    else
                    {
                        // Diğer SQL hataları
                        MessageBox.Show("Bu e_posta daha önceden alınmış lütfen farklı bir e_posta girin! ");
                    }
                }



                finally
                {
                    // Bağlantıyı kapat
                    baglanti.Close();
                }



            }

        }





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = "True";
        }




        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = "False";
        }

      
    }
    }

