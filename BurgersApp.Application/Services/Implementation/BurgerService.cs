using BurgersApp.Application.Mapper;
using BurgersApp.Application.Repository;
using BurgersApp.Application.Dto.Burgers;
using BurgersApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgersApp.Application.Services.Implementation
{
    public class BurgerService : IBurgerService
    {
        private readonly IRepository<Burger> repository;
        public BurgerService(IRepository<Burger> repository)
        {
            this.repository = repository;
        }
        public BurgerDto CreateBurger(CreateBurgerDto dto)
        {
            var burger = dto.ToBurger();

            var created = repository.Create(burger);
            return created.ToBurgerDto();
        }
        public void Delete(int id)
        {
            var burger = repository.GetById(id);
            if (burger == null)
            {
                throw new Exception("Burger not found");
            }

            repository.Delete(burger);
        }
        public BurgerDto EditBurger(BurgerDto dto, int id)
        {
            var burger = repository.GetById(id);

            if (burger == null)
            {
                throw new Exception("Burger not found");
            }
            var updated = burger.Edit(dto);

            repository.Update(updated);

            return updated.ToBurgerDto();
        }
        public IList<BurgerDto> GetAllBurgers()
        {
            var burgers = repository.GetAll()
                                    .Select(x => x.ToBurgerDto());

            return burgers.ToList();
        }
        public BurgerDto GetBurger(int id)
        {
            var burger = repository.GetById(id);

            if (burger == null)
            {
                throw new Exception("Not found");
            }
            return burger.ToBurgerDto();
        }
    }
}