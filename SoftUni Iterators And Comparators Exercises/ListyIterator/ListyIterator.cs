using System;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T>
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
    }
}
