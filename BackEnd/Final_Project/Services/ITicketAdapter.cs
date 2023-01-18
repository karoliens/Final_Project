using Final_Project.Dto;
using Final_Project.Models;

namespace Final_Project.Services
{
    public interface ITicketAdapter
    {
        public GetTicketDTO Bind(Ticket ticket);
    }
}