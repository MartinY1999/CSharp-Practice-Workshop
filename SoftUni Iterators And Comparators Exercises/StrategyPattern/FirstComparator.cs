using System.Collections.Generic;

namespace StrategyPattern
{
    public class FirstComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);
            if (result == 0)
            {
                return x.Name.ToLower().CompareTo(y.Name.ToLower());
            }
            return result;
        }
    }
}
