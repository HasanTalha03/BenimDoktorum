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

namespace Benim_Doktorum
{

    public partial class RandevuAl : Form
    {
        private String kullaniciisim;
        private int kullaniciID;
        private String e_postasi;




        //
        public RandevuAl(String isim, String e_posta, int id)
        {
            InitializeComponent();
            this.kullaniciID = id;
            this.kullaniciisim = isim;
            this.e_postasi = e_posta;


        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");






        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi giris = new Kullanici_Girisi(kullaniciisim, kullaniciID, e_postasi);

            giris.Show();
            this.Hide();


        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {

            // TODO: Bu kod satırı 'benim_DoktorumDataSet7.Tbl_Uzmanlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz
            this.tbl_UzmanlikTableAdapter.Fill(this.benim_DoktorumDataSet71.Tbl_Uzmanlik);


            LblHosGeldiniz.Text = " Randevu Ekranına Hoş Geldiniz:" + kullaniciisim;



        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ListeleDoktorlar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void ListeleDoktorlar()
        {
            // ComboBox'tan seçilen Uzmanlık ID'sini al
            int uzmanlikID = Convert.ToInt32(CmbUzmanlik.SelectedValue); // Seçilen uzmanlık ID'si

            // SQL sorgusu
            string query = "SELECT Tbl_Doktor.id,Tbl_Doktor.isim, Tbl_Doktor.soy_isim, yas, Tbl_Sehir.sehir, Tbl_Hastane.Hastane_adi, Tbl_Uzmanlik.uzmanlik, Tbl_Universite.universite_adi, e_posta FROM Tbl_Doktor " +
                "INNER JOIN Tbl_Sehir ON Tbl_Doktor.sehir = Tbl_Sehir.id " +
                "INNER JOIN Tbl_Hastane ON Tbl_Doktor.hastane = Tbl_Hastane.id " +
                "INNER JOIN Tbl_Uzmanlik ON Tbl_Doktor.uzmanlik = Tbl_Uzmanlik.id " +
                "INNER JOIN Tbl_Universite ON Tbl_Doktor.universite= Tbl_Universite.id " +
                "WHERE Tbl_Doktor.uzmanlik = @a1";




            try
            {


                baglanti.Open();

                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@a1", uzmanlikID);

                SqlDataReader dr = komut.ExecuteReader();

                LstDoktorlar.Items.Clear(); // ListBox'u temizle
                CmbDoktor.Items.Clear();
                while (dr.Read())
                {
                    // Doktor bilgilerini birleştirerek ListBox'a ekleyelim
                    string doktorBilgisi = dr["isim"].ToString() + " " + dr["soy_isim"].ToString() + " \n " +
                                           "Yaş: " + dr["yas"].ToString() + " | " +
                                           "Şehir: " + dr["sehir"].ToString() + " | " +
                                           "Hastane: " + dr["Hastane_adi"].ToString() + " | " +
                                           "Uzmanlık: " + dr["uzmanlik"].ToString() + " | " +
                                           "Üniversite: " + dr["universite_adi"].ToString() + " | " +
                                           "E-posta: " + dr["e_posta"].ToString();

                  
                    // Doktor bilgisini ListBox'a ekle
                    LstDoktorlar.Items.Add(doktorBilgisi);


                  
                    string doktorIsimSoyisim = dr["isim"].ToString() + " " + dr["soy_isim"].ToString();
                    CmbDoktor.Items.Add(new { Id = dr["id"], IsimSoyisim = doktorIsimSoyisim });

                }
                // ComboBox'ta görünecek bilgiyi ve id'yi ayarlıyoruz
                CmbDoktor.DisplayMember = "IsimSoyisim";  // Görünecek olan metin (isim + soyisim)
                CmbDoktor.ValueMember = "Id";  // Kaydedilecek id



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

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            if (Rd10.Checked)
            {
                LblSaat.Text = Rd10.Text;
            }
            else if (Rd11.Checked)
            {
                LblSaat.Text=Rd11.Text;

            }
            else if (Rd12.Checked)
            {
                LblSaat.Text = Rd12.Text;

            }
            else if (Rd13.Checked)
            {
                LblSaat.Text = Rd13.Text;

            }
            else if (Rd14.Checked)
            {
                LblSaat.Text = Rd14.Text;

            }
            else if (Rd15.Checked)
            {
                LblSaat.Text = Rd15.Text;

            }
            else if (Rd16.Checked)
            {
                LblSaat.Text = Rd16.Text;

            }
            else if (Rd17.Checked)
            {
                LblSaat.Text = Rd17.Text;

            }



            var selectedDoktor = CmbDoktor.SelectedItem;

            if (selectedDoktor != null)
            {
                // Seçilen öğeden doktor id'sini alıyoruz
                var doktorId = (selectedDoktor as dynamic).Id;  // Burada doktorId doğru şekilde tanımlandı.

                // SqlCommand nesnesi oluşturuluyor ve parametreler ekleniyor
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Randevu (doktor_id, hasta_id, randevu_tarihi,saat) VALUES (@p1, @p2, @p3,@p4)", baglanti);

                try
                {
                    baglanti.Open();

                    komut.Parameters.AddWithValue("@p1", doktorId);  // Seçilen doktorun id'si
                    komut.Parameters.AddWithValue("@p2", kullaniciID);  // Kullanıcı ID'si
                    komut.Parameters.AddWithValue("@p3", DTP_Tarih.Value);  // Randevu tarihi
                    komut.Parameters.AddWithValue("@p4",LblSaat.Text);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Randevu Alındı");
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
            else
            {
                MessageBox.Show("Lütfen bir doktor seçin.");
            }




          
        }



        

       

       

       
    }
}
