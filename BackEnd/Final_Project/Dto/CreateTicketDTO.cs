using Final_Project.Models;

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
        public string ClientName { get; set; }

        /// <summary>
        /// Client email
        /// </summary>
        public string ClientEmail { get; set; }

        /// <summary>
        /// Client phone number
        /// </summary>
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
        public string Description { get; set; }
    }
}
