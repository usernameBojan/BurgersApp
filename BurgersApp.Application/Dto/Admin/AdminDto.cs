using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Dto.Admin
{
    public class AdminDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public string AdminCredentials => $"Admin{FirstName}";
        public string Password { get; set; } = string.Empty;
        public string AuthorizationCode { get; set; } = string.Empty;
    }
}