namespace _02_HesapMakinesi
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            mtxt_sayi1 = new MaskedTextBox();
            mtxt_sayi2 = new MaskedTextBox();
            btn_Islem = new Button();
            btn_Temizle = new Button();
            lst_sonuc = new ListBox();
            label3 = new Label();
            cmb_Islem = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(9, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Sayı 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(9, 76);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Sayı 2";
            // 
            // mtxt_sayi1
            // 
            mtxt_sayi1.Font = new Font("Segoe UI", 14.25F);
            mtxt_sayi1.Location = new Point(81, 37);
            mtxt_sayi1.Name = "mtxt_sayi1";
            mtxt_sayi1.Size = new Size(100, 33);
            mtxt_sayi1.TabIndex = 0;
            // 
            // mtxt_sayi2
            // 
            mtxt_sayi2.Font = new Font("Segoe UI", 14.25F);
            mtxt_sayi2.Location = new Point(81, 73);
            mtxt_sayi2.Name = "mtxt_sayi2";
            mtxt_sayi2.Size = new Size(100, 33);
            mtxt_sayi2.TabIndex = 1;
            // 
            // btn_Islem
            // 
            btn_Islem.Font = new Font("Segoe UI", 14.25F);
            btn_Islem.Location = new Point(81, 163);
            btn_Islem.Name = "btn_Islem";
            btn_Islem.Size = new Size(100, 38);
            btn_Islem.TabIndex = 3;
            btn_Islem.Text = "İşlem";
            btn_Islem.UseVisualStyleBackColor = true;
            btn_Islem.Click += btn_Islem_Click;
            // 
            // btn_Temizle
            // 
            btn_Temizle.Font = new Font("Segoe UI", 14.25F);
            btn_Temizle.Location = new Point(81, 207);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new Size(100, 33);
            btn_Temizle.TabIndex = 4;
            btn_Temizle.Text = "Temizle";
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // lst_sonuc
            // 
            lst_sonuc.Font = new Font("Segoe UI", 14.25F);
            lst_sonuc.FormattingEnabled = true;
            lst_sonuc.ItemHeight = 25;
            lst_sonuc.Location = new Point(192, 35);
            lst_sonuc.Name = "lst_sonuc";
            lst_sonuc.Size = new Size(118, 204);
            lst_sonuc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(9, 115);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 1;
            label3.Text = "İşlem";
            // 
            // cmb_Islem
            // 
            cmb_Islem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmb_Islem.FormattingEnabled = true;
            cmb_Islem.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmb_Islem.Location = new Point(81, 115);
            cmb_Islem.Name = "cmb_Islem";
            cmb_Islem.Size = new Size(100, 33);
            cmb_Islem.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(338, 442);
            Controls.Add(cmb_Islem);
            Controls.Add(lst_sonuc);
            Controls.Add(btn_Temizle);
            Controls.Add(btn_Islem);
            Controls.Add(mtxt_sayi2);
            Controls.Add(label3);
            Controls.Add(mtxt_sayi1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public MaskedTextBox mtxt_sayi1;
        public MaskedTextBox mtxt_sayi2;
        public Button btn_Islem;
        public Button btn_Temizle;
        public ListBox lst_sonuc;
        public Label label3;
        public ComboBox cmb_Islem;
    }
}
