using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.event_manha.Interfaces;
using webapi.event_manha.Repositories;

namespace webapi.event_manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository? _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }


    }
}
