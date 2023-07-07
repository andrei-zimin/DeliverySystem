using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    [Serializable]
    public class GeoCoordinate
    {
        private double latitude, longitude;

        public GeoCoordinate(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public double GetDistanceTo(GeoCoordinate other)
        {
            return Math.Sqrt(Math.Pow(latitude - other.latitude, 2) + Math.Pow(longitude - other.longitude, 2));
        }

        public override string ToString()
        {
            return latitude + ";" + longitude;
        }
    }
}
