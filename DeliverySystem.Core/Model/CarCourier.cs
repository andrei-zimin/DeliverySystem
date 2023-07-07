using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    [Serializable]
    public class CarCourier : Courier
    {
        public string NumberCar { get; set; }

        public CarCourier(string fio, string phone, string numberCar, int maxWeight = 100) : base(fio, phone, maxWeight)
        {
            NumberCar = numberCar;
        }
    }
}
