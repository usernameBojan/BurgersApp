using System.ComponentModel.DataAnnotations;

namespace BurgersApp.Application.Dto.Home
{
    public class LoginDto
    {
        [Required]
        public string Userame { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

    }
}