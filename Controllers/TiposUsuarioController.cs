﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.event_manha.Domains;
using webapi.event_manha.Interfaces;
using webapi.event_manha.Repositories;

namespace webapi.event_manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository _tiposUsuarioRepository;

        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        }
        [HttpPost]

        public IActionResult Post( TiposUsuario tiposUsuario)
        {
            try
            {
                _tiposUsuarioRepository.Cadastrar(tiposUsuario);

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
                TiposUsuario tipoUsuario = _tiposUsuarioRepository.BuscarPorId(id);
                return Ok(tipoUsuario);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
