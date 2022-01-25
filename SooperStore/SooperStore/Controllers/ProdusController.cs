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
    [Route("api/produs")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        private readonly IProdusRepository _produsRepository;
        public ProdusController(IProdusRepository produsRepository)
        {
            _produsRepository = produsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var a = _produsRepository.GetAll();
                return new OkObjectResult(a);
            }
            catch(Exception ex)
            {
                var abc = ex;
            }

            return Ok();
           
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Produs item = _produsRepository.GetById(id);
            return new OkObjectResult(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Produs model)
        {
          
             _produsRepository.Add(model);
            _produsRepository.SaveChanges();
            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Produs model, int id)
        {
            Produs produs = _produsRepository.GetById(id);
            if (model.Nume != produs.Nume)
            {
                produs.Nume = model.Nume;
            }
            if (model.Descriere != produs.Descriere)
            {
                produs.Descriere = model.Descriere;
            }
            if (model.Stoc != produs.Stoc)
            {
                produs.Stoc = model.Stoc;
            }
            if (model.Pret != produs.Pret)
            {
                produs.Pret = model.Pret;
            }
            _produsRepository.Update(produs);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Produs produs = _produsRepository.GetById(id);
                _produsRepository.Remove(produs);
                return new OkObjectResult("Model deleted");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
