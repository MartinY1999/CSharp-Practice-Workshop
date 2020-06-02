using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings : List<string>
    {
        private List<string> data = new List<string>();
        public void Push(string element)
        {
            data.Add(element);
        }
        public string Pop()
        {
            string result = GetLastElement();
            data.RemoveAt(data.Count - 1);
            return result;
        }
        public string Peek()
        {
            return GetLastElement();
        }
        public bool IsEmpty()
        {
            return data.Count == 0;
        }
        private string GetLastElement()
        {
            if (IsEmpty()) throw new ArgumentException("Empty list.");
            return data.Last();
        }
    }
}
