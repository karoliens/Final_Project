using Final_Project.Models;

namespace Final_Project.Dto
{
    public class GetTicketDTO
    {
        public GetTicketDTO()
        {
        }

        public GetTicketDTO(Ticket ticket)
        {
            Description= ticket.Description;
        }
        public string Description { get; set; }
        public Client? Client { get; set; }
        public List<RepairCategory> RepairCategories { get; set; }
        public Technician? Technician { get; set; }
        public Device Device { get; set; }
    }
}
