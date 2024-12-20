using Microsoft.EntityFrameworkCore;
using NotesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Commands
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Note> Notes { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Calendar.db");
        }
    }
}
