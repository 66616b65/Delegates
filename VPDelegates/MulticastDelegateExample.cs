using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPDelegates
{
    public static class MulticastDelegateExample
    {
        public delegate void showDelegate(int a, int b);
        
        public static void Add(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");

        public static void Mul(int a, int b) => Console.WriteLine($"{a} * {b} = {a * b}");
        
        public static void Example(int a, int b)
        {
            showDelegate s = Add;
            s += Mul;
            //s -= Mul;
            s(a, b);
        }
    }
}
