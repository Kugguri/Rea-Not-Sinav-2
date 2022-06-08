using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yönetim.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public Account Account { get; set; }
        public int kullaniciId { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
