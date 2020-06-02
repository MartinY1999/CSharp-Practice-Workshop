using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BalncParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>(input.Substring(input.Length / 2));
            Queue<char> queue = new Queue<char>(input.Substring(0, input.Length / 2));
            bool anotherCheck = Check(input);
            if (anotherCheck)
            {
                bool wrong = false;
                if (input.Length % 2 == 0)
                {
                    while (stack.Count > 0 && queue.Count > 0)
                    {
                        char first = queue.Dequeue();
                        char last = stack.Pop();
                        if (last == '}' && first == '{') continue;
                        else if (last == ']' && first == '[') continue;
                        else if (last == ')' && first == '(') continue;
                        else
                        {
                            wrong = true;
                            goto Done;
                        }
                    }
                }
                else wrong = true;
                Done: ;
                Console.WriteLine(wrong ? "NO" : "YES");
            }
            else Console.WriteLine("YES");
            Console.ReadLine();
        }
        private static bool Check(string input)
        {
            bool wrong = false;
            Stack<char> stack = new Stack<char>();
            foreach (char par in input)
            {
                switch (par)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(par);
                        break;
                    case '}':
                        if (!stack.Any()) wrong = true;
                        else if (stack.Pop() != '{') wrong = true;
                        break;
                    case ']':
                        if (!stack.Any()) wrong = true;
                        else if (stack.Pop() != '[') wrong = true;
                        break;
                    case ')':
                        if (!stack.Any()) wrong = true;
                        else if (stack.Pop() != '(') wrong = true;
                        break;
                }
                if (wrong) break;
            }
            return wrong;
        }
    }
}



