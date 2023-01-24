using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable <Evento> _evento = new Evento[]
        {
           new Evento() {
            EventoId = 1,
            Tema = "Angular e .Net Core 6",
            Local = "Belo Horizonte",
            Lote = "1 Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("ddMMyyyy"),
            ImagemURL = "Foto.png"

        },
         new Evento() {
            EventoId = 2,
            Tema = "Angular e .Net Core 6",
            Local = "Belo Horizonte",
            Lote = "2 Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("ddMMyyyy"),
            ImagemURL = "Foto.png"
         }

        };

    public EventoController()
    {
        
    }

    
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }
    

     [HttpGet("{Id}")]
    public IEnumerable<Evento> GetById(int Id)
    {
        return _evento.Where(evento => evento.EventoId == Id);
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
