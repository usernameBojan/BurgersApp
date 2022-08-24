using BurgersApp.Domain.Models;

namespace BurgersApp.Db
{
    public static class OrdersStaticDb
    {
        public static IList<Order> Orders { get; set; } = new List<Order> { };
    }
}