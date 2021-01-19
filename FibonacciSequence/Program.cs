using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of places in the sequence");
            int placesInSequence = int.Parse(Console.ReadLine());
            var fs = new FibonacciSequence();

            Console.WriteLine("The Fibonacci Sequence up to {0} places", placesInSequence);
            for (int i = 0; i < placesInSequence; i++)
            {
                Console.WriteLine(fs.FibonacciNumbers(i));
            }

            Console.ReadKey();
        }
    }
}
