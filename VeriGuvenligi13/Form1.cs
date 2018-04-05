using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeriGuvenligi13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Kendi sql server isminizi yazarsanız hocam veri tabanı düzgün şekilde çalışır 
        private SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-EM9IGMHI;Initial Catalog=Login;Integrated Security=True");

        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }

        private void Gonder_Click(object sender, EventArgs e)
        {
            string sifre = txtSifre.Text;
                try
                {
                if (txtNick.Text == null || sifre == null)
                {
                    MessageBox.Show("Ad veya şifre boş olamaz!", "Boş bırakılan bilgi");
                }
                else if (sifre.Length >= 8 && sifre.Length <= 16 && sifre!=null)
                {//Şifre uzunluk ve boşluk kontrolü
                    Birlestirme birlestirme = new Birlestirme();
                    string sifreHash;
                    string mesaj;
                    SqlConnection.Open();//sql bağlantısı açıldı
                    SqlCommand command1 = new SqlCommand("select * from Kayit where nick='" + txtNick.Text +"'", SqlConnection);//isim sorgusu yapılıyor
                    command1.ExecuteNonQuery();
                    SqlDataReader dataReader1 = command1.ExecuteReader();//sorgu başlatıldı okunuyor
                    if (dataReader1.Read())//okuma başarılıysa
                    {//veri tabanında sorgudan tarihi buluyor
                        mesaj = dataReader1["time"].ToString();//zamanı buldu,aldı mesaj türünde çevirdi
                        dataReader1.Close();//ilk sorgu okuması kapatıldı
                        sifreHash = birlestirme.birlestirme(sifre, mesaj);//sınıfa yollayıp şifreliyor
                        SqlCommand command = new SqlCommand("select * from Kayit where nick='" + txtNick.Text + "' and password='" + sifreHash + "'", SqlConnection);//nick ve şifre eşleşiyor mu sorgusu oluşturuldu
                        SqlDataReader dataReader = command.ExecuteReader();
                        if (dataReader.Read())
                        {
                            Anasayfa anasayfa = new Anasayfa();
                            anasayfa.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Şifreyi ya da Kullanıcı Adınızı tekrar giriniz!", "Yanlış Bilgi");
                        dataReader.Close();
                        SqlConnection.Close();
                    }

                    else MessageBox.Show("Giriş Başarısız");//İsim tabloda yoksa başarısız
                    SqlConnection.Close();

                }
                else MessageBox.Show("Şifre 8 ile 16 karakter arasında olmalı", "Geçersiz şifre");//eksik karakterde hata veriyor

            }            
                catch (Exception hata) { 
                
                    MessageBox.Show(hata.Message);
                }
            
        }
        private void YeniUyeButon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//Yeni Üye ekranına gönderiliyor
            this.Hide();
            YeniUye yeniUye = new YeniUye();
            yeniUye.Show();
        }

        private void CBSifre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cBSifre.Checked)
                {
                    cBSifre.Text = "Şifreyi Gösterme";
                    txtSifre.UseSystemPasswordChar = false;
                }
                else
                {
                    cBSifre.Text = "Şifreyi Göster";
                    txtSifre.UseSystemPasswordChar = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e) => txtSifre.UseSystemPasswordChar = true;//şifreyi ilk göstermemesi için
    }
}
