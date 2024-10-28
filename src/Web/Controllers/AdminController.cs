using Application.DTOs;
using Application.Interfaces;
using Domain.Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AdminController : ControllerBase
    {
        private readonly IAdminService _clientService;

        public AdminController(IAdminService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllAdmins()
        {
            return Ok(_clientService.GetAdmins());
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetAdminById(int id)
        {
            return Ok(_clientService.GetAdminById(id));
        }

        [HttpPost("[action]")]
        public IActionResult AddAdmin([FromBody] Admin admin)
        {
            _clientService.AddAdmin(admin);
            return Ok("Admine agregado con exito!");
        }

        [HttpPut("[action]/{id}")]
        public IActionResult UpdateAdmin(int id, [FromBody] Admin admin)
        {
            _clientService.UpdateAdmin(id, admin);
            return Ok("Admine actualizado con exito!");
        }

        [HttpDelete]
        public IActionResult DeleteAdmin(int id)
        {
            _clientService.DeleteAdmin(id);
            return Ok("Admin eliminado con exito!");
        }

    }
}

