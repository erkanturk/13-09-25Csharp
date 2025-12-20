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
    public partial class KiralamaForm : Form
    {
        DataContext _context;
        Musteri _musteri;
        Kiralama _secilenKiralama;
        public KiralamaForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }
        public KiralamaForm(Musteri musteri) : this()
        {
            this._musteri = musteri;
        }

        private void KiralamaForm_Load(object sender, EventArgs e)
        {
            btn_kiralamaDuzenle.Enabled = false;
            btn_kiralamaSil.Enabled = false;
            KiralamalariYukle();

        }
        private void KiralamalariYukle()
        {
            try
            {
                var kiralamalar = _context.Kiralamalar
                    .Include(k => k.Araba)
                    .Include(k => k.Araba.Marka)
                    .Include(k => k.Musteri)
                    .AsQueryable();
                if (_musteri!=null)
                {
                    kiralamalar=kiralamalar.Where(k => k.MusteriId==_musteri.Id);

                }
                var kiralamaListesi = kiralamalar.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Kiralama No", typeof(int));
                dataTable.Columns.Add("Başlangıç Tarihi", typeof(DateTime));
                dataTable.Columns.Add("Bitiş Tarihi", typeof(DateTime));
                dataTable.Columns.Add("Toplam Tutar (₺)", typeof(decimal));
                dataTable.Columns.Add("Araç Bilgisi", typeof(string));
                dataTable.Columns.Add("Müşteri Bilgisi", typeof(string));
                foreach (var kiralama in kiralamaListesi)
                {
                    string aracBilgisi = kiralama.Araba!=null&&kiralama.Araba.Marka!=null ? $"{kiralama.Araba.Model}" : "Bilinmiyor";
                    string musteriBilgisi = kiralama.Musteri!=null ? $"{kiralama.Musteri.AdSoyad} {kiralama.Musteri.Telefon} {kiralama.Musteri.Email}" : "Bilinmiyor";
                    dataTable.Rows.Add(
                        kiralama.Id,
                        kiralama.BaslangicTarihi,
                        kiralama.BitisTarihi,
                        kiralama.ToplamTutar,
                        aracBilgisi,
                        musteriBilgisi
                        );
                }
                dtg_kiralamalar.DataSource=dataTable;
                dtg_kiralamalar.Columns["Toplam Tutar (₺)"].DefaultCellStyle.Format="C2";
                if (dtg_kiralamalar.Rows.Count>0)
                {
                    dtg_kiralamalar.ClearSelection();
                }
                _secilenKiralama=null;
                btn_kiralamaDuzenle.Enabled=false;
                btn_kiralamaSil.Enabled=false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Yüklenecek araba bilgisi bulunamadı");
            }
        }
    }
}
