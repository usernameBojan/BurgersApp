using BurgersApp.Application.ViewModel.Burgers;


namespace BurgersApp.Application.Services
{
    public interface IBurgerService
    {
        IList<BurgerViewModel> GetAllBurgers();
        BurgerViewModel GetBurger(int id);
        BurgerViewModel CreateBurger(CreateBurgerViewModel model);
        BurgerViewModel EditBurger(BurgerViewModel model, int id);
        void Delete(int id);
    }
}
