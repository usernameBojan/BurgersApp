using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Domain.Models
{
    public class Order : IEntity
    {
        public Order()
        {

        }
        public Order(string firstName, string lastName, string address, ICollection<Burger> burgers, Location location)
        {
            FullName = $"{firstName} + {lastName}";
            Address = address;
            Burgers = burgers;
            Location = location;
        }
        public Order(int id, string firstName, string lastName, string address, ICollection<Burger> burgers, Location location)
        {
            Id = id;
            FullName = $"{firstName} + {lastName}";
            Address = address;
            Burgers = burgers;
            Location = location;
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public ICollection<Burger> Burgers { get; set; }

        public Location Location { get; set; }

        public void ClearBurgers()
        {
            Burgers.Clear();
        }

        public void AddBurger(Burger? burger, int numOfBurgers)
        {
            if (burger == null)
                throw new Exception("Pizza doesn't exist");

            Enumerable.Range(0, numOfBurgers).ToList().ForEach(_ =>
            {
                Burgers.Add(burger);
            });
        }
    }
}
