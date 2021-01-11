using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SCP.Core.Interfaces;
using SCP.Core.ModelEntity;
using SCP.Infraestructure.Repositories;

namespace SCP.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuario _usuarioRepository;
        public UsuarioController(IUsuario usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        [HttpGet]
        [Route("api/usuarios")]
        public async Task<IActionResult> GetUsuarios()
        {
            var usuario = await _usuarioRepository.GetAll();
            return Ok(usuario);
        }
        [HttpGet]
        [Route("api/usuario")]
        public async Task<IActionResult> GetUsuario(int id)
        {
            var usuario = await _usuarioRepository.GetUsuarioById(id);
            return Ok(usuario);
        }

        [HttpPost]
        [Route("api/insertar/usuario")]
        public async Task<IActionResult> AddUsuario(Usuario usuario)
        {
            await _usuarioRepository.InsertarUsuario(usuario);
            return Ok(usuario);
        }


    }
}
