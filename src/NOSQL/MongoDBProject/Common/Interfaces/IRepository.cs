using MongoDBProject.Entities.Abstract;
using System.Linq.Expressions;

namespace MongoDBProject.Common.Interfaces
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {
        void Create(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
        Task<ICollection<Entity>> GetAll(Expression<Func<Entity,bool>> filter =null);
        Entity GetById(string id);
    }
}
