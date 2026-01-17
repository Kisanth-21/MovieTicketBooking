using Microsoft.EntityFrameworkCore;
using MovieTicket.API.Data;
using MovieTicket.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IBookingService, BookingService>();

var app = builder.Build();

app.MapControllers();
app.Run();
