using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext()
            : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=HotelDB;Trusted_Connection=True;");
        }

        public DbSet<CardVisitData> CardVisitData { get; set; }
        public DbSet<IEnumerable<RegisterData>> RegisterData { get; set; }
    }
}
