using ManavOtomasyon.Data;
using ManavOtomasyon.Models;

namespace ManavOtomasyon
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHalKategori.SelectedIndex=0;
            cmbManavKategori.SelectedIndex=0;
            GuncelleHalUrunler();
            GuncelleManavUrunler();
            Satis();

        }
        private void GuncelleHalUrunler()
        {
            LstHalUrunler.Items.Clear();
            using (var context = new DataContext())
            {
                string kategori = cmbHalKategori.SelectedItem.ToString();
                var urunler = context.Urunler.Where(u => u.Kategori==kategori).ToList();
                foreach (var urun in urunler)
                {
                    LstHalUrunler.Items.Add($"{urun.Ad}-{urun.Stok} kg");
                }

            }
        }
        private void GuncelleManavUrunler()
        {
            lstManavListe.Items.Clear();
            using (var context = new DataContext())
            {
                string kategori = cmbManavKategori.SelectedItem?.ToString();
                var urunler = context.Manavlar.Where(u => u.Kategori==kategori).ToList();
                foreach (var urun in urunler)
                {
                    lstManavListe.Items.Add($"{urun.Ad}-{urun.Stok} kg");
                }

            }
        }
        private void Satis()
        {
            lst_Satis.Items.Clear();
            using (var context = new DataContext())
            {
                var urunler = context.Satislar.Where(s => s.Id==s.Id).ToList();
                foreach (var urun in urunler)
                {
                    lst_Satis.Items.Add($"{urun.UrunAdi}-{urun.Miktar} kg - {urun.SatisTarih}");
                }
            }
        }

        private void btn_halEkle_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string urunAdi = txt_urun.Text.ToUpper();
                string kategori = cmbHalKategori.SelectedItem.ToString();
                if (string.IsNullOrEmpty(urunAdi))
                {
                    MessageBox.Show("Lütfen bir ürün adý giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txt_Halkilo.Text, out int miktar)||miktar<=0)
                {
                    MessageBox.Show("Lütfen geçerli kilo giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var urun = context.Urunler.FirstOrDefault(u => u.Ad==urunAdi&&u.Kategori==kategori);
                if (urun==null)
                {
                    urun=new Urun { Ad=urunAdi, Kategori=kategori, Stok=0 };
                    context.Urunler.Add(urun);
                }
                urun.Stok+=miktar;
                context.SaveChanges();//Database'e git verileri kaydet.
                MessageBox.Show($"{urunAdi}-{miktar} kilo stoða eklendi", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_urun.Clear();
                txt_Halkilo.Clear();
                GuncelleHalUrunler();

            }
        }

        private void cmbHalKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleHalUrunler();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_manavAl_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string secilenUrunFull = LstHalUrunler.SelectedItem?.ToString();
                if (secilenUrunFull==null)
                {
                    MessageBox.Show("Lütfen hal tarafýndan bir ürün seçiniz");
                    return;
                }
                if (!int.TryParse(txt_Halkilo.Text, out int alinacakKilo)||alinacakKilo<=0)
                {
                    MessageBox.Show("Lütfen geçerli bir kilo giriniz");
                    return;
                }
                string[] urunParts = secilenUrunFull.Split('-');
                string secilenUrunAdi = urunParts[0].Trim();
                string kategori = cmbHalKategori.SelectedItem.ToString();
                var halUrunu = context.Urunler.FirstOrDefault(m => m.Ad==secilenUrunAdi&&m.Kategori==kategori);
                if (halUrunu==null)
                {
                    MessageBox.Show("Ürün Bulunamadý.");
                    return;
                }
                if (halUrunu.Stok<alinacakKilo)
                {
                    MessageBox.Show($"Yeterli Stok Yok!!! Elimde bulunan stok: {halUrunu.Stok} kg mevcut ");
                    return;
                }
                var manavUrunu = context.Manavlar.FirstOrDefault(m => m.Ad==secilenUrunAdi&&m.Kategori==kategori);
                if (manavUrunu==null)
                {
                    manavUrunu=new Manav()
                    {
                        Ad=secilenUrunAdi,
                        Kategori=kategori,
                        Stok=0
                    };
                    context.Manavlar.Add(manavUrunu);
                }
                halUrunu.Stok-=alinacakKilo;
                manavUrunu.Stok+=alinacakKilo;
                if (halUrunu.Stok==0)
                {
                    context.Urunler.Remove(halUrunu);
                }
                context.SaveChanges();
                MessageBox.Show($"{secilenUrunAdi}-{alinacakKilo}kg manav stoðuna aktarýldý");
                txt_Halkilo.Clear();
                GuncelleHalUrunler();
                GuncelleManavUrunler();
            }

        }

        private void cmbManavKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleManavUrunler();
        }

        private void btn_HalGuncelle_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string secilenUrunFull = LstHalUrunler.SelectedItem?.ToString();
                if (secilenUrunFull==null)
                {
                    MessageBox.Show("Lütfen bir ürün seçiniz.");
                    return;
                }
                string[] urunParts = secilenUrunFull.Split('-');
                string secilenUrun = urunParts[0].Trim();
                var urun = context.Urunler.FirstOrDefault(u => u.Ad==secilenUrun);
                if (urun==null)
                {
                    MessageBox.Show("Ürün bulunamadý");
                    return;
                }
                if (!int.TryParse(txt_Halkilo.Text, out int yeniKilo)||yeniKilo<0)
                {
                    MessageBox.Show("Lütfen geçerli bir kilo giriniz");
                    return;
                }
                urun.Stok=yeniKilo;
                if (!string.IsNullOrEmpty(txt_urun.Text))
                {
                    urun.Ad=txt_urun.Text.ToString();
                }
                context.SaveChanges();
                MessageBox.Show("Stok baþarý ile güncellendi");
                GuncelleHalUrunler();
                txt_Halkilo.Clear();
                txt_urun.Clear();
            }
        }

        private void btn_HalSil_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string secilenUrunFull = LstHalUrunler.SelectedItem?.ToString();
                if (secilenUrunFull==null)
                {
                    MessageBox.Show("Lütfen bir ürün seçiniz");
                    return;
                }
                string[] urunParts = secilenUrunFull.Split('-');
                string secilenUrun = urunParts[0].Trim();
                var urun = context.Urunler.FirstOrDefault(u => u.Ad==secilenUrun);
                if (urun==null)
                {
                    MessageBox.Show("Ürün bulunamadý");
                    return;
                }
                DialogResult result = MessageBox.Show($"'{secilenUrun}' Ürünü silmek ister misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    context.Urunler.Remove(urun);
                    context.SaveChanges();
                    MessageBox.Show("Ürün baþarý ile silindi");
                    GuncelleHalUrunler();
                }

            }
        }

        private void btn_satisyap_Click(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                string secilenUrunFull = lstManavListe.SelectedItem?.ToString();
                if (secilenUrunFull==null)
                {
                    MessageBox.Show("Bir ürün seçiniz");
                    return;
                }
                string[] urunParts = secilenUrunFull.Split('-');
                string secilenUrun = urunParts[0].Trim();
                if (!int.TryParse(txt_manavKilo.Text, out int kilo)|| kilo<=0)
                {
                    MessageBox.Show("Lütfen geçerli bir kilo giriniz");
                    return;
                }
                var manavUrun = context.Manavlar.FirstOrDefault(u => u.Ad==secilenUrun);
                if (manavUrun==null||manavUrun.Stok<kilo)
                {
                    MessageBox.Show("Yeterli stok yok");
                }
                manavUrun.Stok-=kilo;
                context.Satislar.Add(new Satis()
                {
                    UrunAdi=secilenUrun,
                    Miktar=kilo,
                    SatisTarih=DateTime.Now
                });
                if (manavUrun.Stok==0)
                {
                    context.Manavlar.Remove(manavUrun);
                }
                lstMusteri.Items.Add($"{secilenUrun}-{kilo} kg - {DateTime.Now.ToString("HH:mm")}");
                context.SaveChanges();
                MessageBox.Show("Satýþ baþarýlý");
                txt_manavKilo.Clear();
                GuncelleManavUrunler();
                Satis();
            }
        }
    }
}
