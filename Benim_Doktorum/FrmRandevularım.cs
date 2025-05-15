using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.WebRequestMethods;
namespace Benim_Doktorum
{
    public partial class FrmRandevularım : Form
    {




        private String kullaniciisim;
        private int kullaniciID;
       private String e_postasi;



        public FrmRandevularım(string isim,int id,string e_posta)
        {

            kullaniciisim = isim;
            this.kullaniciID= id;
            this.e_postasi= e_posta;
            InitializeComponent();
        }





        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");






        private void FrmRandevularım_Load(object sender, EventArgs e)
        {
            
             // TODO: Bu kod satırı 'benim_DoktorumDataSet10.Tbl_Hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_HastaTableAdapter.Fill(this.benim_DoktorumDataSet10.Tbl_Hasta);
            // TODO: Bu kod satırı 'benim_Doktorum_Son_DataSet.Tbl_Randevu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_RandevuTableAdapter.Fill(this.benim_Doktorum_Son_DataSet.Tbl_Randevu);





            SqlCommand komut = new SqlCommand(
     "SELECT Tbl_Randevu.randevu_id,  Tbl_Randevu.hasta_id, Hasta.isim AS hasta_isim, Hasta.soy_isim AS hasta_soy_isim, " +
     "Tbl_Doktor.isim AS doktor_isim, Tbl_Doktor.soy_isim AS doktor_soy_isim, " +
     "Tbl_Uzmanlik.uzmanlik AS doktor_uzmanlik, Tbl_Randevu.randevu_tarihi, Tbl_Randevu.saat,Tbl_Randevu.randevu_id " +
     "FROM Tbl_Randevu " +
     "INNER JOIN Tbl_Hasta AS Hasta ON Tbl_Randevu.hasta_id = Hasta.id " + // Hasta ID ile ilişkilendirme
     "INNER JOIN Tbl_Doktor ON Tbl_Randevu.doktor_id = Tbl_Doktor.id " + // Doktor ID ile ilişkilendirme
     "INNER JOIN Tbl_Uzmanlik ON Tbl_Doktor.uzmanlik = Tbl_Uzmanlik.id " + // Uzmanlık ilişkilendirme
     "WHERE Hasta.e_posta = @e_posta", baglanti);




            
            komut.Parameters.AddWithValue("@e_posta", e_postasi); // E-posta parametresi ekleme
            baglanti.Open(); // Bağlantıyı aç
            SqlDataReader reader = komut.ExecuteReader(); // Sorguyu çalıştır
           
           



            // ListBox'ı temizleyelim
            listBox1.Items.Clear();




            // Verileri ListBox'a ekleyelim
            while (reader.Read())
            {




                int randevu_id = Convert.ToInt32(reader["randevu_id"]);
                string hastaIsim = reader["hasta_isim"].ToString(); // Hasta ismi
                string hastaSoyisim = reader["hasta_soy_isim"].ToString(); // Hasta soyadı
                string doktorIsim = reader["doktor_isim"].ToString(); // Doktor ismi
                string doktorSoyisim = reader["doktor_soy_isim"].ToString(); // Doktor soyadı
                string doktorUzmanlik = reader["doktor_uzmanlik"].ToString(); // Doktor uzmanlık bilgisi
                DateTime randevuTarihi = Convert.ToDateTime(reader["randevu_tarihi"]); // Randevu tarihi
                string saat = reader["saat"].ToString(); // Randevu saati



                // Veriyi ListBox'a ekleyelim
                string randevuBilgisi = $"   {randevu_id}     {hastaIsim} {hastaSoyisim} - {doktorIsim} {doktorSoyisim} - {doktorUzmanlik} | {randevuTarihi.ToShortDateString()} {saat}";
                listBox1.Items.Add(randevuBilgisi);  // ListBox'a veriyi ekle
            }




            // Bağlantıyı kapat
            baglanti.Close();








        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi kullanici = new Kullanici_Girisi(kullaniciisim,kullaniciID,e_postasi);
            this.Hide();
            kullanici.Show();

        }






