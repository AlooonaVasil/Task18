using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var str = Console.ReadLine();
            Console.WriteLine($"Количество скобок корректно? {Check(str)}");
            Console.ReadKey();
        }
        static bool Check(string str)
        {
            var stack = new Stack<char>();
            var brackets = new Dictionary<char, char>
            {
                {'(',')'},
                {'{','}'},
                {'[',']'},
            };

            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(brackets[c]);
                }

                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
