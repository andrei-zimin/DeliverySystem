using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeliverySystem
{
    public class CourierRepository : IRepository<Courier>
    {
        private List<Courier> couriers = new List<Courier>();
        private const string CourierFileName = "couriers.bin";

        public CourierRepository()
        {
            Load();
        }

        public void Add(Courier item)
        {
            couriers.Add(item);
            Save();
        }

        public List<Courier> GetAll()
        {
            return couriers;
        }

        public void Remove(Courier item)
        {
            couriers.Remove(item);
            Save();
        }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(CourierFileName);

            bf.Serialize(fs, couriers);
            fs.Close();
        }

        public void Load()
        {
            if (File.Exists(CourierFileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(CourierFileName);

                couriers = (List<Courier>)bf.Deserialize(fs);
                fs.Close();
            }
        }
    }
}
