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
    }
}
