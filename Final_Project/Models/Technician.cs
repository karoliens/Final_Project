using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Technician
    {
        public Technician()
        {
        }

        public Technician(int technicianId, string name)
        {
            TechnicianId = technicianId;
            Name = name;
        }

        public int TechnicianId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
