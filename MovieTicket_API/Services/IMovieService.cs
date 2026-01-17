using MovieTicket.API.Models;
using MovieTicket.API.DTOs;

namespace MovieTicket.API.Services;

public interface IMovieService
{
    List<Movie> GetAll();
    Movie Create(CreateMovieDto dto);
    void Delete(int id); 
}
