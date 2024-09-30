using Microsoft.EntityFrameworkCore;

namespace ShiftsWebApi.Models
{
    public class ShiftsContext: DbContext
    {
        public DbSet<Shifts> Shifts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}
