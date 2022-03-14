using System;

namespace csharpspeedrun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("First Name: ");
            var first_name = Console.ReadLine();
            var currentDateTime = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello {first_name}");
            Console.WriteLine($"{Environment.NewLine}registered: {currentDateTime:U}");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            
        }
    }
}