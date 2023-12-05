// See https://aka.ms/new-console-template for more information
using System;

namespace app {
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Give me number: ");
            string? input = Console.ReadLine();
            int? num = input?.Length > 0 ? int.Parse(input): null;
            Console.WriteLine($"Your number is: {num}");
        }
    }
}
