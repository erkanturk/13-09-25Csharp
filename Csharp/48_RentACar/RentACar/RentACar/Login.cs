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
    public partial class Login : Form
    {
        private readonly DataContext _context;
        public Login()
        {
            InitializeComponent();
            _context=new DataContext();
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_kPassword.Text!=txt_kRePassword.Text)
                {
                    MessageBox.Show("Şifreler Uyuşmuyor");
                    txt_kRePassword.Clear();
                    txt_kPassword.Clear();
                    return;
                }
                var customer = _context.Musteriler.Where(i => i.Telefon==txt_kPhone.Text).FirstOrDefault();
                if (customer!=null)
                {
                    MessageBox.Show("Zaten böyle bir kayıt var");
                    txt_kPhone.Clear();
                    txt_kPassword.Clear();
                    txt_kRePassword.Clear();
                    return;
                }
                if (string.IsNullOrEmpty(txt_kAdSoyad.Text)||string.IsNullOrEmpty(txt_kEmail.Text)||string.IsNullOrEmpty(txt_kPassword.Text)||string.IsNullOrEmpty(txt_kPhone.Text))
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz");
                    return;
                }
               

                Musteri musteri = new Musteri()
                {
                    Telefon = txt_kPhone.Text,
                    Email = txt_kEmail.Text,
                    AdSoyad=txt_kAdSoyad.Text,
                    Password = txt_kPassword.Text,
                };
                _context.Musteriler.Add(musteri);
                int eks = _context.SaveChanges();
                if (eks>0)
                {
                    MessageBox.Show("Kayıt işlemi başarılı");
                    txt_kPhone.Clear();
                    txt_kPassword.Clear();
                    txt_kRePassword.Clear();
                    txt_kAdSoyad.Clear();
                    txt_kEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız");
                    txt_kPhone.Clear();
                    txt_kPassword.Clear();
                    txt_kRePassword.Clear();
                    txt_kAdSoyad.Clear();
                    txt_kEmail.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: "+ex.Message);
                txt_kPhone.Clear();
                txt_kPassword.Clear();
                txt_kRePassword.Clear();
                txt_kAdSoyad.Clear();
                txt_kEmail.Clear();

            }
        }
    }
}
