using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    [Serializable]
    public class Order
    {
        private int number;
        private double weight;
        public DateTime StartDateDelivery { get; set; }
        public DateTime FinishDateDelivery { get; set; }
        public GeoCoordinate StartPoint { get; set; }
        public GeoCoordinate FinishPoint { get; set; }
        public Courier Courier { get; set; }

        public Order(int number, double weight, GeoCoordinate startPoint, GeoCoordinate finishPoint)
        {
            this.number = number;
            this.weight = weight;
            StartPoint = startPoint;
            FinishPoint = finishPoint;
        }

        public int Number => number;
        public double Weight => weight;
    }
}
