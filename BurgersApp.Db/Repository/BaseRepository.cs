using BurgersApp.Application.Repository;
using BurgersApp.Domain.Models;

namespace BurgersApp.Db.Repository
{
    public class BaseRepository<T>
        : IRepository<T> where T : class, IEntity
    {
        private readonly ApplicationDbContext dbContext;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public T Create(T entity)
        {
            dbContext.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }
        public T Delete(T entity)
        {
            dbContext.Remove(entity);
            dbContext.SaveChanges();
            return entity;
        }
        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>();
        }
        public T? GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
        public T Update(T entity)
        {
            dbContext.Update(entity);
            dbContext.SaveChanges();
            return entity;
        }
    }
}