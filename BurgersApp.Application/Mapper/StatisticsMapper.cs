using BurgersApp.Application.Dto.Home;
using BurgersApp.Application.Dto.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgersApp.Application.Mapper
{
    public static class StatisticsMapper
    {
        public static StatisticsDto GetStatistics(this IList<OrderDto> orders)
        {
            var ids = orders.SelectMany(x => x.Burgers.Select(b => b.BurgerId)).ToList();

            return new StatisticsDto
            {
                OrdersServed = orders.Count,
                AverageOrderPrice = orders.Count == 0? 0 
                                    : orders.Select(x => x.TotalPrice).Sum() / orders.Count,

                BurgerBestSellerId = orders.Count == 0 ? 0
                                   : ids.GroupBy(i => i)
                                        .OrderByDescending(grp => grp.Count())
                                        .Select(grp => grp.Key)
                                        .First()
            };
        }
    }
}