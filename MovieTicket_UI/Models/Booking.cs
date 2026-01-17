namespace MovieTicket.UI.Models;

public class Booking
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string CustomerName { get; set; } = "";
    public int Tickets { get; set; }
    public string Status { get; set; } = "";
    public string MovieTitle { get; set; } = "";
}

