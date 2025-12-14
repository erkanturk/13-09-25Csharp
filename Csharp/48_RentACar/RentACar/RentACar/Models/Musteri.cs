using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentACar.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        [Required]
        public string AdSoyad { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]//Email tipinde veri tabanında tutacak
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        public virtual ICollection<Kiralama> Kiralamas { get; set; }
        public Musteri()
        {
            Kiralamas = new List<Kiralama>();
        }
    }
}
