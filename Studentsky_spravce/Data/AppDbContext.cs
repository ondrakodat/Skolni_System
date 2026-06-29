using Microsoft.EntityFrameworkCore;
using Studentsky_spravce.Models;

namespace Studentsky_spravce.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Ucitel> Ucitele {  get; set; }
        public DbSet<Trida> Tridy { get; set; }
        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Hodina> Hodiny {  get; set; }
        public DbSet<Znamka> Znamky { get; set; }
        public DbSet<Predmet> Predmety {  get; set; }
        public DbSet<Rozvrh> Rozvrhy { get; set; }
    }
}
