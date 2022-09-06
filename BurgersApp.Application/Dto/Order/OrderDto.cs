namespace BurgersApp.Application.Dto.Order
{
    public class OrderDto
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string BurgersInOrder { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public LocationLookUp? Location { get; set; }
        public ICollection<SelectBurgerDto> Burgers { get; set; } = new List<SelectBurgerDto>();
        public OrderPayment? Payment { get; set; }
        public int TotalPrice { get; set; }
    }
}