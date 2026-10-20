using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomolyKvizApp.Models
{
    public class KerdesContext : DbContext
    {
        string con = "Server=localhost; Database=kvizkerdesek;Uid=root; Password=root;";

        public DbSet<FeleletValasztosKerdes> FeleletValasztosKerdesek { get; set; }
        public DbSet<IgazHamisKerdes> IgazHamisKerdesek { get; set; }
        public DbSet<TippelosKerdes> TippelosKerdesek { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(con, ServerVersion.AutoDetect(con));
        }
    }
}
