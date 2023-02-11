using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    
    private readonly DataContext _context;

    public EventoController(DataContext context)
    {
        _context = context;
    }

    
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Evento>? Get()
    {
        return _context.Eventos;
    }
    

     [HttpGet("{Id}")]
    public Evento ? GetById(int Id)
    {
        return _context.Eventos.FirstOrDefault(evento => evento.EventoId == Id);
    }

    [HttpPost(Name = "GetWeatherForecast")]
    public string Post()
    {
        return "Exemplo de Post";
    }

     [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com o id = {id}";
    }

     [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com o id = {id}";
    }
}
