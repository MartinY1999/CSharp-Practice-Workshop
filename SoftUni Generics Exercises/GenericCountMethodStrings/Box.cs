using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        private IList<T> list;

        public Box()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public int Count()
        {
            return this.list.Count;
        }

        public void CompareValues(T value)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].CompareTo(value) > 0)
                    continue;
                else
                {
                    this.list.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}