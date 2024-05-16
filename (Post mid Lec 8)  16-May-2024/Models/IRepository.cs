using System.Collections.Generic;

namespace WebApplication3.Models
{
    public interface IRepository<TEntity>
    {
       /* TEntity FindById(int id);
        public void DeleteById(int id);
        public IEnumerable<TEntity> GetAll();*/
        public void Add(TEntity entity);
        public void Update(TEntity entity);
    }
}
