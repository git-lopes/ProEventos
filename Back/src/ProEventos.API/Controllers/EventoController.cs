using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class EventoController : ControllerBase
    {

       public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Local = "Fortaleza",
                Tema ="Angular 11",
                QtdPessoas = 300,
                Lote = "1a Lote",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
             },
             new Evento() {
                EventoId = 2,
                Local = "São Paulo",
                Tema ="Angular 11 e suas novidades",
                QtdPessoas = 200,
                Lote = "2a Lote",
                DataEvento = DateTime.Now.AddDays(3).ToString(),
             }
           };   
               
        public EventoController(ILogger<EventoController> logger)
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _evento;
        }

        [HttpGet("{Id}")]
        public IEnumerable<Evento> GetById(int Id)
        {
          return _evento.Where(evento => evento.EventoId == Id);
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
