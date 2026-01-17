using Microsoft.AspNetCore.Mvc;
using MovieTicket.API.Services;
using MovieTicket.API.DTOs;

namespace MovieTicket.API.Controllers;

[ApiController]
[Route("api/movies")]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _service;

    public MoviesController(IMovieService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpPost]
    public IActionResult Create(CreateMovieDto dto)
    {
        return Ok(_service.Create(dto));
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
         return Ok("Movie deleted");
    }
}
