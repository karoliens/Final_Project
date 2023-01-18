using Final_Project.Models;

namespace Final_Project.Dto
{
    public class GetRepairCategoryDTO
    {
        public GetRepairCategoryDTO()
        {
        }

        public GetRepairCategoryDTO(RepairCategory repairCategory)
        {
            Name = repairCategory.Name;
        }

        public string Name { get; set; }
    }
}