        private void button1_Click(object sender, EventArgs e)
        {
            // Toplantı linkini bir string olarak tanımlayın
            string meetUrl = TxtUrlAl.Text;

            // Toplantı linki boş mu kontrol et
            if (string.IsNullOrEmpty(meetUrl))
            {
                MessageBox.Show("Toplantı linki bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ListBox'tan seçilen randevu_id'yi al
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir randevu seçin.");
                return;
            }

            string selectedItem = listBox1.SelectedItem.ToString();
            string[] itemParts = selectedItem.Trim().Split(' ');
            if (itemParts.Length < 2 || !int.TryParse(itemParts[0], out int randevuId))
            {
                MessageBox.Show("Seçilen randevudan kimlik bilgisi alınamadı. Lütfen tekrar deneyin.");
                return;
            }

            // Veritabanından silme işlemi
            {
                try
                {
                    baglanti.Open();

                  

                    // Tbl_Randevu tablosundan randevu_id ile eşleşen kayıtları sil
                    SqlCommand silRandevuKomutu = new SqlCommand("DELETE FROM Tbl_Randevu WHERE randevu_id = @randevu_id", baglanti);
                    silRandevuKomutu.Parameters.AddWithValue("@randevu_id", randevuId);
                    silRandevuKomutu.ExecuteNonQuery();

                    MessageBox.Show("Randevunuza Yönlendiriliyorsunuz");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }

            // URL'yi tarayıcıda aç
            Process.Start(new ProcessStartInfo
            {
                FileName = meetUrl,
                UseShellExecute = true // Varsayılan tarayıcıda aç
            });

            // ListBox'tan seçili öğeyi kaldır
            listBox1.Items.Remove(listBox1.SelectedItem);
        }



        private void BtnRandevuGrn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir randevu seçin.");
                return;
            }

            // ListBox'tan seçilen randevu_id'yi al
            string selectedItem = listBox1.SelectedItem.ToString();
            string[] itemParts = selectedItem.Trim().Split(' ');
            if (itemParts.Length < 2 || !int.TryParse(itemParts[0], out int randevuId))
            {
                MessageBox.Show("Seçilen randevudan kimlik bilgisi alınamadı. Lütfen tekrar deneyin.");
                return;
            }

            // Veritabanında randevu_id için URL kontrolü
             {
                SqlCommand komut = new SqlCommand("SELECT randevu_url FROM Tbl_Randevu WHERE randevu_id = @randevu_id", baglanti);
                komut.Parameters.AddWithValue("@randevu_id", randevuId);

                try
                {
                    baglanti.Open();
                    SqlDataReader reader = komut.ExecuteReader();

                    TxtUrlAl.Text = ""; // Mevcut metni temizle

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TxtUrlAl.Text += reader["randevu_url"].ToString() + Environment.NewLine;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu randevunuz için aktif bir Url yok ya da randevunuz henüz başlamamış");
                    }

                    reader.Close(); // Reader'ı manuel olarak kapatın
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı manuel olarak kapatın
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }
        }






        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçin.");
                return;
            }

            // Seçilen öğeden randevu_id'yi al
            string selectedItem = listBox1.SelectedItem.ToString();

            // Boşluklarla ayırarak ilk parçayı (randevu_id) al
            string[] itemParts = selectedItem.Trim().Split(' '); // Trim ile baştaki/sondaki boşlukları temizleriz
            int randevuId;
            if (!int.TryParse(itemParts[0], out randevuId)) // İlk parçayı (randevu_id) tamsayıya dönüştürmeyi deniyoruz
            {
                MessageBox.Show("Randevu kimliği geçerli bir sayı değil. Lütfen doğru bir randevu seçin.");
                return;
            }
            // Veritabanından silme işlemi
            {
                SqlCommand silme_komutu = new SqlCommand("DELETE FROM Tbl_Randevu WHERE randevu_id = @id", baglanti);
                silme_komutu.Parameters.AddWithValue("@id", randevuId);

                try
                {
                    baglanti.Open();
                    silme_komutu.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla silindi.");
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }

            }
        }





        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
