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
using System.Runtime.CompilerServices;
using System.Reflection.Emit;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Benim_Doktorum
{
    public partial class Kullanici_Girisi : Form
    {


        
        private String kullaniciisim;
        private int kullaniciID;
        private String e_postasi;


       //Constructor oluşturduk diğer formdan bilgileri alabilmek için 
        public Kullanici_Girisi(String isim,int id,String e_posta)
        {

            InitializeComponent();
            kullaniciisim = isim;
            kullaniciID = id;
            e_postasi=e_posta;

        }

     


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            
        }


       

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void Kullanici_Girisi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'benim_DoktorumDataSet.Tbl_sigorta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_sigortaTableAdapter.Fill(this.benim_DoktorumDataSet.Tbl_sigorta);
            // TODO: Bu kod satırı 'benim_DoktorumDataSet.Tbl_Sehir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_SehirTableAdapter.Fill(this.benim_DoktorumDataSet.Tbl_Sehir);



            // Girişte kullanıcıya kendi ismiyle hoşgeldin mesajı veriyoruz bu isim bilgisi giril yaptığımmız formdan alınıyor 
            LblHosgeldiniz.Text = "Hoşgeldiniz," + kullaniciisim;


            // Kullanıcıya ait diğer bilgileri veritabanından çekmek için
            try
            {
                baglanti.Open();

                // SQL sorgusunda eksik boşlukları düzelttim.
                SqlCommand komut = new SqlCommand("SELECT Tbl_Hasta.isim, Tbl_Hasta.soy_isim, Tbl_Hasta.yas, Tbl_Hasta.cinsiyet, Tbl_Hasta.telefon, Tbl_sigorta.sigorta_turu, Tbl_Sehir.sehir " +
                    "FROM Tbl_Hasta " +
                    "INNER JOIN Tbl_Sehir ON Tbl_Hasta.sehir = Tbl_Sehir.id " +
                    "INNER JOIN Tbl_sigorta ON Tbl_Hasta.sigorta = Tbl_sigorta.id " +
                    "WHERE Tbl_Hasta.id = @id", baglanti);

                komut.Parameters.AddWithValue("@id", kullaniciID);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    LblAd.Text = dr["isim"].ToString();
                    LblSoyad.Text = dr["soy_isim"].ToString();
                    LblYas.Text = "Yaşı: " + dr["yas"].ToString();
                    LblSehir.Text = "Şehir: " + dr["sehir"].ToString();
                    LblCinsiyet.Text = "Cinsiyet: " + (dr["cinsiyet"].ToString() == "True" ? "Erkek" : "Kadın");
                    LblTel.Text = "Telefon: " + dr["telefon"].ToString();
                    LblSigorta.Text = "Sigorta: " + dr["sigorta_turu"].ToString();
                    Lble_posta.Text = e_postasi;
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

        private void LblSehir_Click(object sender, EventArgs e)
        {

        }

       private void GuncellemeEkrani()
        {
            TxtAd.Visible = true;
            TxtSoyad.Visible = true;
            TxtYas.Visible = true;
            Txte_posta.Visible = true;
            MskTel.Visible = true;
            CmbSehir.Visible = true;
            CmbSigorta.Visible = true;
            LblSifre.Visible = true;
            TxtSifre.Visible = true;
            LblAd.Text = "Adınız:";
            LblSoyad.Text = "Soyadınız:";
            LblYas.Text = "Yaşınız:";
            LblTel.Text = "Telefon Numaraniz:";
            LblSehir.Text = "Şehriniz:";
            Lble_posta.Text = "e_postanız:";
            LblSifre.Text = "Şifreniz:";
            LblSigorta.Text = "Sigortanız:";




        }
        private void GuncellemeKapat()
        {




            TxtAd.Visible = false;
            TxtSoyad.Visible = false;
            TxtYas.Visible = false;
            Txte_posta.Visible = false;
            MskTel.Visible = false;
            CmbSehir.Visible = false;
            CmbSigorta.Visible = false;
            LblSifre.Visible = false;
            TxtSifre.Visible = false;
        }

        private void Bilgilerim()
        {
            try
            {
                baglanti.Open();

                // SQL sorgusunda eksik boşlukları düzelttim.
                SqlCommand komut = new SqlCommand("SELECT Tbl_Hasta.isim, Tbl_Hasta.soy_isim, Tbl_Hasta.yas, Tbl_Hasta.cinsiyet, Tbl_Hasta.telefon, Tbl_sigorta.sigorta_turu, Tbl_Sehir.sehir " +
                    "FROM Tbl_Hasta " +
                    "INNER JOIN Tbl_Sehir ON Tbl_Hasta.sehir = Tbl_Sehir.id " +
                    "INNER JOIN Tbl_sigorta ON Tbl_Hasta.sigorta = Tbl_sigorta.id " + // BOŞLUK EKLENDİ
                    "WHERE Tbl_Hasta.id = @id", baglanti);

                komut.Parameters.AddWithValue("@id", kullaniciID);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    LblAd.Text = dr["isim"].ToString();
                    LblSoyad.Text = dr["soy_isim"].ToString();
                    LblYas.Text = "Yaşı: " + dr["yas"].ToString();
                    LblSehir.Text = "Şehir: " + dr["sehir"].ToString();
                    LblCinsiyet.Text = "Cinsiyet: " + (dr["cinsiyet"].ToString() == "True" ? "Erkek" : "Kadın");
                    LblTel.Text = "Telefon: " + dr["telefon"].ToString();
                    LblSigorta.Text = "Sigorta: " + dr["sigorta_turu"].ToString();
                    Lble_posta.Text = e_postasi;
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

        private void BilgileriTextboxtaGöster()
        {
            try
            {
                baglanti.Open();

                // SQL sorgusunda eksik boşlukları düzelttim.
                SqlCommand komut = new SqlCommand("SELECT Tbl_Hasta.isim, Tbl_Hasta.soy_isim, Tbl_Hasta.yas, Tbl_Hasta.cinsiyet, Tbl_Hasta.telefon, Tbl_sigorta.sigorta_turu, Tbl_Sehir.sehir " +
                    "FROM Tbl_Hasta " +
                    "INNER JOIN Tbl_Sehir ON Tbl_Hasta.sehir = Tbl_Sehir.id " +
                    "INNER JOIN Tbl_sigorta ON Tbl_Hasta.sigorta = Tbl_sigorta.id " + // BOŞLUK EKLENDİ
                    "WHERE Tbl_Hasta.id = @id", baglanti);

                komut.Parameters.AddWithValue("@id", kullaniciID);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    TxtAd.Text = dr["isim"].ToString();
                    TxtSoyad.Text = dr["soy_isim"].ToString();
                    TxtYas.Text = dr["yas"].ToString();
                    MskTel.Text = dr["telefon"].ToString() ;
                    Txte_posta.Text = e_postasi.ToString();
                    CmbSehir.Text =  dr["sehir"].ToString();
                    CmbSigorta.Text = dr["sigorta_turu"].ToString();


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



        private void BtnBilgiGncelle_Click(object sender, EventArgs e)
        {
       GuncellemeEkrani();
            BilgileriTextboxtaGöster();
            BtnBilgileriKyt.Visible = true; 


           

        }

        private void BtnBilgileriKyt_Click(object sender, EventArgs e)
        {
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
                eksikAlan = "E-posta";
            else if (string.IsNullOrWhiteSpace(TxtSifre.Text))
                eksikAlan = "Şifre";
            else if (CmbSehir.SelectedValue == null || string.IsNullOrWhiteSpace(CmbSehir.Text))
                eksikAlan = "Şehir";
            else if (CmbSigorta.SelectedValue == null || string.IsNullOrWhiteSpace(CmbSigorta.Text))
                eksikAlan = "Sigorta";

            if (!string.IsNullOrEmpty(eksikAlan))
            {
                MessageBox.Show($"Lütfen {eksikAlan} alanını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                GuncellemeKapat();
                BilgiGuncelle();
                Bilgilerim();
            }
        }


        private void BilgiGuncelle()
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Tbl_Hasta Set isim=@a1,soy_isim=@a2,sehir=@a3," +
                "e_posta=@a4,sifre=@a5,sigorta=@a6,telefon=@a7,yas=@a8 WHERE e_posta=@a9 ", baglanti);


            guncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            guncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            guncelle.Parameters.AddWithValue("@a3", CmbSehir.SelectedValue);
            guncelle.Parameters.AddWithValue("@a4", Txte_posta.Text);
            guncelle.Parameters.AddWithValue("@a5", TxtSifre.Text);
            guncelle.Parameters.AddWithValue("@a6", CmbSigorta.SelectedValue);
            guncelle.Parameters.AddWithValue("@a7", MskTel.Text);
            guncelle.Parameters.AddWithValue("@a8", TxtYas.Text);
            guncelle.Parameters.AddWithValue("@a9", e_postasi);
            e_postasi = Txte_posta.Text;

            guncelle.ExecuteNonQuery();

           

            baglanti.Close();
            MessageBox.Show("Bilgileriniz Güncellendi");





        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {


            RandevuAl giris = new RandevuAl(kullaniciisim,e_postasi,kullaniciID);

            this.Hide();
            giris.Show();
            

        }

        private void BtnRandevuGrntle_Click(object sender, EventArgs e)
        {
            FrmRandevularım randevu = new FrmRandevularım(kullaniciisim,kullaniciID,e_postasi);
            this.Hide();
            randevu.Show();


        }
    }
}
