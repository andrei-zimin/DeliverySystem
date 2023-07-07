using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class MinimalDistanceStrategy : AssignStrategy
    {
        public Courier SelectCourier(Order order, List<Courier> couriers)
        {
            var filterCouriers = couriers.Where(t => t.IsAvailable && t.MaxWeight > order.Weight);
            filterCouriers = filterCouriers.OrderBy(t => t.Location.GetDistanceTo(order.StartPoint));

            return filterCouriers.FirstOrDefault();
        }
    }
}
