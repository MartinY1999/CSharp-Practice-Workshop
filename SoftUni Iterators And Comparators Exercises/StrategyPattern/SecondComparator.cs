using System.Collections.Generic;

namespace StrategyPattern
{
    public class SecondComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
