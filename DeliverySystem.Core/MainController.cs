using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class MainController
    {
        CourierRepository courierRepo = new CourierRepository();
        OrderRepository orderRepo = new OrderRepository();
        private int number = 1;
        public AssignStrategy AssignStrategy { get; set; }

        public MainController(AssignStrategy assignStrategy)
        {
            AssignStrategy = assignStrategy;

            foreach (var item in Orders)
            {
                if (item.Courier != null)
                    item.Courier = Couriers.FirstOrDefault(t => t.FIO == item.Courier.FIO && t.Phone == item.Courier.Phone);
            }
        }

        public void AddCourier(Courier courier)
        {
            courierRepo.Add(courier);
        }

        public List<Courier> Couriers => courierRepo.GetAll();
        public List<Order> Orders => orderRepo.GetAll();

        public Order AddOrder(double weight, GeoCoordinate startPoint, GeoCoordinate finishPoint)
        {
            Order order = new Order(number, weight, startPoint, finishPoint);
            orderRepo.Add(order);
            number++;
            return order;
        }

        public bool AssignCourier(Order order)
        {
            Courier findCourier = AssignStrategy.SelectCourier(order, courierRepo.GetAll());
            if (findCourier == null)
                return false;
            findCourier.Orders.Add(order);
            order.Courier = findCourier;
            findCourier.IsAvailable = false;
            order.StartDateDelivery = DateTime.Now;
            orderRepo.Save();
            courierRepo.Save();
            return true;
        }

        public void CompleteOrder(Order order)
        {
            order.Courier.IsAvailable = true;
            order.FinishDateDelivery = DateTime.Now;
            orderRepo.Save();
            courierRepo.Save();
        }
    }
}
