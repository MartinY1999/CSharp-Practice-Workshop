using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;
        public Random Random
        {
            get => random;
            private set => random = value;
        }
        public RandomList()
        {
            Random = new Random();
        }
        public string RandomString()
        {
            string result = string.Empty;
            int index = Random.Next(0, Count - 1);
            result = this[index];
            RemoveAt(index);
            return result;
        }
    }
}
