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
    public class InstituicaoController : ControllerBase
    {
        private IIntituicaoRepository _instituicaoRepository;

        public InstituicaoController()
        {
            _instituicaoRepository = new InstituicaoRepository();
        }

        [HttpPost]

        public IActionResult Post (Instituicao instituicao)
        {
            try
            {
                _instituicaoRepository.Cadastrar(instituicao);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]

        public IActionResult Get (Guid id)
        {
            try
            {
                Instituicao instituicaoBuscada = _instituicaoRepository.BuscarPorId(id);
                return Ok(instituicaoBuscada);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
