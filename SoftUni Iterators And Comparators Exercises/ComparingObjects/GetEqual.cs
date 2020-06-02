using System.Collections.Generic;

namespace ComparingObjects
{
    public static class GetEqual
    {
        public static int Equal(IList<Person> humans, int indexAt)
        {
            int equal = 0;
            foreach (Person person in humans)
            {
                if (person.CompareTo(humans[indexAt - 1]) == 0)
                    equal++;
            }

            return --equal;
        }
    }
}
