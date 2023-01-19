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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        [MaxLength(50)]
        public string ClientName { get; set; }
        [MaxLength(50)]
        public string ClientEmail { get; set; }
        [MaxLength(9)]
        public string ClientPhoneNumber { get; set; }
        public DateTime CreateDateTime { get; set; }
        public ETypeOfDevice TypeOfDevice { get; set; }
        public ETypeOfService TypeOfService { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }




        /*
        public Ticket? Client { get; set; }
        public int? ClientId { get; set; }
        public List<RepairCategory> RepairCategories { get; set; }
        public int? RepairCategoryId { get; set; }
        public Technician? Technician { get; set; }
        public int? TechnicianId { get; set; }
        public Device? Device { get; set; }
        public int? DeviceId { get; set; }
        */
    }
}
