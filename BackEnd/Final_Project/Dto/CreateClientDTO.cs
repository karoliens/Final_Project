using Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Dto
{
    public class CreateClientDTO
    {
        public CreateClientDTO()
        {
        }

        /// <summary>
        /// Kliento vardas
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Kliento el. pašto adresas
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Kliento telefono numeris
        /// </summary>
        public string? PhoneNumber { get; set; }
    }
}