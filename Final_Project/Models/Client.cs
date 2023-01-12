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

        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public List<Ticket>? Tickets { get; set; }
    }
}
