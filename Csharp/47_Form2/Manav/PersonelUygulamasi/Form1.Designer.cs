namespace PersonelUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lst_Personellerim = new ListBox();
            groupBox1 = new GroupBox();
            btn_kayit = new Button();
            txt_YeniTel = new TextBox();
            txt_YeniEmail = new TextBox();
            txt_YeniSoyad = new TextBox();
            txt_YeniAd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_Sil = new Button();
            txt_GuncelleTel = new TextBox();
            btn_Guncelle = new Button();
            txt_GuncelleEmail = new TextBox();
            label5 = new Label();
            txt_GuncelleSoyad = new TextBox();
            label6 = new Label();
            txt_GuncelleAd = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btn_Listele = new Button();
            btn_Temizle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lst_Personellerim
            // 
            lst_Personellerim.FormattingEnabled = true;
            lst_Personellerim.ItemHeight = 15;
            lst_Personellerim.Location = new Point(1, 0);
            lst_Personellerim.Name = "lst_Personellerim";
            lst_Personellerim.Size = new Size(314, 694);
            lst_Personellerim.TabIndex = 0;
            lst_Personellerim.SelectedIndexChanged += lst_Personellerim_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_kayit);
            groupBox1.Controls.Add(txt_YeniTel);
            groupBox1.Controls.Add(txt_YeniEmail);
            groupBox1.Controls.Add(txt_YeniSoyad);
            groupBox1.Controls.Add(txt_YeniAd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(321, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(759, 298);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Personel";
            // 
            // btn_kayit
            // 
            btn_kayit.Location = new Point(249, 242);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(193, 34);
            btn_kayit.TabIndex = 4;
            btn_kayit.Text = "Kaydet";
            btn_kayit.UseVisualStyleBackColor = true;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // txt_YeniTel
            // 
            txt_YeniTel.Location = new Point(249, 184);
            txt_YeniTel.Name = "txt_YeniTel";
            txt_YeniTel.PlaceholderText = "Telefon Numaranız";
            txt_YeniTel.Size = new Size(193, 30);
            txt_YeniTel.TabIndex = 3;
            // 
            // txt_YeniEmail
            // 
            txt_YeniEmail.Location = new Point(249, 132);
            txt_YeniEmail.Name = "txt_YeniEmail";
            txt_YeniEmail.PlaceholderText = "Email Adres";
            txt_YeniEmail.Size = new Size(193, 30);
            txt_YeniEmail.TabIndex = 2;
            // 
            // txt_YeniSoyad
            // 
            txt_YeniSoyad.Location = new Point(249, 84);
            txt_YeniSoyad.Name = "txt_YeniSoyad";
            txt_YeniSoyad.PlaceholderText = "Soyadınız";
            txt_YeniSoyad.Size = new Size(193, 30);
            txt_YeniSoyad.TabIndex = 1;
            // 
            // txt_YeniAd
            // 
            txt_YeniAd.Location = new Point(249, 37);
            txt_YeniAd.Name = "txt_YeniAd";
            txt_YeniAd.PlaceholderText = "Adınız";
            txt_YeniAd.Size = new Size(193, 30);
            txt_YeniAd.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 188);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 3;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 136);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 88);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 1;
            label2.Text = "Soyisim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 37);
            label1.Name = "label1";
            label1.Size = new Size(41, 23);
            label1.TabIndex = 0;
            label1.Text = "Isim";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Sil);
            groupBox2.Controls.Add(txt_GuncelleTel);
            groupBox2.Controls.Add(btn_Guncelle);
            groupBox2.Controls.Add(txt_GuncelleEmail);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_GuncelleSoyad);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_GuncelleAd);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(321, 334);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(759, 307);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Güncelle";
            // 
            // btn_Sil
            // 
            btn_Sil.Location = new Point(359, 242);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(92, 35);
            btn_Sil.TabIndex = 11;
            btn_Sil.Text = "Sil";
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += btn_Sil_Click;
            // 
            // txt_GuncelleTel
            // 
            txt_GuncelleTel.Location = new Point(259, 193);
            txt_GuncelleTel.Name = "txt_GuncelleTel";
            txt_GuncelleTel.PlaceholderText = "Telefon Numaranız";
            txt_GuncelleTel.Size = new Size(193, 30);
            txt_GuncelleTel.TabIndex = 9;
            // 
            // btn_Guncelle
            // 
            btn_Guncelle.Location = new Point(259, 242);
            btn_Guncelle.Name = "btn_Guncelle";
            btn_Guncelle.Size = new Size(94, 35);
            btn_Guncelle.TabIndex = 10;
            btn_Guncelle.Text = "Güncelle";
            btn_Guncelle.UseVisualStyleBackColor = true;
            btn_Guncelle.Click += btn_Guncelle_Click;
            // 
            // txt_GuncelleEmail
            // 
            txt_GuncelleEmail.Location = new Point(259, 141);
            txt_GuncelleEmail.Name = "txt_GuncelleEmail";
            txt_GuncelleEmail.PlaceholderText = "Email Adres";
            txt_GuncelleEmail.Size = new Size(193, 30);
            txt_GuncelleEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 46);
            label5.Name = "label5";
            label5.Size = new Size(41, 23);
            label5.TabIndex = 0;
            label5.Text = "Isim";
            // 
            // txt_GuncelleSoyad
            // 
            txt_GuncelleSoyad.Location = new Point(259, 93);
            txt_GuncelleSoyad.Name = "txt_GuncelleSoyad";
            txt_GuncelleSoyad.PlaceholderText = "Soyadınız";
            txt_GuncelleSoyad.Size = new Size(193, 30);
            txt_GuncelleSoyad.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 97);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 1;
            label6.Text = "Soyisim";
            // 
            // txt_GuncelleAd
            // 
            txt_GuncelleAd.Location = new Point(259, 46);
            txt_GuncelleAd.Name = "txt_GuncelleAd";
            txt_GuncelleAd.PlaceholderText = "Adınız";
            txt_GuncelleAd.Size = new Size(193, 30);
            txt_GuncelleAd.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 145);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 2;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(151, 197);
            label8.Name = "label8";
            label8.Size = new Size(65, 23);
            label8.TabIndex = 3;
            label8.Text = "Telefon";
            // 
            // btn_Listele
            // 
            btn_Listele.Location = new Point(580, 645);
            btn_Listele.Name = "btn_Listele";
            btn_Listele.Size = new Size(94, 35);
            btn_Listele.TabIndex = 12;
            btn_Listele.Text = "Listele";
            btn_Listele.UseVisualStyleBackColor = true;
            btn_Listele.Click += btn_Listele_Click;
            // 
            // btn_Temizle
            // 
            btn_Temizle.Location = new Point(680, 645);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new Size(92, 35);
            btn_Temizle.TabIndex = 13;
            btn_Temizle.Text = "Temizle";
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 692);
            Controls.Add(btn_Temizle);
            Controls.Add(groupBox2);
            Controls.Add(btn_Listele);
            Controls.Add(groupBox1);
            Controls.Add(lst_Personellerim);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_Personellerim;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_kayit;
        private TextBox txt_YeniTel;
        private TextBox txt_YeniEmail;
        private TextBox txt_YeniSoyad;
        private TextBox txt_YeniAd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Sil;
        private TextBox txt_GuncelleTel;
        private Button btn_Guncelle;
        private TextBox txt_GuncelleEmail;
        private Label label5;
        private TextBox txt_GuncelleSoyad;
        private Label label6;
        private TextBox txt_GuncelleAd;
        private Label label7;
        private Label label8;
        private Button btn_Listele;
        private Button btn_Temizle;
    }
}
