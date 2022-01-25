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
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(_userRepository.GetAll());

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            User item = _userRepository.GetById(id);
            return new OkObjectResult(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(User model)
        {

            _userRepository.Add(model);
            _userRepository.SaveChanges();
            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(User model, int id)
        {
            User user = _userRepository.GetById(id);
            if (model.Nume != user.Nume)
            {
                user.Nume = model.Nume;
            }
            _userRepository.Update(user);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            User entity = _userRepository.GetById(id);
            _userRepository.Remove(entity);
            _userRepository.SaveChanges();
            return new OkObjectResult("Model deleted");

        }
    }
}
