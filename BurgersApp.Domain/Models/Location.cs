using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Domain.Models
{
    public class Location : IEntity
    {
        public Location()
        {

        }
        public Location(string name, string address, string opens, string closes)
        {
            Name = name;
            Address = address;
            OpensAt = opens;
            ClosesAt = closes;           
        }
        public Location(int id, string name, string address, string opens, string closes)
        {
            Id = id;
            Name = name;
            Address = address;
            OpensAt = opens;
            ClosesAt = closes;   
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WorkingDaysAndHours => $"Monday - Saturday \n {OpensAt} - {ClosesAt}";
        public string OpensAt { get; set; }
        public string ClosesAt { get; set; }
        public bool IsWeeknightProlonged { get; set; }  
    }
}
 