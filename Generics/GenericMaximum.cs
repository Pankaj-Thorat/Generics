using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericMax<T> where T : IComparable
    {
        public List<T> items;
        public GenericMax(List<T> items)
        {
            this.items = items;
        }
        
        public T MaxMethod()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Input list must not be empty.");
            }

            // Sort the items in descending order
            items.Sort((x, y) => y.CompareTo(x));

            // Return the first item (maximum value)
            return items[0];
        }
    }
}
