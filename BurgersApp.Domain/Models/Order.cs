namespace BurgersApp.Domain.Models
{
    public class Order : IEntity
    {
        public Order() { }
        public Order(string firstName, string lastName, string address, DateTime orderDate, ICollection<Burger> burgers, Location location)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            OrderDate = orderDate;
            Burgers = burgers;
            Location = location;
        }
        public Order(int id, string firstName, string lastName, string address, DateTime orderDate, ICollection<Burger> burgers, Location location)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            OrderDate = orderDate;
            Burgers = burgers;
            Location = location;
        }
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public string Address { get; set; } = string.Empty;
        public string BurgersInOrder { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<Burger> Burgers { get; set; } = new List<Burger>();
        public Location? Location { get; set; }
        public void ClearBurgers()
        {
            Burgers.Clear();
        }
        public void AddBurger(Burger? burger, int numOfBurgers)
        {
            if (burger == null)
                throw new Exception("Burger doesn't exist");
            
            Enumerable.Range(0, numOfBurgers).ToList().ForEach(_ =>
            {
                Burgers.Add(burger);
            });
        }
    }
}