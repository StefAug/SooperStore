using Domain.Dto;
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
    [Route("api/comanda")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        private readonly IComandaRepository _comandaRepository;
        private readonly ICosRepository _cosRepository;
        public ComandaController(IComandaRepository comandaRepository, ICosRepository cosRepository)
        {
            _comandaRepository = comandaRepository;
            _cosRepository = cosRepository;
        }


        [HttpPost]
        public async Task<IActionResult> Create(ComandaDto model)
        {
            _cosRepository.Add(model.Cos);
            _cosRepository.SaveChanges();
            foreach(Produs produs in model.Produse)
            {
                Comanda entity = new Comanda()
                {
                    IdProdus = produs.Id,
                    IdCos = model.Cos.Id
                };
                _comandaRepository.Add(entity);
            }
            _comandaRepository.SaveChanges();

            return new OkObjectResult("Model creat");
        }


        public async Task<IActionResult> GetAll()
        {

            return Ok(_comandaRepository.GetAll());

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Comanda item = _comandaRepository.GetById(id);
            return new OkObjectResult(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Comanda model)
        {

            _comandaRepository.Add(model);
            _comandaRepository.SaveChanges();
            return new OkObjectResult("Model creat");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Comanda comanda = _comandaRepository.GetById(id);
            _comandaRepository.Remove(comanda);
            _comandaRepository.SaveChanges();
            return new OkObjectResult("Model deleted");

        }
    }
}
