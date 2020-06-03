using System;
using System.Linq;

namespace Database.FakeItems
{
    public class FakeCorrectDatabase : IDatabase
    {
        private int currentIndex = 15;

        public int?[] Integers => new int?[] {
            5, 3, 11, 56, 23, 29, 10, 13,
            17, 66, 105, 55, 23, 110, 999, 1067
        };
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
