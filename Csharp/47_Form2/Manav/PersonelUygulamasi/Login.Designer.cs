namespace PersonelUygulamasi
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
            groupBox1 = new GroupBox();
            btn_GirisYap = new Button();
            txt_Sifre = new TextBox();
            txt_Giris = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_GirisYap);
            groupBox1.Controls.Add(txt_Sifre);
            groupBox1.Controls.Add(txt_Giris);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(184, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sistem Giriş Bilgiler";
            // 
            // btn_GirisYap
            // 
            btn_GirisYap.Location = new Point(137, 140);
            btn_GirisYap.Name = "btn_GirisYap";
            btn_GirisYap.Size = new Size(134, 36);
            btn_GirisYap.TabIndex = 6;
            btn_GirisYap.Text = "Giriş Yap";
            btn_GirisYap.UseVisualStyleBackColor = true;
            btn_GirisYap.Click += btn_GirisYap_Click;
            // 
            // txt_Sifre
            // 
            txt_Sifre.Location = new Point(121, 87);
            txt_Sifre.Name = "txt_Sifre";
            txt_Sifre.PasswordChar = '*';
            txt_Sifre.PlaceholderText = "Şifre";
            txt_Sifre.Size = new Size(170, 33);
            txt_Sifre.TabIndex = 5;
            // 
            // txt_Giris
            // 
            txt_Giris.Location = new Point(121, 49);
            txt_Giris.Name = "txt_Giris";
            txt_Giris.PlaceholderText = "Kullanıcı Adı";
            txt_Giris.Size = new Size(170, 33);
            txt_Giris.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(20, 88);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 3;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(20, 56);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Adı:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.business_avatar_profile_black_icon_man_of_user_symbol_in_trendy_flat_style_isolated_on_male_profile_people_diverse_face_for_social_network_or_web_vector;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 222);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 233);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Sifre;
        private TextBox txt_Giris;
        private Label label3;
        private Label label2;
        private Button btn_GirisYap;
        private PictureBox pictureBox1;
    }
}