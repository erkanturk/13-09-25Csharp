using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Models;

namespace RentACar
{
    public partial class Form1 : Form
    {
        private readonly Marka _marka;
        private readonly Araba _araba;
        private readonly DataContext _context;
        private readonly Musteri _musteri;
        public Form1(Musteri musteri)
        {
            InitializeComponent();
            _musteri=musteri;
            _context=new DataContext();
        }

        private void btn_kMarka_Click(object sender, EventArgs e)
        {

            if (_musteri.Id!=1)
            {
                MessageBox.Show("Yetkiniz bulunmamaktadýr");
                this.Hide();
                ArabaForm arabaForm = new ArabaForm(_musteri);
                arabaForm.Show();
            }
            if (_musteri!=null)
            {

                if (_musteri==null)
                {
                    MessageBox.Show("Müþteri bilgisine ulaþýlamadý");
                    return;
                }
                else
                {
                    Marka marka = new Marka()
                    {
                        Ad=txt_kMarka.Text
                    };
                    _context.Markalar.Add(marka);
                    _context.SaveChanges();
                    MessageBox.Show("Araç baþarýyla eklendi");
                    txt_kMarka.Clear();
                }

            }
        }

        private void btn_kArac_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_markalar.DataSource=_context.Markalar.ToList();
            cmb_markalar.DisplayMember="Ad";
            cmb_markalar.ValueMember="Id";
            cmb_markalar.SelectedIndex=-1;
            YukleAktifAraclar();

        }
        private void YukleAktifAraclar()
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
                }
                ).ToList();
            

        }

    }
}
