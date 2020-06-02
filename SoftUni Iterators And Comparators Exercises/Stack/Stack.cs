using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> list;

        public Stack()
        {
            this.list = new List<T>();
        }

        public void Push(List<T> items)
        {
            this.list.AddRange(items);
        }

        public void Pop()
        {
            try
            {
                this.list.RemoveAt(this.list.Count - 1);
            }
            catch
            {
                Console.WriteLine("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            this.list.Reverse();
            for (int i = 1; i <= 2; i++)
            {
                for (int k = 0; k < this.list.Count; k++)
                {
                    yield return this.list[k];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
