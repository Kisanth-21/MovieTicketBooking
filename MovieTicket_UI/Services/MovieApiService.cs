using System.Net.Http.Json;
using MovieTicket.UI.Models;

namespace MovieTicket.UI.Services;

public class MovieApiService
{
    private readonly HttpClient _http;

    public MovieApiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Movie>> GetMovies()
    {
        return await _http.GetFromJsonAsync<List<Movie>>("api/movies")
               ?? new List<Movie>();
    }

    public async Task AddMovie(Movie movie)
    {
        await _http.PostAsJsonAsync("api/movies", movie);
    }

    public async Task DeleteMovie(int id)
    {
        await _http.DeleteAsync($"api/movies/{id}");
    }
}
