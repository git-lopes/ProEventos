using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
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

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _context.Eventos;
        }

        [HttpGet("{Id}")]
        public Evento GetById(int Id)
        {
          return _context.Eventos.FirstOrDefault(evento => evento.EventoId == Id);
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post" ;     
        }

        [HttpPut("{EventoId}")]
        public string Put(int Id)
        {
           return $"Exemplo de Put com Id = {Id}" ;     
        }

        [HttpDelete("{EventoId}")]
        public string Delete(int Id)
        {
           return $"Exemplo de Delete com Id = {Id}" ;     
        }

    }
