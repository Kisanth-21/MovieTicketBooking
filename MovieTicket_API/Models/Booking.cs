namespace MovieTicket.API.Models;

public class Booking
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string? CustomerName { get; set; } = "";
    public int Tickets { get; set; }
    public string Status { get; set; } = "Booked"; 
}
