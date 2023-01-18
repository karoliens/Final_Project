using System.Runtime.InteropServices;

namespace Final_Project.Repositories.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public List<TEntity> ReadAll();
        public void Create(TEntity entity);
        public void Save();
    }
}
