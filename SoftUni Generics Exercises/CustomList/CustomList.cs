using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CustomList
{
    public class CustomList<T> : ICustomList<T>, IEnumerable<T> where T : IComparable<T>
    {
        private IList<T> list;

        public CustomList()
        {
            this.list = new List<T>();
        }
        public void Add(T element)
        {
            this.list.Add(element);
        }

        public bool Contains(T element)
        {
            return this.list.Contains(element);
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;
            foreach (T item in this.list)
            {
                if (item.CompareTo(element) > 0)
                    count++;
            }

            return count;
        }

        public T Max()
        {
            return this.list.Max();
        }

        public T Min()
        {
            return this.list.Min();
        }

        public T Remove(int index)
        {
            T element = this.list.ElementAt(index);
            this.list.RemoveAt(index);
            return element;
        }

        public void Swap(int index1, int index2)
        {
            T temp = this.list.ElementAt(index1);
            this.list[index1] = this.list[index2];
            this.list[index2] = temp;
        }

        public void Print()
        {
            foreach (T element in this.list)
            {
                Console.WriteLine(element);
            }
        }

        public void Sort()
        {
            this.list = this.list.OrderBy(x => x).ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
