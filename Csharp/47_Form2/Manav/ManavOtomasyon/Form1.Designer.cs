using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            btn_HalSil = new Button();
            btn_HalGuncelle = new Button();
            btn_manavAl = new Button();
            btn_halEkle = new Button();
            label3 = new Label();
            label2 = new Label();
            txt_Halkilo = new TextBox();
            txt_urun = new TextBox();
            LstHalUrunler = new ListBox();
            cmbHalKategori = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            lstMusteri = new ListBox();
            label6 = new Label();
            btn_satisyap = new Button();
            txt_manavKilo = new TextBox();
            label5 = new Label();
            lstManavListe = new ListBox();
            cmbManavKategori = new ComboBox();
            label4 = new Label();
            btn_cikis = new Button();
            lst_Satis = new ListBox();
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
            Hal.Location = new Point(3, -1);
            Hal.Name = "Hal";
            Hal.SelectedIndex = 0;
            Hal.Size = new Size(785, 571);
            Hal.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_HalSil);
            tabPage1.Controls.Add(btn_HalGuncelle);
            tabPage1.Controls.Add(btn_manavAl);
            tabPage1.Controls.Add(btn_halEkle);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_Halkilo);
            tabPage1.Controls.Add(txt_urun);
            tabPage1.Controls.Add(LstHalUrunler);
            tabPage1.Controls.Add(cmbHalKategori);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(777, 543);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hal-Toptancı";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_HalSil
            // 
            btn_HalSil.Location = new Point(145, 420);
            btn_HalSil.Name = "btn_HalSil";
            btn_HalSil.Size = new Size(75, 23);
            btn_HalSil.TabIndex = 10;
            btn_HalSil.Text = "Sil";
            btn_HalSil.UseVisualStyleBackColor = true;
            
            // 
            // btn_HalGuncelle
            // 
            btn_HalGuncelle.Location = new Point(8, 420);
            btn_HalGuncelle.Name = "btn_HalGuncelle";
            btn_HalGuncelle.Size = new Size(75, 23);
            btn_HalGuncelle.TabIndex = 9;
            btn_HalGuncelle.Text = "Güncelle";
            btn_HalGuncelle.UseVisualStyleBackColor = true;
           
            // 
            // btn_manavAl
            // 
            btn_manavAl.Location = new Point(145, 381);
            btn_manavAl.Name = "btn_manavAl";
            btn_manavAl.Size = new Size(75, 23);
            btn_manavAl.TabIndex = 8;
            btn_manavAl.Text = "Manav Al";
            btn_manavAl.UseVisualStyleBackColor = true;
           
            // 
            // btn_halEkle
            // 
            btn_halEkle.Location = new Point(8, 381);
            btn_halEkle.Name = "btn_halEkle";
            btn_halEkle.Size = new Size(75, 23);
            btn_halEkle.TabIndex = 7;
            btn_halEkle.Text = "Hal Ekle";
            btn_halEkle.UseVisualStyleBackColor = true;
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 327);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Ürün Kilo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 327);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Ürün Ekle";
            // 
            // txt_Halkilo
            // 
            txt_Halkilo.Location = new Point(145, 345);
            txt_Halkilo.Name = "txt_Halkilo";
            txt_Halkilo.Size = new Size(121, 23);
            txt_Halkilo.TabIndex = 4;
            // 
            // txt_urun
            // 
            txt_urun.Location = new Point(7, 345);
            txt_urun.Name = "txt_urun";
            txt_urun.Size = new Size(121, 23);
            txt_urun.TabIndex = 3;
            // 
            // LstHalUrunler
            // 
            LstHalUrunler.FormattingEnabled = true;
            LstHalUrunler.ItemHeight = 15;
            LstHalUrunler.Location = new Point(6, 56);
            LstHalUrunler.Name = "LstHalUrunler";
            LstHalUrunler.Size = new Size(269, 259);
            LstHalUrunler.TabIndex = 2;
            // 
            // cmbHalKategori
            // 
            cmbHalKategori.FormattingEnabled = true;
            cmbHalKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbHalKategori.Location = new Point(72, 15);
            cmbHalKategori.Name = "cmbHalKategori";
            cmbHalKategori.Size = new Size(121, 23);
            cmbHalKategori.TabIndex = 1;
            cmbHalKategori.SelectedIndexChanged += cmbHalKategori_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(lst_Satis);
            tabPage2.Controls.Add(lstMusteri);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btn_satisyap);
            tabPage2.Controls.Add(txt_manavKilo);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(lstManavListe);
            tabPage2.Controls.Add(cmbManavKategori);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(777, 543);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manav";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstMusteri
            // 
            lstMusteri.FormattingEnabled = true;
            lstMusteri.ItemHeight = 15;
            lstMusteri.Location = new Point(460, 62);
            lstMusteri.Name = "lstMusteri";
            lstMusteri.Size = new Size(285, 289);
            lstMusteri.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 26);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 6;
            label6.Text = "Müşterinin aldığı ürünler";
            // 
            // btn_satisyap
            // 
            btn_satisyap.Location = new Point(89, 436);
            btn_satisyap.Name = "btn_satisyap";
            btn_satisyap.Size = new Size(115, 23);
            btn_satisyap.TabIndex = 5;
            btn_satisyap.Text = "Satış Yap";
            btn_satisyap.UseVisualStyleBackColor = true;
            
            // 
            // txt_manavKilo
            // 
            txt_manavKilo.Location = new Point(70, 381);
            txt_manavKilo.Name = "txt_manavKilo";
            txt_manavKilo.Size = new Size(140, 23);
            txt_manavKilo.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 389);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 3;
            label5.Text = "Kilo";
            // 
            // lstManavListe
            // 
            lstManavListe.FormattingEnabled = true;
            lstManavListe.ItemHeight = 15;
            lstManavListe.Location = new Point(30, 70);
            lstManavListe.Name = "lstManavListe";
            lstManavListe.Size = new Size(180, 289);
            lstManavListe.TabIndex = 2;
            // 
            // cmbManavKategori
            // 
            cmbManavKategori.FormattingEnabled = true;
            cmbManavKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbManavKategori.Location = new Point(89, 21);
            cmbManavKategori.Name = "cmbManavKategori";
            cmbManavKategori.Size = new Size(121, 23);
            cmbManavKategori.TabIndex = 1;
            cmbManavKategori.SelectedIndexChanged += cmbManavKategori_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 24);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 0;
            label4.Text = "Kategori";
            // 
            // btn_cikis
            // 
            btn_cikis.Location = new Point(702, 581);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(75, 23);
            btn_cikis.TabIndex = 1;
            btn_cikis.Text = "Çıkış";
            btn_cikis.UseVisualStyleBackColor = true;
           
            // 
            // lst_Satis
            // 
            lst_Satis.FormattingEnabled = true;
            lst_Satis.ItemHeight = 15;
            lst_Satis.Location = new Point(252, 399);
            lst_Satis.Name = "lst_Satis";
            lst_Satis.Size = new Size(505, 124);
            lst_Satis.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(313, 381);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 9;
            label7.Text = "Satılan Ürünler";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 607);
            Controls.Add(btn_cikis);
            Controls.Add(Hal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Button btn_HalSil;
        private Button btn_HalGuncelle;
        private Button btn_manavAl;
        private Button btn_halEkle;
        private Label label3;
        private Label label2;
        private TextBox txt_Halkilo;
        private TextBox txt_urun;
        private ListBox LstHalUrunler;
        private ComboBox cmbHalKategori;
        private Label label1;
        private TabPage tabPage2;
        private ListBox lstMusteri;
        private Label label6;
        private Button btn_satisyap;
        private TextBox txt_manavKilo;
        private Label label5;
        private ListBox lstManavListe;
        private ComboBox cmbManavKategori;
        private Label label4;
        private Button btn_cikis;
        private Label label7;
        private ListBox lst_Satis;
    }
}
