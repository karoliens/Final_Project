﻿using Final_Project.Data;
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
        private readonly IRepository<Ticket> _ticketRepo;
        private readonly ITicketAdapter _adapter;

        public TicketController(IRepository<Ticket> ticketRepo, ITicketAdapter adapter)
        {
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
        [HttpGet("{id}", Name ="GetTicketById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetTicketDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult GetTicketById(int ticketId)
        {
            var ticket = _ticketRepo.Get(ticketId);
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
        public ActionResult<CreateTicketDTO> PostTicket(CreateTicketDTO ticketDTO)
        {
            if (ticketDTO == null)
            {
                return BadRequest();
            }

            Ticket newTicket = new()
            {
                Description = ticketDTO.Description,
                // CreateDateTime = ticketDTO.CreateDateTime,
        };

            // _ticketRepo.Tickets.Add(newTicket);
            // _db.SaveChanges();

            return CreatedAtRoute("GetTicketById", new { id = newTicket.TicketId }, ticketDTO);
        }
    }
}
