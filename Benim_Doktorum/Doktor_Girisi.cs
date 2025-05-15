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
using System.Runtime.CompilerServices;
using System.Reflection.Emit;
using System.IO;

namespace Benim_Doktorum
{


    public partial class Doktor_Girisi : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");

        private String doktor_isim;
        private int doktor_id;
        private String doktor_e_postasi;




        public Doktor_Girisi(String isim, int id, String e_posta)
        {
            InitializeComponent();
            this.doktor_isim = isim;
            this.doktor_id = id;
            this.doktor_e_postasi = e_posta;

        }



        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }




        private void Doktor_Girisi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'benim_DoktorumDataSet71.Tbl_Sehir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_SehirTableAdapter.Fill(this.benim_DoktorumDataSet71.Tbl_Sehir);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet71.Tbl_Universite' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UniversiteTableAdapter.Fill(this.benim_DoktorumDataSet71.Tbl_Universite);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet71.Tbl_Uzmanlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UzmanlikTableAdapter.Fill(this.benim_DoktorumDataSet71.Tbl_Uzmanlik);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet8.Tbl_Hastane' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_HastaneTableAdapter.Fill(this.benim_DoktorumDataSet8.Tbl_Hastane);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet6.Tbl_Hastane' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_HastaneTableAdapter3.Fill(this.benim_DoktorumDataSet71.Tbl_Hastane);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet31.Tbl_Doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DoktorTableAdapter.Fill(this.benim_DoktorumDataSet31.Tbl_Doktor);
          
        

            LblHosgeldiniz.Text = "Hoşgeldiniz Doktor," + doktor_isim;

            try
            {
                baglanti.Open();

                // SQL sorgusunda eksik boşlukları düzelttim.
                SqlCommand komut = new SqlCommand("SELECT Tbl_Doktor.isim, Tbl_Doktor.soy_isim,Tbl_Sehir.sehir,Tbl_Universite.universite_adi,Tbl_Doktor.yas, Tbl_Doktor.cinsiyet,  Tbl_Doktor.telefon,Tbl_Doktor.resim,Tbl_Hastane.Hastane_adi,Tbl_Uzmanlik.uzmanlik" +
                    " FROM Tbl_Doktor " +
                    "INNER JOIN Tbl_Sehir ON Tbl_Doktor.sehir = Tbl_Sehir.id " +
                    //şehir kodunda sıkıntı yok
                   "INNER JOIN Tbl_Universite ON Tbl_Doktor.universite = Tbl_Universite.id " + 
                    "INNER JOIN Tbl_Uzmanlik ON Tbl_Doktor.uzmanlik = Tbl_Uzmanlik.id " + 
                    "INNER JOIN Tbl_Hastane ON Tbl_Doktor.hastane = Tbl_Hastane.id " +  
                    "WHERE Tbl_Doktor.id = @id", baglanti); 

                komut.Parameters.AddWithValue("@id", doktor_id);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    LblAd.Text = dr["isim"].ToString();
                    LblSoyad.Text = dr["soy_isim"].ToString();
                    LblYas.Text = "Yaşı: " + dr["yas"].ToString();
                    LblSehir.Text = "Şehir: " + dr["sehir"].ToString();
                    LblCinsiyet.Text = "Cinsiyet: " + (dr["cinsiyet"].ToString() == "True" ? "Erkek" : "Kadın");
                    LblTel.Text = "Telefon: " + dr["telefon"].ToString();
                    LblUniversite.Text = "Universite: " + dr["universite_adi"].ToString();
                    LblHastane.Text = "Hastane: " + dr["Hastane_adi"].ToString();
                    LblUzmanlik.Text = "Uzmanlik:" + dr["uzmanlik"].ToString();
                    
                    Lble_posta.Text = doktor_e_postasi;

                    if (dr["resim"] != DBNull.Value)
                    {
                        byte[] resimVerisi = (byte[])dr["resim"];
                        using (MemoryStream ms = new MemoryStream(resimVerisi))
                        {
                            PcrResim.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Resim bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı!");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

      

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            




            LblAd.Text = "Adınız:";
            LblSoyad.Text = "Soyadınız:";
            LblYas.Text = "Yaşınız:";
            LblTel.Text = "Telefon:";
            Lble_posta.Text = "e_postanız:";
            LblSifre.Visible = true;
            LblSifre.Text = "Şifreniz:";
            LblSehir.Text = "Şehiriniz:";
            LblUzmanlik.Text = "Uzmanlığınız:";
            LblUniversite.Text = "Üniversiteniz/Üniversiteleriniz";
            LblHastane.Text = "Çalıştığınız Hastane";

            BtnDegisiklikKyt.Visible = true;
            TxtAd.Visible = true;
            TxtSoyad.Visible = true;
            TxtYas.Visible = true;
            Txte_posta.Visible = true;
            TxtSifre.Visible = true;
            CmbSehir.Visible = true;
            CmbUniversite.Visible = true;
            CmbUzmanlik.Visible = true;
            CmbHastane.Visible = true;
            MskTel.Visible = true;
            BilgileriTextboxtaGöster();
        }

        private void BtnDegisiklikKyt_Click(object sender, EventArgs e)
        {
            
            // textboxları tekrardan görünmez yap
            BtnDegisiklikKyt.Visible = false;
            TxtAd.Visible = false;
            TxtSoyad.Visible = false;
            TxtYas.Visible = false;
            Txte_posta.Visible = false;
            LblSifre.Visible = false;
            TxtSifre.Visible = false;
            CmbSehir.Visible = false;
            CmbUniversite.Visible = false;
            CmbUzmanlik.Visible = false;
            CmbHastane.Visible = false;
            MskTel.Visible = false;

            //eskik alan adlı bir string oluştur ve bunu if else döngüsü ile bütün textboxlarda kontrol et
            //bu işlem hiçbir alanın boş geçilmemesini sağlıyor
            string eksikAlan = string.Empty;

            if (string.IsNullOrWhiteSpace(TxtAd.Text))
                eksikAlan = "Ad";
            else if (string.IsNullOrWhiteSpace(TxtSoyad.Text))
                eksikAlan = "Soyad";
            else if (string.IsNullOrWhiteSpace(TxtYas.Text))
                eksikAlan = "Yaş";
            else if (string.IsNullOrWhiteSpace(MskTel.Text))
                eksikAlan = "Telefon";
            else if (string.IsNullOrWhiteSpace(Txte_posta.Text))
                eksikAlan = "E_posta";
            else if (string.IsNullOrWhiteSpace(TxtSifre.Text))
                eksikAlan = "Şifre";
            else if (CmbSehir.SelectedValue == null || string.IsNullOrWhiteSpace(CmbSehir.Text))
                eksikAlan = "Şehir";
            else if (CmbUniversite.SelectedValue == null || string.IsNullOrWhiteSpace(CmbUniversite.Text))
                eksikAlan = "Üniversite";
            else if (CmbUzmanlik.SelectedValue == null || string.IsNullOrWhiteSpace(CmbUzmanlik.Text))
                eksikAlan = "Uzmanlık";
            else if (CmbHastane.SelectedValue == null || string.IsNullOrWhiteSpace(CmbHastane.Text))
                eksikAlan = "Hastane";

            if (!string.IsNullOrEmpty(eksikAlan))
            {
                MessageBox.Show($"Lütfen {eksikAlan} alanını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //eksik alan yoksa else kısmına gir ve bilgileri güncelle fonksiyonunu çağır
            //ardından bilgileri göster
            else
            {

                 BilgiGuncelle();
                 Bilgilerim();
            }
        }











        // Bilgileri güncellemek için fonksiyon textbox ve comboboxlardan aldığımız verileri sql e kaydediyoruz

        private void BilgiGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("UPDATE Tbl_Doktor SET isim=@a1, soy_isim=@a2, sehir=@a3, " +
                    "e_posta=@a4, sifre=@a5, uzmanlik=@a6, telefon=@a7, yas=@a8, universite=@a9, hastane=@a10 WHERE e_posta=@a11", baglanti);

                guncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
                guncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
                guncelle.Parameters.AddWithValue("@a3", CmbSehir.SelectedValue);
                guncelle.Parameters.AddWithValue("@a4", Txte_posta.Text);
                guncelle.Parameters.AddWithValue("@a5", TxtSifre.Text);
                guncelle.Parameters.AddWithValue("@a6", CmbUzmanlik.SelectedValue);
                guncelle.Parameters.AddWithValue("@a7", MskTel.Text);
                guncelle.Parameters.AddWithValue("@a8", TxtYas.Text);
                guncelle.Parameters.AddWithValue("@a9", CmbUniversite.SelectedValue);
                guncelle.Parameters.AddWithValue("@a10",CmbHastane.SelectedValue);
                guncelle.Parameters.AddWithValue("@a11", doktor_e_postasi); // Mevcut e-posta bilgisi ile eşleştirme yapılacak.
                doktor_e_postasi = Txte_posta.Text;
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Bilgileriniz Güncellendi");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bir hata meydana geldi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                   
                    baglanti.Close();
            }







        // Bilgileri göstermek için fonksiyon sql de kayıtlı bilgileri label larda gösteriyoruz
        }
        //bilgilerim fonksiyonu hatalı düzelt
        private void Bilgilerim()
        {


            // bu fonksiyonu düzenle
            try
            {
                baglanti.Open();

               
                SqlCommand komut = new SqlCommand("SELECT Tbl_Doktor.isim, Tbl_Doktor.soy_isim,Tbl_Sehir.sehir,Tbl_Universite.universite_adi,Tbl_Doktor.yas, Tbl_Doktor.cinsiyet, Tbl_Doktor.telefon,Tbl_Doktor.resim,Tbl_Hastane.Hastane_adi,Tbl_Uzmanlik.uzmanlik" +
                     " FROM Tbl_Doktor " +
                    "INNER JOIN Tbl_Sehir ON Tbl_Doktor.sehir = Tbl_Sehir.id " + 
                    "INNER JOIN Tbl_Universite ON Tbl_Doktor.universite = Tbl_Universite.id " +
                    "INNER JOIN Tbl_Uzmanlik ON Tbl_Doktor.uzmanlik = Tbl_Uzmanlik.id " +
                    "INNER JOIN Tbl_Hastane ON Tbl_Doktor.hastane = Tbl_Hastane.id " +
                    "WHERE Tbl_Doktor.id = @id", baglanti);

                komut.Parameters.AddWithValue("@id", doktor_id);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    LblAd.Text = dr["isim"].ToString();
                    LblSoyad.Text = dr["soy_isim"].ToString();
                    LblYas.Text = "Yaşı: " + dr["yas"].ToString();
                    LblSehir.Text = "Şehir: " + dr["sehir"].ToString();
                    LblCinsiyet.Text = "Cinsiyet: " + (dr["cinsiyet"].ToString() == "True" ? "Erkek" : "Kadın");
                    LblTel.Text = "Telefon: " + dr["telefon"].ToString();
                    LblUzmanlik.Text = "Uzmanlık: " + dr["uzmanlik"].ToString();
                    LblUniversite.Text = "Universite:" + dr["universite_adi"].ToString();
                    LblHastane.Text = "Hastane:" + dr["Hastane_adi"].ToString();
                   
                    Lble_posta.Text =   doktor_e_postasi;
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı!");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }



        }

        private void LblHastane_Click(object sender, EventArgs e)
        {

        }

        private void CmbUzmanlik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            DoktorRandevuEkrani giris = new DoktorRandevuEkrani(doktor_isim,doktor_id,doktor_e_postasi);
            this.Hide();
            giris.Show();
        }





        private void BilgileriTextboxtaGöster()
        {
            try
            {
                baglanti.Open();

                // SQL sorgusunda eksik boşlukları düzelttim.
                SqlCommand komut = new SqlCommand("SELECT   Tbl_Doktor.isim, Tbl_Doktor.soy_isim, Tbl_Doktor.yas, Tbl_Doktor.cinsiyet, Tbl_Doktor.telefon, Tbl_Universite.universite_adi, Tbl_Sehir.sehir,Tbl_Uzmanlik.uzmanlik,Tbl_Hastane.Hastane_adi " +
                    "FROM Tbl_Doktor " +
                    "INNER JOIN Tbl_Sehir ON Tbl_Doktor.sehir = Tbl_Sehir.id " +
                    "INNER JOIN Tbl_Universite ON Tbl_Doktor.universite = Tbl_Universite.id " + // BOŞLUK EKLENDİ
                    "INNER JOIN TbL_Hastane On Tbl_Doktor.hastane = Tbl_Hastane.id "+
                    "INNER JOIN Tbl_Uzmanlik ON Tbl_Doktor.uzmanlik=Tbl_Uzmanlik.id "+

                    "WHERE Tbl_Doktor.id = @id", baglanti);

                komut.Parameters.AddWithValue("@id", doktor_id);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    TxtAd.Text = dr["isim"].ToString();
                    TxtSoyad.Text = dr["soy_isim"].ToString();
                    TxtYas.Text = dr["yas"].ToString();
                    MskTel.Text = dr["telefon"].ToString();
                    Txte_posta.Text = doktor_e_postasi.ToString();
                    CmbSehir.Text = dr["sehir"].ToString();
                    CmbUniversite.Text = dr["universite_adi"].ToString();
                    CmbHastane.Text = dr["Hastane_adi"].ToString();
                    CmbUzmanlik.Text = dr["uzmanlik"].ToString();


                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı!");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }





        }
    }
}


   

