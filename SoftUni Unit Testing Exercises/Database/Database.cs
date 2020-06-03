using System;
using System.Linq;

namespace Database
{
    public class Database : IDatabase
    {
        private int currentIndex;
        public int?[] Integers { get; }

        public Database(params int?[] numbers)
        {
            if (numbers.Length != 16)
                throw new InvalidOperationException("Wrong length!");
            Integers = numbers;
            this.currentIndex = 15;
        }
        public void Add(int element)
        {
            if (this.currentIndex == 15)
                throw new InvalidOperationException("Full array!");
            this.currentIndex++;
            Integers[currentIndex] = element;
        }
        public void Remove()
        {
            if (this.currentIndex == -1)
                throw new InvalidOperationException("Database is already empty");
            Integers[this.currentIndex] = null;
            this.currentIndex--;
        }
        public int?[] Fetch()
        {
            return Integers.Where(x => x != null).ToArray();
        }
    }
}
