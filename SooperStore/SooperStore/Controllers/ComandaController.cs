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
        public ComandaController(IComandaRepository comandaRepository)
        {
            _comandaRepository = comandaRepository;
        }
    }
}
