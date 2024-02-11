using FIT.Data;
using FIT.Data.IB220155;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<DrzavaIB220155> DrzaveIB220155 { get; set; }
        public DbSet<GradIB220155> GradoviIB220155 { get; set; }
        public DbSet<SemestarIB220155> Semestri { get; set; }
        public DbSet<PredmetIB220155> Predmeti { get; set; }
        public DbSet<PolozeniPredmetiIB220155> PolozeniPredmeti { get; set; }


    }
}