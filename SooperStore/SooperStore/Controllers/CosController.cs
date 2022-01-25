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
    }
}
