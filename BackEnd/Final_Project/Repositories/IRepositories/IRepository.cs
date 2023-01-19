using System.Runtime.InteropServices;

namespace Final_Project.Repositories.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        public IEnumerable<TEntity> All();
        public TEntity Get(int id);
        public int Create(TEntity entity);
        public bool Exist(int id);
    }
}
