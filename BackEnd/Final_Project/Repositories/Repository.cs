using Final_Project.Data;
using Final_Project.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly RepairShopContext _db;
        private DbSet<TEntity> _dbSet;

        public Repository(RepairShopContext db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _db.Add(entity);
            Save();
        }

        public List<TEntity> ReadAll()
        {
            IQueryable<TEntity> query = _dbSet;

            return query.ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
