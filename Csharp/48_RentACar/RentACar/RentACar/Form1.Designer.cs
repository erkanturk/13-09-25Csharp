namespace RentACar
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
            label1 = new Label();
            label2 = new Label();
            txt_kMarka = new TextBox();
            btn_kMarka = new Button();
            cmb_markalar = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_kModel = new TextBox();
            txt_kPlaka = new TextBox();
            txt_kUcret = new TextBox();
            mtxt_yil = new MaskedTextBox();
            Aktif = new CheckBox();
            Pasif = new CheckBox();
            btn_geriDon = new Button();
            btn_aracEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(364, 40);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "Markalar";
            // 
            // txt_kMarka
            // 
            txt_kMarka.Font = new Font("Segoe UI", 12F);
            txt_kMarka.Location = new Point(90, 32);
            txt_kMarka.Name = "txt_kMarka";
            txt_kMarka.Size = new Size(150, 29);
            txt_kMarka.TabIndex = 2;
            // 
            // btn_kMarka
            // 
            btn_kMarka.Font = new Font("Segoe UI", 12F);
            btn_kMarka.Location = new Point(91, 69);
            btn_kMarka.Name = "btn_kMarka";
            btn_kMarka.Size = new Size(149, 38);
            btn_kMarka.TabIndex = 3;
            btn_kMarka.Text = "Kaydet";
            btn_kMarka.UseVisualStyleBackColor = true;
            btn_kMarka.Click += btn_kMarka_Click;
            // 
            // cmb_markalar
            // 
            cmb_markalar.Font = new Font("Segoe UI", 12F);
            cmb_markalar.FormattingEnabled = true;
            cmb_markalar.Location = new Point(463, 37);
            cmb_markalar.Name = "cmb_markalar";
            cmb_markalar.Size = new Size(121, 29);
            cmb_markalar.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(364, 86);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 5;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(364, 135);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 6;
            label4.Text = "Plaka";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(364, 180);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 7;
            label5.Text = "SaatlikUcret";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(364, 227);
            label6.Name = "label6";
            label6.Size = new Size(27, 21);
            label6.TabIndex = 8;
            label6.Text = "Yıl";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(364, 279);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 9;
            label7.Text = "Aktif";
            // 
            // txt_kModel
            // 
            txt_kModel.Font = new Font("Segoe UI", 12F);
            txt_kModel.Location = new Point(463, 83);
            txt_kModel.Name = "txt_kModel";
            txt_kModel.Size = new Size(121, 29);
            txt_kModel.TabIndex = 10;
            // 
            // txt_kPlaka
            // 
            txt_kPlaka.Font = new Font("Segoe UI", 12F);
            txt_kPlaka.Location = new Point(463, 135);
            txt_kPlaka.Name = "txt_kPlaka";
            txt_kPlaka.Size = new Size(121, 29);
            txt_kPlaka.TabIndex = 11;
            // 
            // txt_kUcret
            // 
            txt_kUcret.Font = new Font("Segoe UI", 12F);
            txt_kUcret.Location = new Point(463, 180);
            txt_kUcret.Name = "txt_kUcret";
            txt_kUcret.Size = new Size(121, 29);
            txt_kUcret.TabIndex = 12;
            // 
            // mtxt_yil
            // 
            mtxt_yil.Font = new Font("Segoe UI", 12F);
            mtxt_yil.Location = new Point(463, 227);
            mtxt_yil.Mask = "0000";
            mtxt_yil.Name = "mtxt_yil";
            mtxt_yil.Size = new Size(121, 29);
            mtxt_yil.TabIndex = 13;
            mtxt_yil.ValidatingType = typeof(int);
            // 
            // Aktif
            // 
            Aktif.AutoSize = true;
            Aktif.Font = new Font("Segoe UI", 12F);
            Aktif.Location = new Point(444, 278);
            Aktif.Name = "Aktif";
            Aktif.Size = new Size(61, 25);
            Aktif.TabIndex = 14;
            Aktif.Text = "Aktif";
            Aktif.UseVisualStyleBackColor = true;
            // 
            // Pasif
            // 
            Pasif.AutoSize = true;
            Pasif.Font = new Font("Segoe UI", 12F);
            Pasif.Location = new Point(540, 278);
            Pasif.Name = "Pasif";
            Pasif.Size = new Size(61, 25);
            Pasif.TabIndex = 15;
            Pasif.Text = "Pasif";
            Pasif.UseVisualStyleBackColor = true;
            // 
            // btn_geriDon
            // 
            btn_geriDon.Location = new Point(34, 360);
            btn_geriDon.Name = "btn_geriDon";
            btn_geriDon.Size = new Size(92, 31);
            btn_geriDon.TabIndex = 17;
            btn_geriDon.Text = "Geri";
            btn_geriDon.UseVisualStyleBackColor = true;
            btn_geriDon.Click += btn_geriDon_Click;
            // 
            // btn_aracEkle
            // 
            btn_aracEkle.Location = new Point(463, 360);
            btn_aracEkle.Name = "btn_aracEkle";
            btn_aracEkle.Size = new Size(109, 36);
            btn_aracEkle.TabIndex = 18;
            btn_aracEkle.Text = "Araç Ekle";
            btn_aracEkle.UseVisualStyleBackColor = true;
            btn_aracEkle.Click += btn_aracEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.rent_a_car_kasko_özserneo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(637, 446);
            Controls.Add(btn_aracEkle);
            Controls.Add(btn_geriDon);
            Controls.Add(Pasif);
            Controls.Add(Aktif);
            Controls.Add(mtxt_yil);
            Controls.Add(txt_kUcret);
            Controls.Add(txt_kPlaka);
            Controls.Add(txt_kModel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmb_markalar);
            Controls.Add(btn_kMarka);
            Controls.Add(txt_kMarka);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_kMarka;
        private Button btn_kMarka;
        private ComboBox cmb_markalar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_kModel;
        private TextBox txt_kPlaka;
        private TextBox txt_kUcret;
        private MaskedTextBox mtxt_yil;
        private CheckBox Aktif;
        private CheckBox Pasif;
        private Button btn_geriDon;
        private Button btn_aracEkle;
    }
}
