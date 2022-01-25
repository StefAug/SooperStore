using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SooperStore.Controllers
{
    [Route("api/rol")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolRepository _rolRepository;
        public RolController(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(_rolRepository.GetAll());

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Rol item = _rolRepository.GetById(id);
            return new OkObjectResult(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Rol model)
        {

            _rolRepository.Add(model);
            _rolRepository.SaveChanges();
            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Rol model, int id)
        {
            Rol rol = _rolRepository.GetById(id);
            if (model.Nume != rol.Nume)
            {
                rol.Nume = model.Nume;
            }
            _rolRepository.Update(rol);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Rol rol = _rolRepository.GetById(id);
            _rolRepository.Remove(rol);
            return new OkObjectResult("Model deleted");

        }
    }
}
