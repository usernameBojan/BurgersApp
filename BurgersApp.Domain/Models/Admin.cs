namespace BurgersApp.Domain.Models
{
    public class Admin
    {
        public Admin() { }
        public Admin(string name, string surname, string username, string pw, string authCode)
        {
            FirstName = name;
            LastName = surname;
            Password = username;
            Password = pw;
            AuthorizationCode = authCode;
        }
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