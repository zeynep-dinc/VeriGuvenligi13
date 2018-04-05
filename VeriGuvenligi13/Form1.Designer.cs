namespace VeriGuvenligi13
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yeniUyeButon = new System.Windows.Forms.LinkLabel();
            this.cBSifre = new System.Windows.Forms.CheckBox();
            this.gonder = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yeniUyeButon
            // 
            this.yeniUyeButon.AutoSize = true;
            this.yeniUyeButon.Location = new System.Drawing.Point(244, 94);
            this.yeniUyeButon.Name = "yeniUyeButon";
            this.yeniUyeButon.Size = new System.Drawing.Size(54, 13);
            this.yeniUyeButon.TabIndex = 15;
            this.yeniUyeButon.TabStop = true;
            this.yeniUyeButon.Text = "Yeni Kayıt";
            this.yeniUyeButon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YeniUyeButon_LinkClicked);
            // 
            // cBSifre
            // 
            this.cBSifre.AutoSize = true;
            this.cBSifre.Location = new System.Drawing.Point(304, 54);
            this.cBSifre.Name = "cBSifre";
            this.cBSifre.Size = new System.Drawing.Size(88, 17);
            this.cBSifre.TabIndex = 13;
            this.cBSifre.Text = "Şifreyi Göster";
            this.cBSifre.UseVisualStyleBackColor = true;
            this.cBSifre.CheckedChanged += new System.EventHandler(this.CBSifre_CheckedChanged);
            // 
            // gonder
            // 
            this.gonder.Location = new System.Drawing.Point(163, 89);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(75, 23);
            this.gonder.TabIndex = 12;
            this.gonder.Text = "Giriş";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(163, 51);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(135, 20);
            this.txtSifre.TabIndex = 11;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(163, 14);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(135, 20);
            this.txtNick.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 126);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 186);
            this.Controls.Add(this.yeniUyeButon);
            this.Controls.Add(this.cBSifre);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel yeniUyeButon;
        private System.Windows.Forms.CheckBox cBSifre;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

