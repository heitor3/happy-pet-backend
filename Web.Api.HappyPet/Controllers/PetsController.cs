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
    public class PetsController : ControllerBase
    {
        private readonly IPet _repository;

        public PetsController(IPet repository)
        {
            _repository = repository;
        }

        [Route("Cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _repository.Create(pet);
            }

            return Ok();
        }

        [HttpGet]
        [Route("Listagem")]
        public IEnumerable<Pet> Listagem()
        {
            var listaDePets = _repository.List();

            return listaDePets;
        }


        [HttpPost]
        [Route("MinhaListagem")]
        public IEnumerable<Pet> MinhaListagem([FromQuery] int id)
        {
            var minhaListaDePets = _repository.ListById(id);

            return minhaListaDePets;
        }

        [HttpPost]
        [Route("Detalhes")]
        public Pet Detalhes([FromQuery] int id)
        {
            var pet = _repository.Details(id);

            return pet;
        }


        [HttpPost]
        [Route("Excluir")]
        public void Excluir([FromQuery] int id)
        {
            _repository.Delete(id);
           
        }

    }
}
