namespace _02_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mtxt_sayi1.Visible=false;
            mtxt_sayi2.Visible=false;
            label1.Visible=false;
            label2.Visible=false;
            label3.Visible=false;
            cmb_Islem.Visible=false;
            lst_sonuc.Visible=false;
            btn_Islem.Visible =false;
            btn_Temizle.Enabled=false;
            Soru();
        }

        private void btn_Islem_Click(object sender, EventArgs e)
        {
            
            double sayi1, sayi2, sonuc = 0;
            if (cmb_Islem.Text=="+")
            {
                cmb_Islem.BackColor=Color.White;
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);
                sonuc=sayi1+sayi2;
                lst_sonuc.Items.Add(sonuc);
            }
            else if (cmb_Islem.Text=="-")
            {
                cmb_Islem.BackColor=Color.White;
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);
                sonuc=sayi1-sayi2;
                lst_sonuc.Items.Add(sonuc);
            }
            else if (cmb_Islem.Text=="*")
            {
                cmb_Islem.BackColor=Color.White;
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);
                sonuc=sayi1*sayi2;
                lst_sonuc.Items.Add(sonuc);
            }
            else if (cmb_Islem.Text=="/")
            {
                cmb_Islem.BackColor=Color.White;
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);

                if (sayi2>sayi1)
                {
                    MessageBox.Show("Bölen bölünenden büyük olamaz");
                }
                else if (sayi2==0)
                {
                    MessageBox.Show("Sayý 0 A Bölünemez");

                }
                else
                {
                    sonuc=sayi1/sayi2;
                    lst_sonuc.Items.Add(sonuc);
                }
            }
            else
            {
                MessageBox.Show("Bir iþlem seçiniz");
                cmb_Islem.BackColor= Color.Red;
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            lst_sonuc.Items.Clear();
            mtxt_sayi1.Clear();
            mtxt_sayi2.Clear();
            cmb_Islem.SelectedIndex=-1;
        }
        public DialogResult Soru()
        {
            DialogResult result = MessageBox.Show("Ýþlem Mi yapacaksýnýz ?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
    }
}
