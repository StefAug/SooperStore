using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SooperStore.Controllers
{
    [Route("api/userrol")]
    [ApiController]
    public class UserRolController : ControllerBase
    {
        private readonly IUserRolRepository _userRolRepository;
        public UserRolController(IUserRolRepository userRolRepository)
        {
            _userRolRepository = userRolRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(_userRolRepository.GetAll());

        }

        [HttpGet("userid/{userid}")]
        public async Task<IActionResult> GetRolesByUserId(int userId)
        {
            var items = _userRolRepository.GetRolesByUserId(userId);
            return new OkObjectResult(items);
        }


    }
}
