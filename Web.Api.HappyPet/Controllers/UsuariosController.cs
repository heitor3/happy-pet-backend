using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.HappyPet.Models;
using Web.Api.HappyPet.Repositories;

namespace Web.Api.HappyPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuario _repository;

        public UsuariosController(IUsuario repository)
        {
            _repository = repository;
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login([FromBody] string email, string senha)
        {

            var user = _repository.Login(email, senha);

            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }
            else
            {
                user.Senha = "";

                return Ok(new
                {
                    user
                });
            }
        }

        [Route("Cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _repository.Create(usuario);
            }

            return Ok();
        }


    }
}
