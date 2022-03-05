using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPDelegates
{
    public static class MathDelegateExample
    {
        // Создаем делегат
        delegate int MathDelegate(int a, int b);

        // Создаем метод с аналогичной сигнатурой
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Mul(int x, int y) => x * y;
        
        static int Div(int x, int y) => x / y;

        public static void Example(int a, int b)
        {
            //MathDelegate func1 = new MathDelegate(Add);

            MathDelegate func = Add;
            Console.WriteLine($"{a} + {b} = {func(a, b)}");

            func = Mul;            
            Console.WriteLine($"{a} * {b} = {func(a, b)}");

            func = Div;
            Console.WriteLine($"{a} : {b} = {func(a, b)}");
        }
    }
}
