using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private IList<T> list;
        public int Count => this.list.Count;

        public Box()
        {
            this.list = new List<T>();
        }
        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove()
        {
            T removed = this.list.LastOrDefault();
            this.list.RemoveAt(this.list.Count - 1);
            return removed;
        }
    }
}
