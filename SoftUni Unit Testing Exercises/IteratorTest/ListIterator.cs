using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorTest
{
    public class ListIterator
    {
        private readonly IList<string> collection;
        private int index;

        public ListIterator()
        {
            this.collection = new List<string>();
        }

        public ListIterator(List<string> collection)
        {
            if (collection is null)
                throw new ArgumentNullException("Collection given is null!");
            this.collection = collection;
            index = 0;
        }

        public bool Move()
        {
            if (++index <= collection.Count - 1)
                return true;
            else
            {
                index--;
                return false;
            }
        }

        public bool HasNext()
        {
            return index + 1 <= collection.Count - 1;
        }

        public void Print()
        {
            if (collection.Count == 0)
                throw new InvalidOperationException("Empty collection.");
            Console.WriteLine(collection[index]);
        }

        public static ListIterator Create(string parametres)
        {
            if (parametres is null)
                throw new ArgumentNullException("Collection given is null!");
            string[] parts = parametres.Split(' ')
                .Skip(1)
                .Take(parametres.Split(' ').Length - 1)
                .ToArray();
            return new ListIterator(parts.ToList());
        }
    }
}
