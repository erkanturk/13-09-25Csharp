using PersonelUygulamasi.BLL;
using PersonelUygulamasi.Entities;

namespace PersonelUygulamasi
{
    public partial class Form1 : Form
    {
        BusinessLayer BLL;
        int sonuc;
        public Form1()
        {
            InitializeComponent();
            BLL=new BusinessLayer();
        }


        private void btn_kayit_Click(object sender, EventArgs e)
        {
            sonuc =BLL.PersonelKayit(txt_YeniAd.Text, txt_YeniSoyad.Text, txt_YeniEmail.Text, txt_YeniTel.Text);
            if (sonuc==-100)
            {
                MessageBox.Show("Boþ Alanlarý Doldurunuz");
                return;
            }
            else if (sonuc==1)
            {
                MessageBox.Show("Kayýt baþarýlý");
                PersonelDoldur();
            }
            else if (sonuc==-101)
            {
                MessageBox.Show("Bu email ve tel kullanýlýyor");
                return;
            }
            else
            {
                MessageBox.Show("Bilinmeyen bir hata");
            }

        }
        private void PersonelDoldur()
        {
            try
            {
                List<Personel> personeller = BLL.PersonelListele();
                lst_Personellerim.DataSource=null;
                lst_Personellerim.DataSource=personeller;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: "+ex.Message);
                throw;
            }
        }
        private void PersonelDoldur1()
        {
            try
            {
                List<Personel1> personeller = BLL.PersonelListele1();
                lst_Personellerim.DataSource=null;
                lst_Personellerim.DataSource=personeller;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: "+ex.Message);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelDoldur();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (lst_Personellerim.SelectedItem==null)
            {
                MessageBox.Show("Lütfen bir personel seçiniz");
                return;
            }
            Personel seciliPersonel = (Personel)lst_Personellerim.SelectedItem;
            int sonuc = BLL.PersonelSil(seciliPersonel.Id);
            if (sonuc>0)
            {
                MessageBox.Show("Silme iþlemi baþarýlý");
                PersonelDoldur();
            }
            else
            {
                MessageBox.Show("Bir hata ile karþýlaþýldý");
            }


        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (lst_Personellerim.SelectedItem==null)
            {
                MessageBox.Show("Lütfen Güncellenecek Personeli Seçin");
                return;
            }
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_GuncelleAd.Text))
            {
                txt_GuncelleAd.BackColor= Color.Red;
                isValid= false;
            }
            else
            {
                txt_GuncelleAd.BackColor= Color.White;
                isValid= true;
            }


            if (string.IsNullOrEmpty(txt_GuncelleSoyad.Text))
            {
                txt_GuncelleSoyad.BackColor= Color.Red;
                isValid= false;
            }
            else
            {
                txt_GuncelleSoyad.BackColor= Color.White;
                isValid= true;
            }
            if (string.IsNullOrEmpty(txt_GuncelleEmail.Text))
            {
                txt_GuncelleEmail.BackColor= Color.Red;
                isValid= false;
            }
            else
            {
                txt_GuncelleEmail.BackColor= Color.White;
                isValid= true;
            }
            if (string.IsNullOrEmpty(txt_GuncelleTel.Text))
            {
                txt_GuncelleTel.BackColor= Color.Red;
                isValid= false;
            }
            else
            {
                txt_GuncelleTel.BackColor= Color.White;
                isValid= true;
            }
            if (!isValid)
            {
                MessageBox.Show("Lütfen boþ alanlarý doldurun");
                return;
            }
            Personel seciliPersonel = (Personel)lst_Personellerim.SelectedItem;
            sonuc=BLL.PersonelGuncelle(
                seciliPersonel.Id,
                txt_GuncelleAd.Text,
                txt_GuncelleSoyad.Text,
                txt_GuncelleEmail.Text,
                txt_GuncelleTel.Text

                );
            if (sonuc>0)
            {
                MessageBox.Show("Güncelleme baþarýlý");
                PersonelDoldur();
                txt_GuncelleAd.Clear();
                txt_GuncelleSoyad.Clear();
                txt_GuncelleEmail.Clear();
                txt_GuncelleTel.Clear();
            }
            else
            {
                MessageBox.Show("Güncelleme Sýrasýnda Hata Oluþtu");
                return;
            }

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            PersonelDoldur1();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            List<Personel> personeller = BLL.PersonelListele2();
            lst_Personellerim.DataSource=null;
            txt_YeniAd.Clear();
            txt_YeniEmail.Clear();
            txt_YeniSoyad.Clear();
            txt_YeniTel.Clear();
            txt_GuncelleTel.Clear();
            txt_GuncelleSoyad.Clear();
            txt_GuncelleEmail.Clear();
            txt_GuncelleAd.Clear();
        }

        private void lst_Personellerim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel seciliPersonel = (Personel)lst_Personellerim.SelectedItem;
            if (sonuc>0)
            {
                txt_GuncelleTel.Clear();
                txt_GuncelleSoyad.Clear();
                txt_GuncelleEmail.Clear();
                txt_GuncelleAd.Clear();
            }
            else if (sonuc==0)
            {
                txt_GuncelleTel.Clear();
                txt_GuncelleSoyad.Clear();
                txt_GuncelleEmail.Clear();
                txt_GuncelleAd.Clear();
            }
            else
            {
                txt_GuncelleAd.Text= seciliPersonel.Isim;
                txt_GuncelleSoyad.Text=seciliPersonel.Soyisim;
                txt_GuncelleEmail.Text=seciliPersonel.Email;
                txt_GuncelleTel.Text=seciliPersonel.Telefon;
            }
        }
    }
}
