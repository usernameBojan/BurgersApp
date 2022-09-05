using System.ComponentModel.DataAnnotations;

namespace BurgersApp.Application.Dto.Order
{
    public class CreateOrderDto
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        public int TotalPrice { get; set; }
        public bool IsCancelled { get; set; }

        public DateTime OrderDate = DateTime.Now;
        public IList<SelectBurgerDto> Burgers { get; set; } = new List<SelectBurgerDto>();
        public LocationLookUp? Location { get; set; }
        [Required]
        public int LocationId { get; set; } 
    }
}