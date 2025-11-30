namespace _02_HesapMakinesi
{
    partial class Login
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
            txt_Kullanici = new TextBox();
            txt_Sifre = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_Kullanici
            // 
            txt_Kullanici.Location = new Point(103, 33);
            txt_Kullanici.Name = "txt_Kullanici";
            txt_Kullanici.PlaceholderText = "Kullanıcı Adı";
            txt_Kullanici.Size = new Size(130, 23);
            txt_Kullanici.TabIndex = 0;
            // 
            // txt_Sifre
            // 
            txt_Sifre.Location = new Point(103, 79);
            txt_Sifre.Name = "txt_Sifre";
            txt_Sifre.PlaceholderText = "Şifreniz";
            txt_Sifre.Size = new Size(130, 23);
            txt_Sifre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(126, 120);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 190);
            Controls.Add(button1);
            Controls.Add(txt_Sifre);
            Controls.Add(txt_Kullanici);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Kullanici;
        private TextBox txt_Sifre;
        private Button button1;
    }
}