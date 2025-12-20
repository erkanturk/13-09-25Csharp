namespace RentACar
{
    partial class ArabaForm
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
            cmb_listele = new ComboBox();
            btn_arabaGetir = new Button();
            btn_kiralamalar = new Button();
            dtg_arabalar = new DataGridView();
            groupBox1 = new GroupBox();
            dtp_tSaat = new DateTimePicker();
            dtp_tTarih = new DateTimePicker();
            dtp_kSaat = new DateTimePicker();
            dtp_kTarih = new DateTimePicker();
            txt_toplamTutar = new TextBox();
            txt_toplamSaat = new TextBox();
            txt_kAraba = new TextBox();
            btn_hesapla = new Button();
            btn_kirala = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_arabalar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Arabalar";
            // 
            // cmb_listele
            // 
            cmb_listele.FormattingEnabled = true;
            cmb_listele.Location = new Point(92, 43);
            cmb_listele.Name = "cmb_listele";
            cmb_listele.Size = new Size(173, 23);
            cmb_listele.TabIndex = 1;
            // 
            // btn_arabaGetir
            // 
            btn_arabaGetir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_arabaGetir.Location = new Point(112, 72);
            btn_arabaGetir.Name = "btn_arabaGetir";
            btn_arabaGetir.Size = new Size(120, 31);
            btn_arabaGetir.TabIndex = 2;
            btn_arabaGetir.Text = "Araba Getir";
            btn_arabaGetir.UseVisualStyleBackColor = true;
            btn_arabaGetir.Click += btn_arabaGetir_Click;
            // 
            // btn_kiralamalar
            // 
            btn_kiralamalar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_kiralamalar.Location = new Point(112, 113);
            btn_kiralamalar.Name = "btn_kiralamalar";
            btn_kiralamalar.Size = new Size(120, 34);
            btn_kiralamalar.TabIndex = 2;
            btn_kiralamalar.Text = "Kiralamalar";
            btn_kiralamalar.UseVisualStyleBackColor = true;
            btn_kiralamalar.Click += btn_kiralamalar_Click;
            // 
            // dtg_arabalar
            // 
            dtg_arabalar.BackgroundColor = SystemColors.ButtonHighlight;
            dtg_arabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_arabalar.Location = new Point(-6, 153);
            dtg_arabalar.Name = "dtg_arabalar";
            dtg_arabalar.Size = new Size(525, 516);
            dtg_arabalar.TabIndex = 3;
            dtg_arabalar.DoubleClick += dtg_arabalar_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dtp_tSaat);
            groupBox1.Controls.Add(dtp_tTarih);
            groupBox1.Controls.Add(dtp_kSaat);
            groupBox1.Controls.Add(dtp_kTarih);
            groupBox1.Controls.Add(txt_toplamTutar);
            groupBox1.Controls.Add(txt_toplamSaat);
            groupBox1.Controls.Add(txt_kAraba);
            groupBox1.Controls.Add(btn_hesapla);
            groupBox1.Controls.Add(btn_kirala);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(698, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 666);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Yöntemi";
            // 
            // dtp_tSaat
            // 
            dtp_tSaat.Format = DateTimePickerFormat.Time;
            dtp_tSaat.Location = new Point(316, 186);
            dtp_tSaat.Name = "dtp_tSaat";
            dtp_tSaat.Size = new Size(127, 29);
            dtp_tSaat.TabIndex = 13;
            // 
            // dtp_tTarih
            // 
            dtp_tTarih.Format = DateTimePickerFormat.Short;
            dtp_tTarih.Location = new Point(163, 186);
            dtp_tTarih.Name = "dtp_tTarih";
            dtp_tTarih.Size = new Size(144, 29);
            dtp_tTarih.TabIndex = 12;
            // 
            // dtp_kSaat
            // 
            dtp_kSaat.Format = DateTimePickerFormat.Time;
            dtp_kSaat.Location = new Point(316, 135);
            dtp_kSaat.Name = "dtp_kSaat";
            dtp_kSaat.Size = new Size(127, 29);
            dtp_kSaat.TabIndex = 11;
            // 
            // dtp_kTarih
            // 
            dtp_kTarih.Format = DateTimePickerFormat.Short;
            dtp_kTarih.Location = new Point(163, 135);
            dtp_kTarih.Name = "dtp_kTarih";
            dtp_kTarih.Size = new Size(144, 29);
            dtp_kTarih.TabIndex = 10;
            // 
            // txt_toplamTutar
            // 
            txt_toplamTutar.Location = new Point(163, 277);
            txt_toplamTutar.Name = "txt_toplamTutar";
            txt_toplamTutar.ReadOnly = true;
            txt_toplamTutar.Size = new Size(181, 29);
            txt_toplamTutar.TabIndex = 9;
            // 
            // txt_toplamSaat
            // 
            txt_toplamSaat.Location = new Point(163, 229);
            txt_toplamSaat.Name = "txt_toplamSaat";
            txt_toplamSaat.ReadOnly = true;
            txt_toplamSaat.Size = new Size(181, 29);
            txt_toplamSaat.TabIndex = 8;
            // 
            // txt_kAraba
            // 
            txt_kAraba.Location = new Point(163, 86);
            txt_kAraba.Name = "txt_kAraba";
            txt_kAraba.ReadOnly = true;
            txt_kAraba.Size = new Size(200, 29);
            txt_kAraba.TabIndex = 7;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Location = new Point(294, 379);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(106, 34);
            btn_hesapla.TabIndex = 6;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // btn_kirala
            // 
            btn_kirala.Location = new Point(163, 379);
            btn_kirala.Name = "btn_kirala";
            btn_kirala.Size = new Size(102, 34);
            btn_kirala.TabIndex = 5;
            btn_kirala.Text = "Kirala";
            btn_kirala.UseVisualStyleBackColor = true;
            btn_kirala.Click += btn_kirala_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 280);
            label6.Name = "label6";
            label6.Size = new Size(119, 22);
            label6.TabIndex = 4;
            label6.Text = "Toplam Tutar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 232);
            label5.Name = "label5";
            label5.Size = new Size(115, 22);
            label5.TabIndex = 3;
            label5.Text = "Toplam Saat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 186);
            label4.Name = "label4";
            label4.Size = new Size(114, 22);
            label4.TabIndex = 2;
            label4.Text = "Teslim Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 135);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 1;
            label3.Text = "Kiralama Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 0;
            label2.Text = "Araç";
            // 
            // ArabaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bertan_rent_acar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1194, 681);
            Controls.Add(groupBox1);
            Controls.Add(dtg_arabalar);
            Controls.Add(btn_kiralamalar);
            Controls.Add(btn_arabaGetir);
            Controls.Add(cmb_listele);
            Controls.Add(label1);
            Name = "ArabaForm";
            Text = "ArabaForm";
            Load += ArabaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_arabalar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_listele;
        private Button btn_arabaGetir;
        private Button btn_kiralamalar;
        private DataGridView dtg_arabalar;
        private GroupBox groupBox1;
        private DateTimePicker dtp_tSaat;
        private DateTimePicker dtp_tTarih;
        private DateTimePicker dtp_kSaat;
        private DateTimePicker dtp_kTarih;
        private TextBox txt_toplamTutar;
        private TextBox txt_toplamSaat;
        private TextBox txt_kAraba;
        private Button btn_hesapla;
        private Button btn_kirala;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}