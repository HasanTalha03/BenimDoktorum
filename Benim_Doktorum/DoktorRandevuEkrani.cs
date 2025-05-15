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
using System.Windows.Forms.VisualStyles;

namespace Benim_Doktorum
{

   
    public partial class DoktorRandevuEkrani : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DCMV86R\\SQLEXPRESS;Initial Catalog=Benim_Doktorum;Integrated Security=True;Encrypt=False");
      
        private int hasta_id;
        private String doktor_isim;
        private int doktor_id;
        private String doktor_e_postasi;

        public DoktorRandevuEkrani(String isim, int id, String e_posta)
        {
            this.doktor_isim = isim;
            this.doktor_id = id;
            this.doktor_e_postasi = e_posta;

            InitializeComponent();
        }

        private void DoktorRandevuEkrani_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand(
                 "SELECT Tbl_Hasta.id AS hasta_id, Tbl_Hasta.isim AS hasta_isim, Tbl_Hasta.soy_isim AS hasta_soy_isim, " +
                 "Tbl_Doktor.isim AS doktor_isim, Tbl_Doktor.soy_isim AS doktor_soy_isim, " +
                 "Tbl_Uzmanlik.uzmanlik AS doktor_uzmanlik, Tbl_Randevu.randevu_tarihi, Tbl_Randevu.saat,Tbl_Randevu.randevu_id " +
                 "FROM Tbl_Randevu " +
                 "INNER JOIN Tbl_Hasta ON Tbl_Randevu.hasta_id = Tbl_Hasta.id " +
                 "INNER JOIN Tbl_Doktor ON Tbl_Randevu.doktor_id = Tbl_Doktor.id " +
                 "INNER JOIN Tbl_Uzmanlik ON Tbl_Doktor.uzmanlik = Tbl_Uzmanlik.id " +
                       "WHERE Tbl_Doktor.e_posta = @e_posta", baglanti);
            komut.Parameters.AddWithValue("@e_posta", doktor_e_postasi);
            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            
            // ListBox'ı temizleyelim
            listBox1.Items.Clear();

            // Verileri ListBox'a ekleyelim
            while (reader.Read())
            {
                int randevu_id = Convert.ToInt32(reader["randevu_id"]);
                string hastaIsim = reader["hasta_isim"].ToString();
                string hastaSoyisim = reader["hasta_soy_isim"].ToString();
                string doktorIsim = reader["doktor_isim"].ToString();
                string doktorSoyisim = reader["doktor_soy_isim"].ToString();  // Doktor soyadı eklendi
                string doktorUzmanlik = reader["doktor_uzmanlik"].ToString();  // Doktor uzmanlık eklendi
                DateTime randevuTarihi = Convert.ToDateTime(reader["randevu_tarihi"]);
                string saat = reader["saat"].ToString();
                hasta_id = Convert.ToInt32(reader["hasta_id"]);

                // Boşluk bırakmak için: 
                string randevuBilgisi = $" {randevu_id}                      {hastaIsim}      {hastaSoyisim}       -                    {doktorIsim}        {doktorSoyisim}              -               {doktorUzmanlik}  | {randevuTarihi.ToShortDateString()}          {saat}";
                listBox1.Items.Add(randevuBilgisi);

            }

            // Bağlantıyı kapat
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor_Girisi giris = new Doktor_Girisi(doktor_isim, doktor_id, doktor_e_postasi);
            this.Hide();
            giris.Show();
        }







        private void BtnRandevuBaslat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen başlatmak istediğiniz randevuyu seçin.");
                return;
            }

            // ListBox'tan randevu_id ve hasta_id'yi al
            string selectedItem = listBox1.SelectedItem.ToString();
            string[] itemParts = selectedItem.Trim().Split(' '); // Boşluklarla ayrıştır
            if (itemParts.Length < 2 || !int.TryParse(itemParts[0], out int randevuId))
            {
                MessageBox.Show("Seçilen randevudan kimlik bilgisi alınamadı. Lütfen tekrar deneyin.");
                return;
            }

            // randevu_id'ye göre hasta_id'yi al
           {
                SqlCommand komut = new SqlCommand("SELECT hasta_id FROM Tbl_Randevu WHERE randevu_id = @randevu_id", baglanti);
                komut.Parameters.AddWithValue("@randevu_id", randevuId);

                baglanti.Open();
                object result = komut.ExecuteScalar(); // hasta_id'yi al
                baglanti.Close();

                if (result == null)
                {
                    MessageBox.Show("Hasta bilgisi alınamadı. Lütfen tekrar deneyin.");
                    return;
                }

                // Hasta ID ve URL işlemleri
                int hastaId = Convert.ToInt32(result);
                TxtUrl.Visible = true;
                BtnUrlKaydet.Visible = true;

                // Google Meet yeni toplantı URL'sini aç
                string meetUrl = "https://meet.google.com/new";
                Process.Start(new ProcessStartInfo
                {
                    FileName = meetUrl,
                    UseShellExecute = true // Varsayılan tarayıcıda aç
                });

                // Buton durumu kontrolü
                if (isButtonClicked)
                {
                    MessageBox.Show($"Randevunuz başlatıldı ve hasta ID: {hastaId} için URL gönderildi.");
                }
                else
                {
                    MessageBox.Show("Lütfen hastaya URL'yi gönderiniz.");
                }
            }
        }









        private bool isButtonClicked = false;




        private void BtnUrlKaydet_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir randevu seçin.");
                return;
            }

            // ListBox'tan randevu_id'yi al
            string selectedItem = listBox1.SelectedItem.ToString();
            string[] itemParts = selectedItem.Trim().Split(' ');
            if (itemParts.Length < 2 || !int.TryParse(itemParts[0], out int randevuId))
            {
                MessageBox.Show("Seçilen randevudan kimlik bilgisi alınamadı. Lütfen tekrar deneyin.");
                return;
            }

            // Veritabanına URL kaydet
           
                SqlCommand komut = new SqlCommand(
                    "UPDATE Tbl_Randevu SET randevu_url = @p1 WHERE randevu_id = @p2",
                    baglanti);

            


                komut.Parameters.AddWithValue("@p1", TxtUrl.Text); // Kullanıcının yazdığı URL
                komut.Parameters.AddWithValue("@p2", randevuId);  // ListBox'tan alınan randevu_id


                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show($"Randevu ID: {randevuId} için URL kaydedildi.");
    isButtonClicked = true;
            Application.Exit();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
