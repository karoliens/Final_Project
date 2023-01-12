using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Device
    {
        public Device()
        {
        }

        public Device(int deviceId, string model, string type)
        {
            DeviceId = deviceId;
            Model = model;
            Type = type;
        }

        public int DeviceId { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Type { get; set; }
        public Ticket? Ticket { get; set; }
        public int TicketId { get; set; }
    }
}
