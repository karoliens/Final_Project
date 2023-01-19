using Final_Project.Data;
using Final_Project.Dto;
using Final_Project.Models;
using Final_Project.Repositories.IRepositories;
using Final_Project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketRepository _ticketRepo;
        private readonly ITicketAdapter _adapter;

        public TicketController(ILogger<TicketController> logger, ITicketRepository ticketRepo, ITicketAdapter adapter)
        {
            _logger = logger;
            _ticketRepo = ticketRepo;
            _adapter = adapter;
        }

        /// <summary>
        /// Gaunami visi Ticket įrašai, esantys duomenų bazėje
        /// </summary>
        /// <returns></returns>
        [HttpGet("tickets", Name = "GetAllTickets")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetClientDTO>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult GetAllTickets()
        {
            var tickets = _ticketRepo.All();
            var model = tickets.Select(x => _adapter.Bind(x));

            return Ok(model);
        }

        /// <summary>
        /// Pagal ID gaunamas Ticket, esantis duomenų bazėje
        /// </summary>
        /// <param name="ticketId"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetTicketById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetTicketDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult GetTicketById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            if (!_ticketRepo.Exist(id))
            {
                _logger.LogInformation("Ticket with ID {id} not found", id);
                return NotFound();
            }
            var ticket = _ticketRepo.Get(id);
            var model = _adapter.Bind(ticket);

            return Ok(model);
        }

        /// <summary>
        /// Ticket įrašomas į duomenų bazę
        /// </summary>
        /// <returns></returns>
        [HttpPost("tickets", Name = "PostTicket")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        public ActionResult PostTicket(CreateTicketDTO ticketDTO)
        {

            var model = _adapter.Bind(ticketDTO);
            var id = _ticketRepo.Create(model);

            return Created("GetTicketById", new { Id = id });
        }
    }
}
