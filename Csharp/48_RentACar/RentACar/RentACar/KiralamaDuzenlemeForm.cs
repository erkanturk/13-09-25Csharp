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
        public KiralamaDuzenlemeForm(Kiralama kiralama,Musteri musteri)
        {
            InitializeComponent();
            _context = new DataContext();
            _kiralama = kiralama;
            _musteri = musteri;
        }
    }
}
