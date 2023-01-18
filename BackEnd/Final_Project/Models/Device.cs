using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Device
    {
        public Device()
        {
        }

        public Device(int deviceId, string model, string type, double imei)
        {
            DeviceId = deviceId;
            Model = model;
            Type = type;
            Imei = imei;
        }

        public int? DeviceId { get; set; }
        public string Model { get; set; }
        public double Imei { get; set; }
        public string Type { get; set; }
        public Ticket? Ticket { get; set; }
        public int? TicketId { get; set; } = null;
    }
}
