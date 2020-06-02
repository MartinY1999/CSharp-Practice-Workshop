using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private IList<int> numbers;

        public Lake(IList<int> numbers)
        {
            this.numbers = numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                    even.Add(numbers[i]);
                else
                    odd.Add(numbers[i]);
            }
            odd.Reverse();
            List<int> whole = new List<int>();
            whole.AddRange(even);
            whole.AddRange(odd);
            for (int i = 0; i < whole.Count; i++)
            {
                yield return whole[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
