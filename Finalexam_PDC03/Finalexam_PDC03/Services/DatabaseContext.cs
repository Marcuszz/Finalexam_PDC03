using Finalexam_PDC03.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Finalexam_PDC03.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
        public DatabaseContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Animal.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

    }
}