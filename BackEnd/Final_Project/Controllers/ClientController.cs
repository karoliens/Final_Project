using Final_Project.Data;
using Final_Project.Dto;
using Final_Project.Models;
using Final_Project.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepo;

        public ClientController(IClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        /// <summary>
        /// Gaunami visi klientai, esantys duomenų bazėje
        /// </summary>
        /// <returns></returns>
        [HttpGet("clients", Name = "GetAllClients")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetClientDTO>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<GetClientDTO> GetAllClients()
        {
            return Ok();
        }
        /*
        [HttpGet("clients/{id:int}", Name = "GetClientById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetClientDTO> GetClientById(int clientId)
        {
            if (clientId == 0)
            {
                return BadRequest();
            }

            var foundClient = _clientRepo.FirstOrDefault(t => t.ClientId == clientId);

            if (foundClient == null)
            {
                return NotFound();
            }

            return Ok(new GetClientDTO(foundClient));
        }
        */

        /// <summary>
        /// Klientas įrašomas į duomenų bazę
        /// </summary>
        /// <returns></returns>
        [HttpPost("clients", Name = "PostClient")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        public ActionResult<CreateClientDTO> PostClient(CreateClientDTO clientDTO)
        {
            if (clientDTO == null)
            {
                return BadRequest();
            }

            Client newClient = new()
            {
                Name = clientDTO.Name,
                Email = clientDTO.Email,
                PhoneNumber = clientDTO.PhoneNumber,
            };

            _clientRepo.Create(newClient);

            return CreatedAtRoute("GetClientById", new { id = newClient.ClientId }, clientDTO);
        }
    }
}
