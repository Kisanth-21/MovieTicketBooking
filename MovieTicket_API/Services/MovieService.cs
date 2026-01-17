using MovieTicket.API.Data;
using MovieTicket.API.Models;
using MovieTicket.API.DTOs;

namespace MovieTicket.API.Services;

public class MovieService : IMovieService
{
    private readonly AppDbContext _db;

    public MovieService(AppDbContext db)
    {
        _db = db;
    }

    public List<Movie> GetAll()
    {
        return _db.Movies.ToList();
    }

    public Movie Create(CreateMovieDto dto)
    {
        var movie = new Movie
        {
            Title = dto.Title,
            Genre = dto.Genre,
            Duration = dto.Duration,
            Rating = dto.Rating
        };

        _db.Movies.Add(movie);
        _db.SaveChanges();

        return movie;
    }
     public void Delete(int id)
    {
        var movie = _db.Movies.Find(id);
        if (movie == null) return;

        _db.Movies.Remove(movie);
        _db.SaveChanges();
    }
}
