using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.event_manha.Domains;
using webapi.event_manha.Interfaces;
using webapi.event_manha.Repositories;

namespace webapi.event_manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EventoController : ControllerBase
    {
        private IEventoRepository _eventoRepository;

        public EventoController()
        {
            _eventoRepository = new EventoRepository();
        }

        [HttpPost]

        public IActionResult Post (Evento evento)
        {
            try
            {
                _eventoRepository.Cadastrar(evento);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet ("{id}")]

        public IActionResult Get(Guid id)
        {
            try
            {
               Evento eventoBuscado = _eventoRepository.BuscarPorId(id);
                return Ok(eventoBuscado);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
