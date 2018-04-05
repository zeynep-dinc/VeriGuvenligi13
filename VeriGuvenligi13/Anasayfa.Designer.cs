namespace VeriGuvenligi13
{
    partial class Anasayfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.cevrilmisLstbx = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cevirBtn = new System.Windows.Forms.Button();
            this.cevrilecekTxt = new System.Windows.Forms.TextBox();
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çevirmek istediğiniz metni giriniz";
            // 
            // cevrilmisLstbx
            // 
            this.cevrilmisLstbx.FormattingEnabled = true;
            this.cevrilmisLstbx.HorizontalScrollbar = true;
            this.cevrilmisLstbx.Location = new System.Drawing.Point(12, 167);
            this.cevrilmisLstbx.Name = "cevrilmisLstbx";
            this.cevrilmisLstbx.Size = new System.Drawing.Size(499, 225);
            this.cevrilmisLstbx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çevrilmiş hali";
            // 
            // cevirBtn
            // 
            this.cevirBtn.Location = new System.Drawing.Point(171, 137);
            this.cevirBtn.Name = "cevirBtn";
            this.cevirBtn.Size = new System.Drawing.Size(75, 24);
            this.cevirBtn.TabIndex = 4;
            this.cevirBtn.Text = "Çevir";
            this.cevirBtn.UseVisualStyleBackColor = true;
            this.cevirBtn.Click += new System.EventHandler(this.CevirBtn_Click);
            // 
            // cevrilecekTxt
            // 
            this.cevrilecekTxt.Location = new System.Drawing.Point(171, 53);
            this.cevrilecekTxt.Multiline = true;
            this.cevrilecekTxt.Name = "cevrilecekTxt";
            this.cevrilecekTxt.Size = new System.Drawing.Size(340, 68);
            this.cevrilecekTxt.TabIndex = 5;
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(472, 12);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(39, 23);
            this.cikis.TabIndex = 6;
            this.cikis.Text = "Exit";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.cevrilecekTxt);
            this.Controls.Add(this.cevirBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cevrilmisLstbx);
            this.Controls.Add(this.label1);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox cevrilmisLstbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cevirBtn;
        private System.Windows.Forms.TextBox cevrilecekTxt;
        private System.Windows.Forms.Button cikis;
    }
}