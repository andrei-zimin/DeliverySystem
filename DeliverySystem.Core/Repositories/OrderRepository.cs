using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class OrderRepository : IRepository<Order>
    {
        private List<Order> orders = new List<Order>();
        private const string OrderFileName = "orders.bin";

        public OrderRepository()
        {
            Load();
        }

        public void Add(Order item)
        {
            orders.Add(item);
            Save();
        }

        public List<Order> GetAll()
        {
            return orders;
        }

        public void Remove(Order item)
        {
            orders.Remove(item);
            Save();
        }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite(OrderFileName);

            bf.Serialize(fs, orders);
            fs.Close();
        }

        public void Load()
        {
            if (File.Exists(OrderFileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(OrderFileName);

                orders = (List<Order>)bf.Deserialize(fs);
                fs.Close();
            }
        }
    }
}
