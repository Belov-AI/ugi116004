using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class WarehouseEnumerator : IEnumerator<Product>
    {
        readonly Warehouse warehouse;
        int currentIndex;
        public Product Current => warehouse.GetProductByIndex(currentIndex);

        object IEnumerator.Current => warehouse.GetProductByIndex(currentIndex);


        public WarehouseEnumerator(Warehouse warehouse)
        {
            this.warehouse = warehouse;
            currentIndex = -1;
        }

        public void Dispose() {}

        public bool MoveNext()
        {
            if (++currentIndex >= warehouse.Count) return false;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
