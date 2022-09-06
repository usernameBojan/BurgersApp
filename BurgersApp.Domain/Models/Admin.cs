namespace BurgersApp.Domain.Models
{
    public class Admin : IEntity
    {
        public Admin() { }
        public Admin(int id, string name, string surname, string username, string pw, string authCode)
        {
            Id = id;
            FirstName = name;
            LastName = surname;
            Username = username;
            Password = pw;
        }
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;    
        public string FullName => $"{FirstName} {LastName}";
        public string Password { get; set; } = string.Empty;
    }
}