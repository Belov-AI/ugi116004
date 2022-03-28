using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Warehouse : IEnumerable<Product>
    {
        private readonly Product[] storage;
        public int Count { get; private set; }
        public int Capacity => storage.Length;
        //{ 
        //    get 
        //    { 
        //        return storage.Length; 
        //    } 
        //}

        public Warehouse(int capacity)
        {
            storage = new Product[capacity];
            Count = 0;
        }

        public bool Add(Product product)
        {
            if (Count == Capacity) return false;

            storage[Count++] = product;
            return true;
        }

        public Product GetProductByIndex(int index)
        {
            return storage[index];
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return new WarehouseEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
