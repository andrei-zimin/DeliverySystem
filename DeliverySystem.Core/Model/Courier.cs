using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    [Serializable]
    public abstract class Courier
    {
        public string FIO { get; set; }
        public string Phone { get; set; }
        public int MaxWeight { get; set; }
        public bool IsAvailable { get; set; }
        public GeoCoordinate Location { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public Courier(string fio, string phone, int maxWeight)
        {
            FIO = fio;
            Phone = phone;
            MaxWeight = maxWeight;
            IsAvailable = true;
        }

        public override string ToString()
        {
            return FIO;
        }
    }
}
