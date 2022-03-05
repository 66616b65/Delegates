using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPDelegates
{
    public static class ActionDelegateExample
    {
        static void Add(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
        static void Mul(int a, int b) => Console.WriteLine($"{a} * {b} = {a * b}");

        static void ActionExample(int a, int b, Action<int, int> operation)
        {
            operation(a, b);
        }
          //  => operation(a, b);

        public static void Example(int a, int b)
        {
            ActionExample(a, b, Add);
            ActionExample(a, b, Mul);
        }
    }
}
