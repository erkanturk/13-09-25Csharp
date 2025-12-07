using PersonelUygulamasi.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelUygulamasi
{
    public partial class Login : Form
    {
        BusinessLayer BLL;
        public Login()
        {
            InitializeComponent();
            BLL = new BusinessLayer();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            int result = BLL.SistemGirisKontrol(txt_Giris.Text.ToUpper(), txt_Sifre.Text.ToUpper());
            if (result==-100)
            {
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Doldurunuz");
            }
            else if (result==0)
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalıdır");
            }
            else
            {
                MessageBox.Show($"Hoşgeldiniz Sayın:{txt_Giris.Text}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
