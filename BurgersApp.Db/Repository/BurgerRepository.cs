using BurgersApp.Application.Repository;
using BurgersApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Db.Repository
{
    public class BurgerRepository : IRepository<Burger>
    {
        public Burger GetById(int id)
        {
            return IntDb.Burgers.FirstOrDefault(x => x.Id == id);
        }
        public Burger Create(Burger entity)
        {
            var lastId = IntDb.Burgers.LastOrDefault()?.Id ?? 0;
            entity.Id = ++lastId;
            IntDb.Burgers.Add(entity);
            return entity;
        }

        public void Delete(int id)
        {
            var burger = GetById(id);
            IntDb.Burgers.Remove(burger);
        }

        public void DeleteAll()
        {
            IntDb.Burgers.Clear();
        }

        public IQueryable<Burger> GetAll()
        {
            return IntDb.Burgers.AsQueryable();
        }
        public void Update(Burger entity)
        {
            var burger = GetById(entity.Id);
            burger = entity;
        }
    }
}
