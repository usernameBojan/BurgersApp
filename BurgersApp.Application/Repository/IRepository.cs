using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        T? GetById(int id);
        IQueryable<T> GetAll();
        T Update(T entity);
        T Delete(T entity);
        T Create(T entity);
    }
}