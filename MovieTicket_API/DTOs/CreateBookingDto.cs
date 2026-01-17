namespace MovieTicket.API.DTOs;

public class CreateBookingDto
{
    public int MovieId { get; set; }
    public string CustomerName { get; set; } = "";
    public int Tickets { get; set; }
}
