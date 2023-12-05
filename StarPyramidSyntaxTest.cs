// See https://aka.ms/new-console-template for more information
using System;

namespace app {
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("How tall is the pyramid?: ");
            string? input = Console.ReadLine();
            int? num = input?.Length > 0 ? int.Parse(input) : null;

            for (int row = 0; row <= num; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
