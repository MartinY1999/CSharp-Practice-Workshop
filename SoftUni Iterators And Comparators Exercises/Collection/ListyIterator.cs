using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public IList<T> List { get; set; }
        private int currentIndex = 0;

        public ListyIterator()
        {
            List = new List<T>();
        }

        public ListyIterator(T[] list)
        {
            List = list;
        }

        public bool Move()
        {
            return (++currentIndex) < this.List.Count;
        }

        public bool HasNext()
        {
            return (currentIndex + 1) < this.List.Count;
        }

        public void Print()
        {
            try
            {
                Console.WriteLine(this.List[currentIndex]);
            }
            catch
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.List.Count; i++)
            {
                yield return this.List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void PrintAll()
        {
            IList<T> current = new List<T>();
            foreach (T element in this.List)
            {
                current.Add(element);
            }
            Console.WriteLine(String.Join(" ", current));
        }
    }
}
