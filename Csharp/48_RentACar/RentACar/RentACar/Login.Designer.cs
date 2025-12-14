namespace RentACar
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
            txt_GirisTel = new MaskedTextBox();
            btn_GirisYap = new Button();
            txt_GirisSifre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txt_kPhone = new MaskedTextBox();
            btn_KayitOl = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txt_kRePassword = new TextBox();
            txt_kPassword = new TextBox();
            txt_kEmail = new TextBox();
            txt_kAdSoyad = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txt_GirisTel);
            groupBox1.Controls.Add(btn_GirisYap);
            groupBox1.Controls.Add(txt_GirisSifre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(18, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 199);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş";
            // 
            // txt_GirisTel
            // 
            txt_GirisTel.Location = new Point(129, 38);
            txt_GirisTel.Mask = "0000000000";
            txt_GirisTel.Name = "txt_GirisTel";
            txt_GirisTel.Size = new Size(170, 26);
            txt_GirisTel.TabIndex = 1;
            txt_GirisTel.ValidatingType = typeof(int);
            // 
            // btn_GirisYap
            // 
            btn_GirisYap.Location = new Point(146, 139);
            btn_GirisYap.Name = "btn_GirisYap";
            btn_GirisYap.Size = new Size(117, 27);
            btn_GirisYap.TabIndex = 3;
            btn_GirisYap.Text = "Giriş Yap";
            btn_GirisYap.UseVisualStyleBackColor = true;
            // 
            // txt_GirisSifre
            // 
            txt_GirisSifre.Location = new Point(129, 91);
            txt_GirisSifre.Name = "txt_GirisSifre";
            txt_GirisSifre.PasswordChar = '*';
            txt_GirisSifre.Size = new Size(167, 26);
            txt_GirisSifre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 91);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 0;
            label1.Text = "Telefon";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txt_kPhone);
            groupBox2.Controls.Add(btn_KayitOl);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_kRePassword);
            groupBox2.Controls.Add(txt_kPassword);
            groupBox2.Controls.Add(txt_kEmail);
            groupBox2.Controls.Add(txt_kAdSoyad);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(796, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 658);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kayıt Form";
            // 
            // txt_kPhone
            // 
            txt_kPhone.Location = new Point(188, 101);
            txt_kPhone.Mask = "0000000000";
            txt_kPhone.Name = "txt_kPhone";
            txt_kPhone.Size = new Size(170, 26);
            txt_kPhone.TabIndex = 5;
            txt_kPhone.ValidatingType = typeof(int);
            // 
            // btn_KayitOl
            // 
            btn_KayitOl.Location = new Point(229, 331);
            btn_KayitOl.Name = "btn_KayitOl";
            btn_KayitOl.Size = new Size(102, 31);
            btn_KayitOl.TabIndex = 9;
            btn_KayitOl.Text = "Kayıt Ol";
            btn_KayitOl.UseVisualStyleBackColor = true;
            btn_KayitOl.Click += btn_KayitOl_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 278);
            label7.Name = "label7";
            label7.Size = new Size(91, 18);
            label7.TabIndex = 9;
            label7.Text = "Şifre Tekrarı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 216);
            label6.Name = "label6";
            label6.Size = new Size(41, 18);
            label6.TabIndex = 8;
            label6.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 161);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 104);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 6;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 49);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 5;
            label3.Text = "Ad Soyad";
            // 
            // txt_kRePassword
            // 
            txt_kRePassword.Location = new Point(188, 278);
            txt_kRePassword.Name = "txt_kRePassword";
            txt_kRePassword.PasswordChar = '*';
            txt_kRePassword.Size = new Size(170, 26);
            txt_kRePassword.TabIndex = 8;
            // 
            // txt_kPassword
            // 
            txt_kPassword.Location = new Point(188, 216);
            txt_kPassword.Name = "txt_kPassword";
            txt_kPassword.PasswordChar = '*';
            txt_kPassword.Size = new Size(170, 26);
            txt_kPassword.TabIndex = 7;
            // 
            // txt_kEmail
            // 
            txt_kEmail.Location = new Point(188, 161);
            txt_kEmail.Name = "txt_kEmail";
            txt_kEmail.Size = new Size(170, 26);
            txt_kEmail.TabIndex = 6;
            // 
            // txt_kAdSoyad
            // 
            txt_kAdSoyad.Location = new Point(188, 49);
            txt_kAdSoyad.Name = "txt_kAdSoyad";
            txt_kAdSoyad.Size = new Size(170, 26);
            txt_kAdSoyad.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hazir_rent_a_car;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1198, 693);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_GirisYap;
        private TextBox txt_GirisSifre;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_KayitOl;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_kRePassword;
        private TextBox txt_kPassword;
        private TextBox txt_kEmail;
        private TextBox txt_kAdSoyad;
        private MaskedTextBox txt_kPhone;
        private MaskedTextBox txt_GirisTel;
    }
}