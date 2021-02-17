using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            //Query
            var query = from number in numbers
                        select DoubleIt(number);

            //Lambda
            //var query = numbers.Select(n => DoubleIt(n));

            Console.WriteLine("Before the foreach loop");

            foreach (var item in query)
                Console.WriteLine(item);

            Console.ReadLine();
        }

        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }
    }
}
