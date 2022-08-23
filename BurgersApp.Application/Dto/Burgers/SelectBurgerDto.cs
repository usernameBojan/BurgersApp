namespace BurgersApp.Application.Dto.Order
{
    public class SelectBurgerDto
    {
        private const int FriesPrice = 40;
        public int BurgerId { get; set; }
        public string BurgerName { get; set; } = string.Empty;
        public bool IsSelected { get; set; }
        public bool HasFries { get; set; }
        public int Quantity { get; set; }
        public int BurgerPrice { get; set; }
        public int BatchOrderBurgerPrice => HasFries? (BurgerPrice + FriesPrice) * Quantity : BurgerPrice * Quantity;
    }
}