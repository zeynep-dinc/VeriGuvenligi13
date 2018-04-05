using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeriGuvenligi13
{
    public partial class YeniUye : Form
    {
        public YeniUye()
        {
            InitializeComponent();
        }
        private void YeniUye_Load(object sender, EventArgs e)
        {
            sifreTxt.UseSystemPasswordChar = true;//şifreyi ilk göstermemesi için
            reSifreTxt.UseSystemPasswordChar = true;
            
          }
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-EM9IGMHI;Initial Catalog=Login;Integrated Security=True");
        private void BtnYeniUye_Click(object sender, EventArgs e)
        {
            try
            {
                string sifre = sifreTxt.Text;//şifreyi aldı string olarak
                if (sifre != "" && sifre.Length>=8 && sifre.Length<=16)
                { 
                    sqlConnection.Open();//sql serverı açıyor
                    SqlCommand command1 = new SqlCommand("select * from Kayit where nick='" + nickTxt.Text + "'", sqlConnection);//sorgu cümlesi
                    SqlDataReader dataReader = command1.ExecuteReader();//sorgu cümlesi command1 tabloda arıyor 
                    if (dataReader.Read() || nickTxt.Text == null)
                        isimVar();
                    else
                    {
                        dataReader.Close();// ilk sorgu kapandı

                        if ((reSifreTxt.Text == sifreTxt.Text))//eğer şifreler aynıysa ve null değilse
                        {

                            string gunayyil = Convert.ToString(DateTime.Now);//zamanı aldı
                            Birlestirme birlestirme = new Birlestirme();
                            sifre = birlestirme.birlestirme(sifre, gunayyil);//zamanı ve şifreyi birleştirme classına yolladı
                                                                             //SqlCommand command = new SqlCommand("Insert into Kayit(nick,password) Values(" + nickTxt.Text + "," + sifre + ")", sqlConnection);
                            SqlCommand command = new SqlCommand("Insert into Kayit(nick,password,time) Values(@kul,@sif,@tarih)", sqlConnection);//eklemek için sorgu başladı
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                            command.Parameters.AddWithValue("kul", Convert.ToString(nickTxt.Text));
                            command.Parameters.AddWithValue("sif", Convert.ToString(sifre));
                            command.Parameters.AddWithValue("tarih", DateTime.Now);//değerler eklendi
                            command.ExecuteNonQuery();
                            sqlConnection.Close();
                            Form1 form = new Form1();//işlem tamam ana sayfaya yönlendirildi
                            form.Show();
                            this.Close();
                        }
                        else {
                            MessageBox.Show("Şifreler aynı değil","Uyuşmayan şifreler");
                            dataReader.Close();
                            sqlConnection.Close();
                        }

                    } }
                else
                {
                    MessageBox.Show("Şifreye 8-16 karakter arası olmamlı ve boş değer olamaz", "Eksik şifre");
                    sqlConnection.Close();
                    this.Show();
                }
                    
                
             //   else MessageBox.Show("Hiçbir alan boş bırakılamaz", "Geçersiz ad");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata Mesajı");
                sqlConnection.Close();
            }
         
            }
        private void isimVar()
        {
            MessageBox.Show("Bu isim kullanılamaz", "Geçersiz isim");//Eğer nick kullanılıyorsa uyarı mesajı veriyor ve yeni bir isim için bekliyor
            sqlConnection.Close();// tekrar sorgu açılabilmesi için ilk sorgu kapanıyor
            this.Show();//tekrar bekliyor
        }
        
        private void SifreGosterCB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sifreGosterCB.Checked)
                {
                    sifreGosterCB.Text = "Şifreyi Gösterme";
                    sifreTxt.UseSystemPasswordChar = false;
                    reSifreTxt.UseSystemPasswordChar = false;
                }
                else
                {
                    sifreGosterCB.Text = "Şifreyi Göster";
                    sifreTxt.UseSystemPasswordChar = true;
                    reSifreTxt.UseSystemPasswordChar = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void geriDonButon_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
