using Final_Project.Models;

namespace Final_Project.Dto
{
    public class CreateTicketDTO
    {
        public CreateTicketDTO()
        {
        }

        /// <summary>
        /// Kliento vardas
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// Kliento el. pašto adresas
        /// </summary>
        public string ClientEmail { get; set; }

        /// <summary>
        /// Kliento telefono numeris
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
        /// Gedimo apibūdinimas
        /// </summary>
        public string Description { get; set; }
    }
}
