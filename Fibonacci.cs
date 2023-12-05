using System;

namespace Fibonacci
{
    public class FibonacciClass {
        public void GenerateFibonacci() {
            Console.Write("Give a number: ");
            string? read = Console.ReadLine();
            int? num = read?.Length > 0 ? int.Parse(read) : null;
            int first = 0, sec = 1, sum;
            Console.WriteLine("-------------------------- ");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(first);
                // 1+0=1, 1+1=2, 1+2=3, 2+3=5, 3+5=8 ...
                sum = first + sec;
                first = sec;
                sec = sum;
            }
        }
    }
}