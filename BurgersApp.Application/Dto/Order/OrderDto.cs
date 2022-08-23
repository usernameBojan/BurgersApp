using BurgersApp.Application.Dto.Burgers;
using BurgersApp.Domain;

namespace BurgersApp.Application.Dto.Order
{
    public class OrderDto
    {
        public int Id { get; set; } 
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public LocationLookUp? Location { get; set; }
        public IList<SelectBurgerDto>? Burgers { get; set; } = new List<SelectBurgerDto>();
        public OrderPayment? Payment { get; set; }
        public int TotalPrice { get; set; }
    }
}