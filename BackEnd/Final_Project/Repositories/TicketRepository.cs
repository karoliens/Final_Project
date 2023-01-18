using Final_Project.Data;
using Final_Project.Models;
using Final_Project.Repositories.IRepositories;

namespace Final_Project.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        private readonly RepairShopContext _db;

        public TicketRepository(RepairShopContext db)
        {
            _db = db;
        }

        public IEnumerable<Ticket> All()
        {
            return _db.Tickets;
        }

        public void Create(Ticket entity)
        {
            _db.Tickets.Add(entity);
            _db.SaveChanges();
        }

        public bool Exist(int id)
        {
            return _db.Tickets.Any(t => t.TicketId == id);
        }

        public Ticket Get(int id)
        {
            return _db.Tickets.Find(id);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
