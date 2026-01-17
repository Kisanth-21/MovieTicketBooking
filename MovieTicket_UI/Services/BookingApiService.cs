using System.Net.Http.Json;
using MovieTicket.UI.Models;

namespace MovieTicket.UI.Services;

public class BookingApiService
{
    private readonly HttpClient _http;

    public BookingApiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Booking>> GetBookings()
    {
        return await _http.GetFromJsonAsync<List<Booking>>("api/bookings")
               ?? new List<Booking>();
    }

    public async Task CreateBooking(Booking booking)
    {
        await _http.PostAsJsonAsync("api/bookings", booking);
    }

    public async Task CancelBooking(int id)
    {
        await _http.PutAsync($"api/bookings/cancel/{id}", null);
    }
}
