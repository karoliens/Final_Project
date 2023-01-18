using Final_Project.Models;

namespace Final_Project.Dto
{
    public class GetTicketDTO
    {
        public GetTicketDTO()
        {
        }

        /// <summary>
        /// Kliento ID
        /// </summary>
        public int TicketId { get; set; }

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
        public string TypeOfDevice { get; set; }

        /// <summary>
        /// Paslaugos tipas. Galimos reikšmės Repair ir DataRecovery
        /// </summary>
        public string TypeOfService { get; set; }

        /// <summary>
        /// Gedimo apibūdinimas
        /// </summary>
        public string Description { get; set; }
        

        /*
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? TechnicianId { get; set; }
        public int? DeviceId { get; set; }
        public Ticket? Client { get; set; }
        public List<RepairCategory> RepairCategories { get; set; }
        public Technician? Technician { get; set; }
        public Device? Device { get; set; }
        */
    }
}
