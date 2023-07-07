using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    [Serializable]
    public class FootCourier : Courier
    {
        public FootCourier(string fio, string phone, int maxWeight) : base(fio, phone, maxWeight)
        {
        }
    }
}
