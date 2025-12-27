using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Models;

namespace RentACar
{
    public partial class Form1 : Form
    {
       
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



        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_markalar.DataSource=_context.Markalar.ToList();
            cmb_markalar.DisplayMember="Ad";
            cmb_markalar.ValueMember="Id";
            cmb_markalar.SelectedIndex=-1;
            //YukleAktifAraclar();

        }

        private void btn_aracEkle_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            try
            {

                araba.MarkaId=Convert.ToInt32(cmb_markalar.SelectedValue);
                araba.SaatlikUcret=Convert.ToDouble(txt_kUcret.Text);
                araba.Yil=Convert.ToInt32(mtxt_yil.Text);
                araba.Model=txt_kModel.Text;
                araba.Plaka=txt_kPlaka.Text;
                if (Aktif.Checked!=true)
                {
                    araba.Aktif=false;

                }
                else if (Aktif.Checked==true&&Pasif.Checked==true)
                {
                    MessageBox.Show("Sadece bir seçenek seçiniz");
                    Aktif.Checked=false;
                    Pasif.Checked=false;
                    return;
                }
                else if (Aktif.Checked==true)
                {
                    araba.Aktif=true;
                }
                else if (Pasif.Checked==true)
                {
                    araba.Aktif=false;
                }
                else if (Aktif.Checked!=true||Pasif.Checked!=true)
                {
                    MessageBox.Show("Lütfen aracýn durumunu belirtin");
                    return;
                }
                _context.Arabalar.Add(araba);
                _context.SaveChanges();
                MessageBox.Show("Kayýt baþarý ile eklendi");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            ArabaForm arabaForm = new ArabaForm(_musteri);
            this.Hide();
            arabaForm.Show();

        }



    }
}
