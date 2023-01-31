using Final_Project.Dto;
using Final_Project.Models;

namespace Final_Project.Services.Adapters.IAdapters
{
    public interface ITicketAdapter
    {
        public GetTicketDTO Bind(Ticket ticket);
        public Ticket Bind(CreateTicketDTO ticket);
    }
}