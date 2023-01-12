using Final_Project.Data;
using Final_Project.Dto;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly RepairShopContext _db;

        public TicketController(RepairShopContext db)
        {
            _db = db;
        }
        
        [HttpGet("tickets", Name ="GetAllTickets")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<GetTicketDTO>> GetAllTickets()
        {
            return _db.Tickets.Select(t => new GetTicketDTO(t)).ToList();
        }

        [HttpGet("tickets/{id:int}", Name ="GetTicketById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetTicketDTO> GetTicketById(int ticketId)
        {
            if (ticketId == 0)
            {
                return BadRequest();
            }

            var foundTicket = _db.Tickets.FirstOrDefault(t => t.TicketId == ticketId);

            if (foundTicket == null)
            {
                return NotFound();
            }

            return new GetTicketDTO(foundTicket);
        }
        
        [HttpPost("tickets", Name ="CreateTicket")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateTicketDTO> CreateTicket(CreateTicketDTO ticketDTO)
        {
            if (ticketDTO == null)
            {
                return BadRequest();
            }

            Ticket ticket = new()
            {
                Description = ticketDTO.Description,
                CreateDateTime = ticketDTO.CreateDateTime,
        };

            _db.Tickets.Add(ticket);
            _db.SaveChanges();

            return CreatedAtRoute("GetTicketById", new { id = ticket.TicketId }, ticketDTO);
        }
        
        [HttpDelete("tickets/delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteTicketById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var foundTicket = _db.Tickets.FirstOrDefault(d => d.TicketId == id);

            if (foundTicket == null)
            {
                return NotFound();
            }

            _db.Tickets.Remove(foundTicket);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
