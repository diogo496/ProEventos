using Backend.ProEventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[]
            { new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Lisboa",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = ""
            }};
        }
    }
}