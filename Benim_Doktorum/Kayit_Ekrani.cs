using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;


namespace Benim_Doktorum
{
    public partial class Kayit_Ekrani : Form
    {





        public Kayit_Ekrani()
        {
            InitializeComponent();
        }

        // bağlantı nesnesi oluşturuyoruz sql komutlarını kullanmak için 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }





        private void Kayit_Ekrani_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'benim_DoktorumDataSet.Tbl_sigorta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_sigortaTableAdapter.Fill(this.benim_DoktorumDataSet.Tbl_sigorta);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet.Tbl_Sehir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_SehirTableAdapter.Fill(this.benim_DoktorumDataSet.Tbl_Sehir);

           

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            // Boş alanları kontrol et
            if (string.IsNullOrWhiteSpace(TxtAd.Text) || string.IsNullOrWhiteSpace(TxtSoyAd.Text) ||
                CmbSehir.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Txte_posta.Text) ||
                string.IsNullOrWhiteSpace(TxtSifre.Text) || CmbSigorta.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(MskTxtTel.Text) || string.IsNullOrWhiteSpace(TxtYas.Text) ||
                label10.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return; // Eğer bir alan boşsa fonksiyonu durdur
            }

            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // SQL komutunu oluştur
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Hasta  (isim,soy_isim,sehir,e_posta,sifre,sigorta,telefon,yas,cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);

                // Parametreleri ekle
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyAd.Text);
                komut.Parameters.AddWithValue("@p3", CmbSehir.SelectedValue);
                komut.Parameters.AddWithValue("@p4", Txte_posta.Text);
                komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
                komut.Parameters.AddWithValue("@p6", CmbSigorta.SelectedValue);
                komut.Parameters.AddWithValue("@p7", MskTxtTel.Text);
                komut.Parameters.AddWithValue("@p8", TxtYas.Text);
                komut.Parameters.AddWithValue("@p9", label10.Text);

                // Veriyi ekle
                komut.ExecuteNonQuery();

                // Bağlantıyı kapat
                baglanti.Close();

                // Başarı mesajı göster
                MessageBox.Show("Kayıt Başarılı");

                this.Hide();
                Form1 dönüs = new Form1();
                dönüs.ShowDialog();
            }

            catch (SqlException ex)
            {
                // Hata kontrolü: UNIQUE kısıtlaması hatası
                if (ex.Number == 2627 || ex.Number == 2601) // UNIQUE constraint ihlali
                {
                    if (ex.Message.Contains("e_posta")) // e_posta sütununda ihlal
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kayıtlı. Lütfen başka bir e-posta adresi kullanın.");
                    }
                    else if (ex.Message.Contains("telefon")) // telefon sütununda ihlal
                    {
                        MessageBox.Show("Bu telefon numarası zaten kayıtlı. Lütfen başka bir telefon numarası kullanın.");
                    }
                    else
                    {
                        // Diğer UNIQUE ihlalleri
                        MessageBox.Show("Bu kayıt zaten var ya da e_posta veya telefon numarası zaten alınmış");
                    }
                }
                else
                {
                    // Diğer SQL hataları
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }


        }




        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = "False";
        }


        public string kullaniciEposta; // kullanıcının e_postasını tutmak için String tanımladık
        //güncelleme işini farklı form açarak yapabilirsin 


        private void BtnGöster_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
