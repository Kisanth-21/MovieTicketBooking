using Microsoft.AspNetCore.Mvc;
using MovieTicket.API.Services;
using MovieTicket.API.DTOs;

namespace MovieTicket.API.Controllers;

[ApiController]
[Route("api/bookings")]
public class BookingsController : ControllerBase
{
    private readonly IBookingService _service;

    public BookingsController(IBookingService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Create(CreateBookingDto dto)
    {
        return Ok(_service.Create(dto));
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpPut("cancel/{id}")]
    public IActionResult Cancel(int id)
    {
        _service.Cancel(id);
        return Ok();
    }
    
}
