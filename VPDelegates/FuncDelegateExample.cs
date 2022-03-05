using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPDelegates
{
    public static class FuncDelegateExample
    {
        static int Add(int a, int b) => a + b;
        static int Mul(int a, int b) => a * b;

        static int FuncExample(int a, int b, Func<int, int, int> operation) => operation(a, b);

        public static void Example(int a, int b)
        {
            int result = FuncExample(a, b, Add);
            Console.WriteLine($"{a} + {b} = {result}");

            result = FuncExample(a, b, Mul);
            Console.WriteLine($"{a} * {b} = {result}");
        }
    }
}
