using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    class MyMathThing
    {
        public int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public void Main(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
