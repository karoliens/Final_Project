using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Ticket
    {
        public Ticket()
        {
        }

        public Ticket(int? ticketId, string description, DateTime createDateTime, int? clientId, int? technicianId, int? deviceId, int? repairCategoryId)
        {
            TicketId = ticketId;
            Description = description;
            CreateDateTime = createDateTime;
            ClientId = clientId;
            TechnicianId = technicianId;
            DeviceId = deviceId;
            RepairCategoryId = repairCategoryId;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? TicketId { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Client? Client { get; set; }
        public int? ClientId { get; set; }
        public List<RepairCategory> RepairCategories { get; set; }
        public int? RepairCategoryId { get; set; }
        public Technician? Technician { get; set; }
        public int? TechnicianId { get; set; }
        public Device? Device { get; set; }
        public int? DeviceId { get; set; }
    }
}
