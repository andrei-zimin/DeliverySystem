using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class MinimalCountOrdersStrategy : AssignStrategy
    {
        public Courier SelectCourier(Order order, List<Courier> couriers)
        {
            var filterCouriers = couriers.Where(t => t.IsAvailable && t.MaxWeight > order.Weight);
            filterCouriers = filterCouriers.OrderBy(t => t.Orders.Count(p => p.StartDateDelivery.Date == DateTime.Now.Date));

            return filterCouriers.FirstOrDefault();
        }
    }
}
