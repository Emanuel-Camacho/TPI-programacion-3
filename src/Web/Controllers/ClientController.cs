using Application.DTOs;
using Application.Interfaces;
using Domain.Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllClients()
        {
            return Ok(_clientService.GetClients());
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetClientById(int id)
        {
            return Ok(_clientService.GetClientById(id));
        }

        [HttpPost("[action]")]
        public IActionResult AddClient([FromBody] ClientDto clientDto)
        {
            //Aca generar ID??
            var client = new Client
            {
                Name = clientDto.Name,
                Email = clientDto.Email,
                Password = clientDto.Password,
                Location = clientDto.Location,
                Dni = clientDto.Dni
            };
            _clientService.AddClient(client);
            return Ok("Cliente agregado con exito!");
        }

        [HttpPut("[action]/{id}")]
        public IActionResult UpdateClient(int id, [FromBody] ClientDto clientDto)
        {
            var existingClient = _clientService.GetClientById(id);
            //analisar si no es correcto el id por si no lo encuentra (modificar id??)
            existingClient.Id = id;
            existingClient.Name = clientDto.Name;
            existingClient.Email = clientDto.Email;
            existingClient.Password = clientDto.Password;
            existingClient.Location = clientDto.Location;
            existingClient.Dni = clientDto.Dni;



            _clientService.UpdateClient(id, existingClient);
            return Ok("Cliente actualizado con exito!");
        }

        [HttpDelete]
        public IActionResult DeleteClient(int id)
        {
            _clientService.DeleteClient(id);
            return Ok("Cliente eliminado con exito!");
        }

    }
}
