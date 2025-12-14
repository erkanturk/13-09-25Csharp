using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Models
{
    public class Araba
    {
        [Key]//Primary key benzersiz anahtar değeri
        public int Id { get; set; }
        [Required]
        public int MarkaId { get; set; }//Navigator Property Foreign key yabancıl anahtar yapısı bu yapı Araba ile Markanın bağlantısını tanımlıyor
        [Required]//Zorunlu alan
        [MaxLength(50)]
        public string Model { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "20 Karakter girilebilir")]
        public string Plaka { get; set; }
        [Required]

        public int Yil { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "minimum 0 Maksimum Double uzunluğu")]
        public double SaatlikUcret { get; set; }
        [Required]
        public bool Aktif { get; set; }
        public virtual Marka Marka { get; set; }//Foreign key yapısını (yabancıl anahtar) dahil ederek ilişkisini kurarız 
        //Kiralamalar diye bir koleksiyon yapısı oluştur
        public virtual ICollection<Kiralama> Kiralamalar { get; set; }

        public Araba()
        {//Araba sınıfı çağırıldığı gibi kiralamaları yükle
             Kiralamalar =new List<Kiralama>();
        }
    }
}
