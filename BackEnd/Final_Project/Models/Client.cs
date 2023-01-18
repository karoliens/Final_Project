using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Client
    {
        public Client()
        {
        }

        public Client(int clientId, string name, string email, string phoneNumber)
        {
            ClientId = clientId;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        [Key]
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Ticket>? Tickets { get; set; }
    }
}
