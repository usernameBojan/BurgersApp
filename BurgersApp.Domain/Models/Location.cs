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
        public Location(string name, string address, string opens, string closes, bool isWeeknightProlonged)
        {
            Name = name;
            Address = address;
            OpensAt = opens;
            ClosesAt = closes;
            WorkingDaysAndHours = $"Monday - Saturday \n {opens} - {closes}";
            IsWeeknightProlonged = isWeeknightProlonged;

            if (isWeeknightProlonged)
            {
                WorkingDaysAndHours = $"Monday - Thursday \n {opens} - {closes} \n Friday: 10:00 - 06:00 \n Saturday: 12:00 - 06:00";
            }
        }
        public Location(int id, string name, string address, string opens, string closes, bool isWeeknightProlonged)
        {
            Id = id;
            Name = name;
            Address = address;
            OpensAt = opens;
            ClosesAt = closes;
            WorkingDaysAndHours = $"Monday - Saturday \n {opens} - {closes}";
            IsWeeknightProlonged = isWeeknightProlonged;

            if (isWeeknightProlonged)
            {
                WorkingDaysAndHours = $"Monday - Thursday \n {opens} - {closes} \n Friday: 10:00 - 06:00 \n Saturday: 12:00 - 06:00";
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WorkingDaysAndHours { get; set; }
        public string OpensAt { get; set; }
        public string ClosesAt { get; set; }
        public bool IsWeeknightProlonged { get; set; }  
    }
}
 