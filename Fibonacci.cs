using System;

namespace Fibonacci
{
    public class FibonacciClass {
        public void GenerateFibonacci() {
            Console.Write("Give a number: ");
            int read = Convert.ToInt32(Console.ReadLine());
            int first = 0, sec = 1, sum;
            Console.WriteLine("-------------------------- ");
            for (int i = 0; i < read; i++)
            {
                Console.WriteLine(first);
                // 0+1=1, 1+1=2, 1+2=3, 2+3=5, 3+5=8 ...
                sum = first + sec;
                first = sec;
                sec = sum;
            }
        }
    }
}