namespace VeriGuvenligi13
{
    partial class YeniUye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.geriDonButon = new System.Windows.Forms.Button();
            this.btnYeniUye = new System.Windows.Forms.Button();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.nickTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reSifreTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreGosterCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // geriDonButon
            // 
            this.geriDonButon.Location = new System.Drawing.Point(180, 133);
            this.geriDonButon.Name = "geriDonButon";
            this.geriDonButon.Size = new System.Drawing.Size(94, 43);
            this.geriDonButon.TabIndex = 11;
            this.geriDonButon.Text = "Geri Dön";
            this.geriDonButon.UseVisualStyleBackColor = true;
            this.geriDonButon.Click += new System.EventHandler(this.geriDonButon_Click);
            // 
            // btnYeniUye
            // 
            this.btnYeniUye.Location = new System.Drawing.Point(90, 133);
            this.btnYeniUye.Name = "btnYeniUye";
            this.btnYeniUye.Size = new System.Drawing.Size(84, 41);
            this.btnYeniUye.TabIndex = 10;
            this.btnYeniUye.Text = "Kaydet";
            this.btnYeniUye.UseVisualStyleBackColor = true;
            this.btnYeniUye.Click += new System.EventHandler(this.BtnYeniUye_Click);
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(90, 61);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(100, 20);
            this.sifreTxt.TabIndex = 9;
            // 
            // nickTxt
            // 
            this.nickTxt.Location = new System.Drawing.Point(90, 26);
            this.nickTxt.Name = "nickTxt";
            this.nickTxt.Size = new System.Drawing.Size(100, 20);
            this.nickTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifrem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adım:";
            // 
            // reSifreTxt
            // 
            this.reSifreTxt.Location = new System.Drawing.Point(91, 97);
            this.reSifreTxt.Name = "reSifreTxt";
            this.reSifreTxt.Size = new System.Drawing.Size(100, 20);
            this.reSifreTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifre(tekrar):";
            // 
            // sifreGosterCB
            // 
            this.sifreGosterCB.AutoSize = true;
            this.sifreGosterCB.Location = new System.Drawing.Point(202, 64);
            this.sifreGosterCB.Name = "sifreGosterCB";
            this.sifreGosterCB.Size = new System.Drawing.Size(94, 17);
            this.sifreGosterCB.TabIndex = 14;
            this.sifreGosterCB.Text = "Şifreleri Göster";
            this.sifreGosterCB.UseVisualStyleBackColor = true;
            this.sifreGosterCB.CheckedChanged += new System.EventHandler(this.SifreGosterCB_CheckedChanged);
            // 
            // YeniUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 205);
            this.Controls.Add(this.sifreGosterCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reSifreTxt);
            this.Controls.Add(this.geriDonButon);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.nickTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniUye);
            this.Name = "YeniUye";
            this.Text = "YeniUye";
            this.Load += new System.EventHandler(this.YeniUye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriDonButon;
        private System.Windows.Forms.Button btnYeniUye;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.TextBox nickTxt;
        private System.Windows.Forms.TextBox reSifreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sifreGosterCB;
    }
}