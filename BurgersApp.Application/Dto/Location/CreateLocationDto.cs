namespace BurgersApp.Application.Dto.Location
{
    public class CreateLocationDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Opens { get; set; } = string.Empty;
        public string Closes { get; set; } = string.Empty;
        public string WorkingDaysAndHours { get; set; } = string.Empty;
    }
}