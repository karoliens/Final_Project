using Final_Project.Models;

namespace Final_Project.Dto
{
    public class CreateTicketDTO
    {
        public CreateTicketDTO()
        {
        }

        public CreateTicketDTO(string description, DateTime createDateTime)
        {
            Description = description;
            CreateDateTime = createDateTime;
        }

        public string? Description { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
