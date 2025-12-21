namespace RentACar
{
    partial class KiralamaForm
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
            dtg_kiralamalar = new DataGridView();
            label1 = new Label();
            btn_yeniKiralama = new Button();
            btn_kiralamaDuzenle = new Button();
            btn_kiralamaSil = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_kiralamalar).BeginInit();
            SuspendLayout();
            // 
            // dtg_kiralamalar
            // 
            dtg_kiralamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_kiralamalar.Location = new Point(4, 29);
            dtg_kiralamalar.Name = "dtg_kiralamalar";
            dtg_kiralamalar.Size = new Size(784, 422);
            dtg_kiralamalar.TabIndex = 0;
            dtg_kiralamalar.SelectionChanged += dtg_kiralamalar_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(9, 5);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 1;
            label1.Text = "Kiramala İşlemleri";
            // 
            // btn_yeniKiralama
            // 
            btn_yeniKiralama.Location = new Point(8, 457);
            btn_yeniKiralama.Name = "btn_yeniKiralama";
            btn_yeniKiralama.Size = new Size(97, 32);
            btn_yeniKiralama.TabIndex = 2;
            btn_yeniKiralama.Text = "Yeni Kirala";
            btn_yeniKiralama.UseVisualStyleBackColor = true;
            btn_yeniKiralama.Click += btn_yeniKiralama_Click;
            // 
            // btn_kiralamaDuzenle
            // 
            btn_kiralamaDuzenle.Location = new Point(111, 457);
            btn_kiralamaDuzenle.Name = "btn_kiralamaDuzenle";
            btn_kiralamaDuzenle.Size = new Size(97, 32);
            btn_kiralamaDuzenle.TabIndex = 2;
            btn_kiralamaDuzenle.Text = "Düzenle";
            btn_kiralamaDuzenle.UseVisualStyleBackColor = true;
            btn_kiralamaDuzenle.Click += btn_kiralamaDuzenle_Click;
            // 
            // btn_kiralamaSil
            // 
            btn_kiralamaSil.Location = new Point(214, 457);
            btn_kiralamaSil.Name = "btn_kiralamaSil";
            btn_kiralamaSil.Size = new Size(97, 32);
            btn_kiralamaSil.TabIndex = 2;
            btn_kiralamaSil.Text = "Sil";
            btn_kiralamaSil.UseVisualStyleBackColor = true;
            btn_kiralamaSil.Click += btn_kiralamaSil_Click;
            // 
            // button4
            // 
            button4.Location = new Point(691, 457);
            button4.Name = "button4";
            button4.Size = new Size(97, 32);
            button4.TabIndex = 2;
            button4.Text = "Kapat";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // KiralamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(button4);
            Controls.Add(btn_kiralamaSil);
            Controls.Add(btn_kiralamaDuzenle);
            Controls.Add(btn_yeniKiralama);
            Controls.Add(label1);
            Controls.Add(dtg_kiralamalar);
            Name = "KiralamaForm";
            Text = "KiralamaForm";
            Load += KiralamaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_kiralamalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_kiralamalar;
        private Label label1;
        private Button btn_yeniKiralama;
        private Button btn_kiralamaDuzenle;
        private Button btn_kiralamaSil;
        private Button button4;
    }
}