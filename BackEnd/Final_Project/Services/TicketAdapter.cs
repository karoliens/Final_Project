using Final_Project.Dto;
using Final_Project.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Final_Project.Services
{
    public class TicketAdapter : ITicketAdapter
    {
        public GetTicketDTO Bind(Ticket ticket)
        {
            return new GetTicketDTO
            {
                TicketId = ticket.TicketId,
                ClientName = ticket.ClientName,
                ClientEmail = ticket.ClientEmail,
                ClientPhoneNumber = ticket.ClientPhoneNumber,
                TypeOfDevice = ticket.TypeOfDevice.ToString(),
                TypeOfService = ticket.TypeOfService.ToString(),
                Description = ticket.Description,
            };
        }

        public Ticket Bind(CreateTicketDTO ticket)
        {
            return new Ticket
            {
                ClientName = ticket.ClientName,
                ClientEmail = ticket.ClientEmail,
                ClientPhoneNumber = ticket.ClientPhoneNumber,
                CreateDateTime = DateTime.Now,
                // TypeOfDevice = (ETypeOfDevice)Enum.Parse(typeof(ETypeOfDevice), ticket.TypeOfDevice),
                // TypeOfService = (ETypeOfService)Enum.Parse(typeof(ETypeOfService), ticket.TypeOfService),
                Description = ticket.Description,
            };
        }
    }
}
