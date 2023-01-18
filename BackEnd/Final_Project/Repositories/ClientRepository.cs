using Final_Project.Data;
using Final_Project.Models;
using Final_Project.Repositories.IRepositories;

namespace Final_Project.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly RepairShopContext _db;
        public ClientRepository(RepairShopContext db) : base(db)
        {
            _db = db;
        }
    }
}
