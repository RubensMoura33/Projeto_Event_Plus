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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;


        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();

        }

        [HttpPost]

        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]

        public IActionResult Get(string email, string senha)

        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailESenha(email, senha);
                return Ok(usuarioBuscado);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);

            }

        }

        [HttpGet("{id}")]

        public IActionResult Get(Guid id) 
        
        {
            try
            {
                Usuario usuario = _usuarioRepository.BuscarPorId(id);
                return Ok(usuario);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        


     }
}
