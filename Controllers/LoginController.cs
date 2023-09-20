using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.event_manha.Domains;
using webapi.event_manha.Interfaces;
using webapi.event_manha.Repositories;
using webapi.event_manha.ViewModels;

namespace webapi.event_manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository? _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]

        public IActionResult Post(LoginViewModel usuario)
        {
            try
            {
                Usuario login = _usuarioRepository.BuscarPorEmailESenha(usuario.Email!, usuario.Senha!);

                if (login == null)
                {
                    return StatusCode(401, "Email ou senha invalidos");
                }

                //logica do token
                var claims = new[]
                {
                new Claim(JwtRegisteredClaimNames.Email, login.Email!),
                new Claim(JwtRegisteredClaimNames.Name, login.NomeUsuario!),
                new Claim(JwtRegisteredClaimNames.Jti, login.IdUsuario.ToString()),
                new Claim(ClaimTypes.Role,login.TiposUsuario.TituloTipoUsuario!)
 };
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("projeto-event-api-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "webapi.event+manha",
                    audience: "webapi.event+manha",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: creds);

                return Ok(new {token = new JwtSecurityTokenHandler().WriteToken(token) });

            }


            catch (Exception)
            {

                throw;
            }



        }

    }
}
