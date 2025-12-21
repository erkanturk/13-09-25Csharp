using Microsoft.EntityFrameworkCore;
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
    public partial class ArabaForm : Form
    {
        DataContext _context;
        Araba _kiralikAraba;
        Musteri _musteri;
        DateTime finishDate;
        DateTime startDate;
        public ArabaForm(Musteri musteri)
        {

            InitializeComponent();
            _musteri= musteri;
            _context = new DataContext();
            dtp_kTarih.MinDate= DateTime.Now;
            dtp_tTarih.MinDate= DateTime.Now.AddDays(1);


        }

        private void ArabaForm_Load(object sender, EventArgs e)
        {

            DateTime time = DateTime.Now;
            cmb_listele.DataSource=_context.Markalar.ToList();
            cmb_listele.DisplayMember="Ad";
            cmb_listele.ValueMember="Id";
            cmb_listele.SelectedIndex=-1;
            dtp_kSaat.Value=time;
            dtp_kTarih.Value=time;
            dtp_tSaat.Value=time;
            dtp_tTarih.Value=time.AddDays(1);
            YukleAktifArac();


        }
        private void YukleAktifArac()
        {
            var arabalist = _context.Arabalar.Where(a => a.Aktif)
                .Include(i => i.Marka)
                .Select(a => new
                {
                    Model = a.Model,
                    Plaka = a.Plaka,
                    Yil = a.Yil,
                    SaatlikUcret = a.SaatlikUcret,
                    Aktif = a.Aktif,
                    Marka = a.Marka
                }).ToList();
            dtg_arabalar.DataSource=arabalist;

        }

        private void btn_arabaGetir_Click(object sender, EventArgs e)
        {
            cmb_listele.BackColor=Color.White;
            var arabaList = _context.Arabalar.Where(a => a.Aktif).AsQueryable();
            if (cmb_listele.SelectedValue!=null)
            {
                arabaList=arabaList.Where(i => i.MarkaId==(int)cmb_listele.SelectedValue);
            }
            dtg_arabalar.DataSource = arabaList.Include(i => i.Marka).ToList();
        }

        private void dtg_arabalar_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            cmb_listele.BackColor = Color.White;
            if (dtg_arabalar.SelectedRows.Count>0)
            {
                try
                {
                    id=(int)dtg_arabalar.SelectedRows[0].Cells[0].Value;
                    _kiralikAraba=_context.Arabalar.Include(a => a.Marka).FirstOrDefault(a => a.Id==id);
                    if (_kiralikAraba==null)
                    {
                        MessageBox.Show("Araba bulunamadı");
                        return;
                    }
                    txt_kAraba.Text=_kiralikAraba.Marka.Ad+" "+_kiralikAraba.Model;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir marka seçiniz");

                    cmb_listele.BackColor=Color.Red;
                    return;
                }
            }
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            try
            {
                if (_kiralikAraba==null)
                {
                    MessageBox.Show("Bir araç seçiniz");
                    return;
                }
                DateTime baslangicTarihi = dtp_kTarih.Value.Date+dtp_kSaat.Value.TimeOfDay;
                DateTime bitisTarihi = dtp_tTarih.Value.Date+dtp_tSaat.Value.TimeOfDay;
                if (bitisTarihi<=baslangicTarihi)
                {
                    MessageBox.Show("Bitiş Tarihi başlangıç tarihinden sonra olmalıdır");
                    return;
                }
                bool aracMusaitMi = _context.Kiralamalar.Where(k => k.ArabaId == _kiralikAraba.Id)
                   .Where(k => baslangicTarihi >= k.BaslangicTarihi && baslangicTarihi < k.BitisTarihi ||
                   (bitisTarihi > k.BaslangicTarihi && bitisTarihi <= k.BitisTarihi) || baslangicTarihi <= k.BaslangicTarihi && baslangicTarihi >= k.BitisTarihi).Count() == 0;
                if (!aracMusaitMi)
                {
                    MessageBox.Show("Araç Müsaitliği bulunmuyor.");
                    return;
                }
                TimeSpan fark = bitisTarihi-baslangicTarihi;
                double toplamSaat = fark.TotalHours;
                double toplamTutar = double.Parse(txt_toplamTutar.Text);
                Kiralama yeniKiralama = new Kiralama()
                {
                    MusteriId=_musteri.Id,
                    ArabaId=_kiralikAraba.Id,
                    BaslangicTarihi=baslangicTarihi,
                    BitisTarihi=bitisTarihi,
                    ToplamTutar=toplamTutar,
                };
                _kiralikAraba.Aktif=false;
                _context.Kiralamalar.Add(yeniKiralama);
                _context.SaveChanges();
                MessageBox.Show("Araç Kiralama Başarılı");
                YukleAktifArac();
                txt_kAraba.Clear();
                txt_toplamSaat.Clear();
                txt_toplamTutar.Clear();
                _kiralikAraba=null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (_kiralikAraba==null)
                {
                    MessageBox.Show("Lütfen bir araç seçiniz");
                    return;
                }
                DateTime baslangicTarihi = dtp_kTarih.Value.Date+dtp_kSaat.Value.TimeOfDay;
                DateTime bitisTarihi = dtp_tTarih.Value.Date+dtp_tSaat.Value.TimeOfDay;
                if (bitisTarihi<=baslangicTarihi)
                {
                    MessageBox.Show("Bitiş Tarihi başlangıç tarihinden sonra olmalıdır");
                    return;
                }
                TimeSpan fark = bitisTarihi-baslangicTarihi;
                double toplamSaat = Math.Ceiling(fark.TotalHours);
                txt_toplamSaat.Text=toplamSaat.ToString();
                double toplamTutar = toplamSaat*_kiralikAraba.SaatlikUcret;
                txt_toplamTutar.Text=toplamTutar.ToString("F2");//F2 virgülden sonra 2 basamak ekler 100 değerini F2 formatı ile çağırdığımızda 100,00 olarak getirecek.

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hesaplama hatası: "+ex.Message);
            }
        }

        private void btn_kiralamalar_Click(object sender, EventArgs e)
        {
            KiralamaForm kiralama = new KiralamaForm(_musteri);
            kiralama.Show();
            this.Hide();
        }

        private void btn_AracEkle_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_musteri);
            form1.Show();
            this.Hide();
        }
    }
}
