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

        private void btn_yeniKiralama_Click(object sender, EventArgs e)
        {
            ArabaForm arabaForm;
            if (_musteri!=null)
            {
                arabaForm=new ArabaForm(_musteri);
            }
            else
            {
                MessageBox.Show("Sisteme Giriş Yapınız");
                return;
            }
            this.Hide();
            arabaForm.Show();
            KiralamalariYukle();

        }

        private void dtg_kiralamalar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtg_kiralamalar.SelectedRows.Count>0)
                {
                    int kiralamaId = Convert.ToInt32(dtg_kiralamalar.SelectedRows[0].Cells["Kiralama No"].Value);
                    _secilenKiralama =
                        _context.Kiralamalar.Include(k => k.Araba)
                        .Include(k => k.Araba.Marka)
                        .Include(k => k.Musteri)
                        .FirstOrDefault(k => k.Id==kiralamaId);
                    Console.WriteLine($"Seçilen kiralama Id {kiralamaId} bulunan: {_secilenKiralama!=null}");
                    btn_kiralamaDuzenle.Enabled=_secilenKiralama!=null;
                    btn_kiralamaSil.Enabled=_secilenKiralama!=null;
                }
                else
                {
                    _secilenKiralama=null;
                    btn_kiralamaSil.Enabled=false;
                    btn_kiralamaDuzenle.Enabled=false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı seçim: "+ex.Message);
                _secilenKiralama=null;
                btn_kiralamaSil.Enabled=false;
                btn_kiralamaDuzenle.Enabled=false;

            }
        }

        private void btn_kiralamaDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_secilenKiralama==null)
                {
                    MessageBox.Show("Lütfen bir kiralama seçiniz");
                    return;
                }
                var guncelleKiralama = _context.Kiralamalar
                    .Include(k => k.Araba)
                    .Include(k => k.Araba.Marka)
                    .Include(k => k.Musteri)
                    .FirstOrDefault(k => k.Id==_secilenKiralama.Id);
                if (guncelleKiralama==null)
                {
                    MessageBox.Show("Seçilen kiralama kaydı artık mevcut değil");
                    KiralamalariYukle();
                    return;
                }
                KiralamaDuzenlemeForm duzenlemeForm = new KiralamaDuzenlemeForm(guncelleKiralama, _musteri);
                this.Hide();
                if (duzenlemeForm.ShowDialog()==DialogResult.OK)
                {
                    KiralamalariYukle();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: "+ex.Message);

            }
        }

        private void btn_kiralamaSil_Click(object sender, EventArgs e)
        {
            if (_secilenKiralama==null)
            {
                MessageBox.Show("Lütfen bir kiralama seçiniz");
                return;
            }
            DialogResult result = MessageBox.Show($"{_secilenKiralama.Id} numaralı kiramala kaydını silmek istediğinize emin misiniz ?", "Kiralama sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                try
                {
                    if (_secilenKiralama.Araba!=null)
                    {
                        _secilenKiralama.Araba.Aktif=true;
                    }
                    _context.Kiralamalar.Remove(_secilenKiralama);
                    _context.SaveChanges();
                    KiralamalariYukle();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Silme sırasında hata meydana geldi: "+ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ArabaForm arabaForm = new ArabaForm(_musteri);
            arabaForm.Show();
        }
    }
}
