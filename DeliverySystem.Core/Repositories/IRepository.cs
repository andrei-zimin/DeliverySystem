using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Remove(T item);

        void Save();
    }
}
