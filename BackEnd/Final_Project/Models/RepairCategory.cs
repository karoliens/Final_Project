using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class RepairCategory
    {
        public RepairCategory()
        {
        }

        public RepairCategory(int repairCategoryId, string name)
        {
            RepairCategoryId = repairCategoryId;
            Name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? RepairCategoryId { get; set; }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
