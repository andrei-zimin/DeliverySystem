using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public interface AssignStrategy
    {
        Courier SelectCourier(Order order, List<Courier> couriers);
    }
}
