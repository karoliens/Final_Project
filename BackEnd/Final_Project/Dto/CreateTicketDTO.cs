using Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Dto
{
    public class CreateTicketDTO
    {
        public CreateTicketDTO()
        {
        }

        /// <summary>
        /// Client name
        /// </summary>
        [MaxLength(50, ErrorMessage = "Maximum allowed characters is 50")]
        [Required(ErrorMessage = "Client name is required")]
        public string ClientName { get; set; }

        /// <summary>
        /// Client email
        /// </summary>
        [MaxLength(50, ErrorMessage = "Maximum allowed characters is 50")]
        [Required(ErrorMessage = "Client email is required")]
        public string ClientEmail { get; set; }

        /// <summary>
        /// Client phone number
        /// </summary>
        [MaxLength(9, ErrorMessage = "Maximum allowed characters is 9")]
        [Required(ErrorMessage = "Client phone number is required")]
        public string ClientPhoneNumber { get; set; }

        /// <summary>
        /// Įrenginio tipas. Galimos reikšmės iPhone, iPad, Android, Other
        /// </summary>
        // public string TypeOfDevice { get; set; }

        /// <summary>
        /// Paslaugos tipas. Galimos reikšmės Repair ir DataRecovery
        /// </summary>
        // public string TypeOfService { get; set; }

        /// <summary>
        /// Description of the problem
        /// </summary>
        [MaxLength(150, ErrorMessage = "Maximum allowed characters is 150")]
        [Required(ErrorMessage = "Description of the problem is required")]
        public string Description { get; set; }
    }
}
