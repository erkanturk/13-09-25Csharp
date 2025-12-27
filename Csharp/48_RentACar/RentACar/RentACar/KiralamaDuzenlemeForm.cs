using RentACar.Data;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentACar
{
    public partial class KiralamaDuzenlemeForm : Form
    {
        private readonly DataContext _context;
        private readonly Kiralama _kiralama;
        private readonly Musteri _musteri;
        public KiralamaDuzenlemeForm(Kiralama kiralama, Musteri musteri)
        {
            InitializeComponent();
            _context = new DataContext();
            _kiralama = kiralama;
            _musteri = musteri;
            //dtp_baslaTarih.MinDate= DateTime.Now;
            //dtp_bitisTarih.MinDate= DateTime.Now.AddDays(1);
        }

        private void KiralamaDuzenlemeForm_Load(object sender, EventArgs e)
        {
            txt_arac.Text=_kiralama.Araba.Marka.Ad+" "+_kiralama.Araba.Model;
            dtp_baslaTarih.Value=_kiralama.BaslangicTarihi.Date;
            dtp_baslaSaat.Value=_kiralama.BaslangicTarihi;
            dtp_bitisSaat.Value=_kiralama.BitisTarihi;
            dtp_bitisTarih.Value=_kiralama.BitisTarihi.Date;
            HesaplaVeGoster();
        }
        private void HesaplaVeGoster()
        {
            DateTime baslangicTarihi = dtp_baslaTarih.Value+dtp_baslaSaat.Value.TimeOfDay;
            DateTime bitisTarihi = dtp_bitisTarih.Value+dtp_bitisSaat.Value.TimeOfDay;
            if (bitisTarihi<=baslangicTarihi)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdırç");
                return;
            }
            TimeSpan fark = bitisTarihi-baslangicTarihi;
            double toplamSaat = fark.TotalHours;
            double saatlikUcret = _kiralama.Araba.SaatlikUcret;
            double toplamTutar = toplamSaat*saatlikUcret;
            txt_toplamSaat.Text=Math.Round(toplamSaat, 2).ToString();
            txt_toplamTutar.Text=toplamTutar.ToString("C2");//100.00
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            HesaplaVeGoster();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            KiralamaForm kiralamaForm = new KiralamaForm(_musteri);
            this.Hide();
            kiralamaForm.Show();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtp_baslaTarih.Value+dtp_baslaSaat.Value.TimeOfDay;
                DateTime bitisTarihi = dtp_bitisTarih.Value+dtp_bitisSaat.Value.TimeOfDay;
                if (bitisTarihi<=baslangicTarihi)
                {
                    MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdırç");
                    return;
                }
                TimeSpan fark = bitisTarihi-baslangicTarihi;
                double toplamSaat = fark.TotalHours;
                double saatlikUcret = _kiralama.Araba.SaatlikUcret;
                double toplamTutar = Math.Round(toplamSaat*saatlikUcret);
                _kiralama.BaslangicTarihi=baslangicTarihi;
                _kiralama.BitisTarihi=bitisTarihi;
                _kiralama.ToplamTutar=toplamTutar;
                _context.Update(_kiralama);
                int deger = _context.SaveChanges();
                if (deger>0)
                {
                    MessageBox.Show("Başarı ile güncellendi");
                    this.Hide();
                    KiralamaForm kiralamaForm = new KiralamaForm(_musteri);
                    kiralamaForm.Show();
                }
                else
                {
                    MessageBox.Show("Bilinmeyen hata");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: "+ex.Message);
               
            }
        }
    }
}
