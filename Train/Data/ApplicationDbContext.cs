using Microsoft.EntityFrameworkCore;
using Train.Models;

namespace Train.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Trains> Trains { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Reservation> Reservations { get; set; }    

    }
}
