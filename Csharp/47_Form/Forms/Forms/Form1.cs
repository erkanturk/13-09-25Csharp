namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            if (txt_Giris.Text=="Admin"&&txt_Sifre.Text=="1453")
            {
                MessageBox.Show("Form Yapýsýna Hoþgeldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result =MessageBox.Show("Form A Giriþ", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    Anasayfa anasayfa = new Anasayfa();
                    anasayfa.Show();
                    this.Hide();
                }
               
            }
            else
            {
                MessageBox.Show("Hatalý iþlem", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
