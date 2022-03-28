using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBProject.Common.Context;
using MongoDBProject.Common.Interfaces;
using MongoDBProject.Entities.Abstract;
using System.Linq.Expressions;

namespace MongoDBProject.Common.Concrete
{
    public class Repository<Entity> : IRepository<Entity> where Entity : BaseEntity
    {
        private readonly IMongoContext _mongoContext;
        protected IMongoCollection<Entity> _dbCollection;
        public Repository(IMongoContext context)
        {
            _mongoContext = context;
            _dbCollection = _mongoContext.GetCollection<Entity>(typeof(Entity).Name);
        }
        public void Create(Entity entity)
        {
            _dbCollection.InsertOne(entity);
        }

        public void Delete(Entity entity)
        {
            _dbCollection.DeleteOne(x=>x.Id ==entity.Id);
        }

        public async Task<ICollection<Entity>> GetAll(Expression<Func<Entity, bool>> filter = null)
        {
            return filter == null ?  await _dbCollection.FindAsync("{}").Result.ToListAsync() : await _dbCollection.FindAsync(filter).Result.ToListAsync();

        }

        public Entity GetById(string id)
        {
            return _dbCollection.Find(x => x.Id == ObjectId.Parse(id)).First();
        }

        public void Update(Entity entity)
        {
            _dbCollection.ReplaceOneAsync(x=> x.Id == entity.Id,entity);
        }
    }
}
