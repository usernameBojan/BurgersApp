using BurgersApp.Application.Mapper;
using BurgersApp.Application.Repository;
using BurgersApp.Application.ViewModel.Burgers;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Services.Implementation
{
    public class BurgerService : IBurgerService
    {
        private readonly IRepository<Burger> repository;
        public BurgerService(IRepository<Burger> repository)
        {
            this.repository = repository;
        }

        public BurgerViewModel CreateBurger(CreateBurgerViewModel model)
        {
            var burger = model.ToBurger();

            var newItem = repository.Create(burger);
            return newItem.ToBurgerViewModel();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public BurgerViewModel EditBurger(BurgerViewModel model, int id)
        {
            var burger = repository.GetById(id);

            if (burger == null)
            {
                throw new Exception("Burger not found");
            }
            var toSave = burger.Edit(model);

            repository.Update(toSave);

            return toSave.ToBurgerViewModel();
        }

        public IList<BurgerViewModel> GetAllBurgers()
        {
            return repository.GetAll().Select(x => x.ToBurgerViewModel()).ToList();
        }

        public BurgerViewModel GetBurger(int id)
        {
            var burger = repository.GetById(id);

            if (burger == null)
            {
                throw new Exception("Not found");
            }
            return burger.ToBurgerViewModel();
        }
    }
}