using Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Dto
{
    public class GetClientDTO
    {
        public GetClientDTO()
        {
        }

        public GetClientDTO(Client client)
        {
            Name = client.Name;
            Email = client.Email;
            PhoneNumber = client.PhoneNumber;
        }

        /// <summary>
        /// Kliento vardas
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Kliento el. pašto adresas
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Kliento telefono numeris
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
