using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yönetim.Models
{
    public class NoteContext:DbContext
    {
        public NoteContext(DbContextOptions<NoteContext>options):base(options)
        {

        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Category>Category { get; set; }
        public DbSet<Note> Note { get; set; }
    }
}
