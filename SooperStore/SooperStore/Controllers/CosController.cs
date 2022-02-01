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
    [Route("api/cos")]
    [ApiController]
    public class CosController : ControllerBase
    {
        private readonly ICosRepository _cosRepository;
        public CosController(ICosRepository cosRepository)
        {
            _cosRepository = cosRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(_cosRepository.GetAll());

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Cos item = _cosRepository.GetById(id);
            return new OkObjectResult(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cos model)
        {

            _cosRepository.Add(model);
            _cosRepository.SaveChanges();
            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Cos model, int id)
        {
            Cos cos = _cosRepository.GetById(id);
            if (model.IdUser != cos.IdUser)
            {
                cos.IdUser = model.IdUser;
            }

            _cosRepository.Update(cos);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Cos cos = _cosRepository.GetById(id);
            _cosRepository.Remove(cos);
            _cosRepository.SaveChanges();
            return new OkObjectResult("Model deleted");

        }
    }
}
