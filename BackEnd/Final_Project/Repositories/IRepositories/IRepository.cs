using System.Runtime.InteropServices;

namespace Final_Project.Repositories.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        public IEnumerable<TEntity> All();
        public TEntity Get(int id);
        public void Create(TEntity entity);
        public void Save();
        public bool Exist(int id);
    }
}
