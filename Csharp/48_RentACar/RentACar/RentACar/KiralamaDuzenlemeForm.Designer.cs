namespace RentACar
{
    partial class KiralamaDuzenlemeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_arac = new TextBox();
            dtp_baslaTarih = new DateTimePicker();
            dtp_baslaSaat = new DateTimePicker();
            dtp_bitisTarih = new DateTimePicker();
            dtp_bitisSaat = new DateTimePicker();
            txt_toplamSaat = new TextBox();
            txt_toplamTutar = new TextBox();
            btn_hesapla = new Button();
            btn_iptal = new Button();
            btn_kaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Araç:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 66);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 1;
            label2.Text = "Kiralama Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 111);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Başlangıç Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 155);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 220);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "Toplam Saat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 262);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Toplam Tutar";
            // 
            // txt_arac
            // 
            txt_arac.Location = new Point(110, 19);
            txt_arac.Name = "txt_arac";
            txt_arac.ReadOnly = true;
            txt_arac.Size = new Size(141, 23);
            txt_arac.TabIndex = 6;
            // 
            // dtp_baslaTarih
            // 
            dtp_baslaTarih.Format = DateTimePickerFormat.Short;
            dtp_baslaTarih.Location = new Point(110, 111);
            dtp_baslaTarih.Name = "dtp_baslaTarih";
            dtp_baslaTarih.Size = new Size(106, 23);
            dtp_baslaTarih.TabIndex = 7;
            // 
            // dtp_baslaSaat
            // 
            dtp_baslaSaat.Format = DateTimePickerFormat.Time;
            dtp_baslaSaat.Location = new Point(222, 111);
            dtp_baslaSaat.Name = "dtp_baslaSaat";
            dtp_baslaSaat.Size = new Size(94, 23);
            dtp_baslaSaat.TabIndex = 8;
            // 
            // dtp_bitisTarih
            // 
            dtp_bitisTarih.Format = DateTimePickerFormat.Short;
            dtp_bitisTarih.Location = new Point(110, 152);
            dtp_bitisTarih.Name = "dtp_bitisTarih";
            dtp_bitisTarih.Size = new Size(104, 23);
            dtp_bitisTarih.TabIndex = 9;
            // 
            // dtp_bitisSaat
            // 
            dtp_bitisSaat.Format = DateTimePickerFormat.Time;
            dtp_bitisSaat.Location = new Point(222, 152);
            dtp_bitisSaat.Name = "dtp_bitisSaat";
            dtp_bitisSaat.Size = new Size(92, 23);
            dtp_bitisSaat.TabIndex = 10;
            // 
            // txt_toplamSaat
            // 
            txt_toplamSaat.Location = new Point(110, 217);
            txt_toplamSaat.Name = "txt_toplamSaat";
            txt_toplamSaat.ReadOnly = true;
            txt_toplamSaat.Size = new Size(120, 23);
            txt_toplamSaat.TabIndex = 11;
            // 
            // txt_toplamTutar
            // 
            txt_toplamTutar.Location = new Point(110, 262);
            txt_toplamTutar.Name = "txt_toplamTutar";
            txt_toplamTutar.ReadOnly = true;
            txt_toplamTutar.Size = new Size(118, 23);
            txt_toplamTutar.TabIndex = 12;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Location = new Point(241, 217);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(75, 23);
            btn_hesapla.TabIndex = 13;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // btn_iptal
            // 
            btn_iptal.Location = new Point(241, 262);
            btn_iptal.Name = "btn_iptal";
            btn_iptal.Size = new Size(75, 23);
            btn_iptal.TabIndex = 14;
            btn_iptal.Text = "İptal";
            btn_iptal.UseVisualStyleBackColor = true;
            btn_iptal.Click += btn_iptal_Click;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(127, 307);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(75, 23);
            btn_kaydet.TabIndex = 15;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // KiralamaDuzenlemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1916729901_612x612;
            ClientSize = new Size(583, 374);
            Controls.Add(btn_kaydet);
            Controls.Add(btn_iptal);
            Controls.Add(btn_hesapla);
            Controls.Add(txt_toplamTutar);
            Controls.Add(txt_toplamSaat);
            Controls.Add(dtp_bitisSaat);
            Controls.Add(dtp_bitisTarih);
            Controls.Add(dtp_baslaSaat);
            Controls.Add(dtp_baslaTarih);
            Controls.Add(txt_arac);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KiralamaDuzenlemeForm";
            Text = "KiralamaDuzenlemeForm";
            Load += KiralamaDuzenlemeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_arac;
        private DateTimePicker dtp_baslaTarih;
        private DateTimePicker dtp_baslaSaat;
        private DateTimePicker dtp_bitisTarih;
        private DateTimePicker dtp_bitisSaat;
        private TextBox txt_toplamSaat;
        private TextBox txt_toplamTutar;
        private Button btn_hesapla;
        private Button btn_iptal;
        private Button btn_kaydet;
    }
}