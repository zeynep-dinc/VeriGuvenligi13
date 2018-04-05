using System;
using System.Windows.Forms;

namespace VeriGuvenligi13
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void CevirBtn_Click(object sender, EventArgs e)
        {//Burada kullanıcı uygulamaya girdikten sonra kendi kodumdan bir yöntemle sayısal değere çeviriyor girdiği değerleri 
            try
            {
                string ceviri = cevrilecekTxt.Text;
                Sifreleme sifreleme = new Sifreleme();
                ceviri = sifreleme.sifreleme(ceviri);
                cevrilmisLstbx.Items.Add(ceviri);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            }

        private void Cikis_Click(object sender, EventArgs e)
        {//login ekranına dönüyor
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
