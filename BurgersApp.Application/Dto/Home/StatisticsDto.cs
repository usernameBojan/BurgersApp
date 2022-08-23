using BurgersApp.Application.Dto.Burgers;

namespace BurgersApp.Application.Dto.Home
{
    public class StatisticsDto
    {
        public int OrdersServed { get; set; }
        public int AverageOrderPrice { get; set; }
        public int BurgerBestSellerId { get; set; }
        public BurgerDto? BurgerBestSeller { get; set; }
    }
}