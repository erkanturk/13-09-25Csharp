namespace ManavOtomasyon
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
            Hal = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            cmbHalKategori = new ComboBox();
            label1 = new Label();
            lstHalUrunler = new ListBox();
            txt_urun = new TextBox();
            txt_halKilo = new TextBox();
            btn_HalEkle = new Button();
            btn_ManavAl = new Button();
            btn_HalGuncelle = new Button();
            btn_HalSil = new Button();
            btn_Cikis = new Button();
            label2 = new Label();
            cmbManavKategori = new ComboBox();
            lstManavListe = new ListBox();
            lstMusteri = new ListBox();
            lstSatis = new ListBox();
            txt_manavKilo = new TextBox();
            btn_SatisYap = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Hal.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Hal
            // 
            Hal.Controls.Add(tabPage1);
            Hal.Controls.Add(tabPage2);
            Hal.Location = new Point(-1, -2);
            Hal.Name = "Hal";
            Hal.SelectedIndex = 0;
            Hal.Size = new Size(803, 529);
            Hal.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btn_HalSil);
            tabPage1.Controls.Add(btn_HalGuncelle);
            tabPage1.Controls.Add(btn_ManavAl);
            tabPage1.Controls.Add(btn_HalEkle);
            tabPage1.Controls.Add(txt_halKilo);
            tabPage1.Controls.Add(txt_urun);
            tabPage1.Controls.Add(lstHalUrunler);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cmbHalKategori);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 501);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hal-Toptancı";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btn_SatisYap);
            tabPage2.Controls.Add(txt_manavKilo);
            tabPage2.Controls.Add(lstSatis);
            tabPage2.Controls.Add(lstMusteri);
            tabPage2.Controls.Add(lstManavListe);
            tabPage2.Controls.Add(cmbManavKategori);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 501);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manav";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbHalKategori
            // 
            cmbHalKategori.FormattingEnabled = true;
            cmbHalKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbHalKategori.Location = new Point(74, 17);
            cmbHalKategori.Name = "cmbHalKategori";
            cmbHalKategori.Size = new Size(121, 23);
            cmbHalKategori.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // lstHalUrunler
            // 
            lstHalUrunler.FormattingEnabled = true;
            lstHalUrunler.ItemHeight = 15;
            lstHalUrunler.Location = new Point(18, 75);
            lstHalUrunler.Name = "lstHalUrunler";
            lstHalUrunler.Size = new Size(252, 274);
            lstHalUrunler.TabIndex = 2;
            // 
            // txt_urun
            // 
            txt_urun.Location = new Point(18, 372);
            txt_urun.Name = "txt_urun";
            txt_urun.Size = new Size(100, 23);
            txt_urun.TabIndex = 3;
            // 
            // txt_halKilo
            // 
            txt_halKilo.Location = new Point(141, 372);
            txt_halKilo.Name = "txt_halKilo";
            txt_halKilo.Size = new Size(100, 23);
            txt_halKilo.TabIndex = 4;
            // 
            // btn_HalEkle
            // 
            btn_HalEkle.Location = new Point(23, 419);
            btn_HalEkle.Name = "btn_HalEkle";
            btn_HalEkle.Size = new Size(75, 23);
            btn_HalEkle.TabIndex = 5;
            btn_HalEkle.Text = "Hal Ekle";
            btn_HalEkle.UseVisualStyleBackColor = true;
            // 
            // btn_ManavAl
            // 
            btn_ManavAl.Location = new Point(150, 419);
            btn_ManavAl.Name = "btn_ManavAl";
            btn_ManavAl.Size = new Size(75, 23);
            btn_ManavAl.TabIndex = 6;
            btn_ManavAl.Text = "Manav Al";
            btn_ManavAl.UseVisualStyleBackColor = true;
            // 
            // btn_HalGuncelle
            // 
            btn_HalGuncelle.Location = new Point(23, 448);
            btn_HalGuncelle.Name = "btn_HalGuncelle";
            btn_HalGuncelle.Size = new Size(75, 23);
            btn_HalGuncelle.TabIndex = 7;
            btn_HalGuncelle.Text = "Güncelle";
            btn_HalGuncelle.UseVisualStyleBackColor = true;
            // 
            // btn_HalSil
            // 
            btn_HalSil.Location = new Point(150, 448);
            btn_HalSil.Name = "btn_HalSil";
            btn_HalSil.Size = new Size(75, 23);
            btn_HalSil.TabIndex = 8;
            btn_HalSil.Text = "Sil";
            btn_HalSil.UseVisualStyleBackColor = true;
            // 
            // btn_Cikis
            // 
            btn_Cikis.Location = new Point(713, 533);
            btn_Cikis.Name = "btn_Cikis";
            btn_Cikis.Size = new Size(75, 23);
            btn_Cikis.TabIndex = 1;
            btn_Cikis.Text = "Çıkış";
            btn_Cikis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 30);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Kategori";
            // 
            // cmbManavKategori
            // 
            cmbManavKategori.FormattingEnabled = true;
            cmbManavKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbManavKategori.Location = new Point(71, 27);
            cmbManavKategori.Name = "cmbManavKategori";
            cmbManavKategori.Size = new Size(121, 23);
            cmbManavKategori.TabIndex = 1;
            // 
            // lstManavListe
            // 
            lstManavListe.FormattingEnabled = true;
            lstManavListe.ItemHeight = 15;
            lstManavListe.Location = new Point(19, 77);
            lstManavListe.Name = "lstManavListe";
            lstManavListe.Size = new Size(173, 214);
            lstManavListe.TabIndex = 2;
            // 
            // lstMusteri
            // 
            lstMusteri.FormattingEnabled = true;
            lstMusteri.ItemHeight = 15;
            lstMusteri.Location = new Point(451, 67);
            lstMusteri.Name = "lstMusteri";
            lstMusteri.Size = new Size(314, 169);
            lstMusteri.TabIndex = 3;
            // 
            // lstSatis
            // 
            lstSatis.FormattingEnabled = true;
            lstSatis.ItemHeight = 15;
            lstSatis.Location = new Point(393, 363);
            lstSatis.Name = "lstSatis";
            lstSatis.Size = new Size(372, 94);
            lstSatis.TabIndex = 4;
            // 
            // txt_manavKilo
            // 
            txt_manavKilo.Location = new Point(62, 310);
            txt_manavKilo.Name = "txt_manavKilo";
            txt_manavKilo.Size = new Size(100, 23);
            txt_manavKilo.TabIndex = 5;
            // 
            // btn_SatisYap
            // 
            btn_SatisYap.Location = new Point(71, 356);
            btn_SatisYap.Name = "btn_SatisYap";
            btn_SatisYap.Size = new Size(75, 23);
            btn_SatisYap.TabIndex = 6;
            btn_SatisYap.Text = "Satış Yap";
            btn_SatisYap.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 38);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 7;
            label3.Text = "Müşterinin Aldığı Ürünler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 318);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Satılan Ürünler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 314);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 9;
            label5.Text = "Kilo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 354);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 9;
            label6.Text = "Ürün Ekle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 354);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 10;
            label7.Text = "Ürün Kilo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(btn_Cikis);
            Controls.Add(Hal);
            Name = "Form1";
            Text = "Form1";
            Hal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Hal;
        private TabPage tabPage1;
        private ListBox lstHalUrunler;
        private Label label1;
        private ComboBox cmbHalKategori;
        private TabPage tabPage2;
        private Label label7;
        private Label label6;
        private Button btn_HalSil;
        private Button btn_HalGuncelle;
        private Button btn_ManavAl;
        private Button btn_HalEkle;
        private TextBox txt_halKilo;
        private TextBox txt_urun;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_SatisYap;
        private TextBox txt_manavKilo;
        private ListBox lstSatis;
        private ListBox lstMusteri;
        private ListBox lstManavListe;
        private ComboBox cmbManavKategori;
        private Label label2;
        private Button btn_Cikis;
    }
}
