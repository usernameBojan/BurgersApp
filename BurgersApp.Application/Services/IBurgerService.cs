using BurgersApp.Application.Dto.Burgers;

namespace BurgersApp.Application.Services
{
    public interface IBurgerService
    {
        IList<BurgerDto> GetAllBurgers();
        BurgerDto GetBurger(int id);
        BurgerDto CreateBurger(CreateBurgerDto model);
        BurgerDto EditBurger(BurgerDto model, int id);
        void Delete(int id);
    }
}