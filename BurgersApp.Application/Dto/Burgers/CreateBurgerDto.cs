namespace BurgersApp.Application.Dto.Burgers
{
    public class CreateBurgerDto
    {
        public string Name { get; set; } = string.Empty;
        public string Ingredients { get; set; } = string.Empty;
        public string ImgSrc { get; set; } = string.Empty;
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
    }
}