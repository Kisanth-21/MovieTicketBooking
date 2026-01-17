using Microsoft.EntityFrameworkCore;
using MovieTicket.API.Models;

namespace MovieTicket.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<Booking> Bookings => Set<Booking>();
}
