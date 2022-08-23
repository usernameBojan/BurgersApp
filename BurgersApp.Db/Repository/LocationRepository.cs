using BurgersApp.Application.Repository;
using BurgersApp.Domain.Models;

namespace BurgersApp.Db.Repository
{
    public class LocationRepository : IRepository<Location>
    {
        public Location Create(Location entity)
        {
            var lastId = IntDb.Locations.LastOrDefault()?.Id ?? 0;
            entity.Id = ++lastId;
            IntDb.Locations.Add(entity);
            return entity;
        }
        public void Delete(int id)
        {
            var location = GetById(id);
            IntDb.Locations.Remove(location);
        }
        public void DeleteAll()
        {
            IntDb.Locations.Clear();
        }
        public IQueryable<Location> GetAll()
        {
            return IntDb.Locations.AsQueryable();
        }
        public Location? GetById(int id)
        {
            return IntDb.Locations.FirstOrDefault(x => x.Id == id);
        }
        public void Update(Location entity)
        {
            var location = GetById(entity.Id);
            location = entity;
        }
    }
}