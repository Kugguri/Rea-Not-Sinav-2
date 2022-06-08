using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yönetim.Models
{
    public class Account
    {
        [Key]
        public int kullaniciId { get; set; }
        [Required]
        public string kullaniciAd { get; set; }
        public string kullaniciSoyad { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string sifre { get; set; }
    }
}
