using System;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            //Query
            #region Query Chained
            //var query1 = from number in numbers
            //             orderby number descending
            //             select number;

            //var query2 = from number in query1
            //             where number < 8
            //             select number;

            //var query3 = from number in query2
            //             select DoubleIt(number);

            //foreach (var item in query3)
            //    Console.WriteLine(item);
            #endregion

            #region Query Single
            var query4 = from number in numbers
                         orderby number descending
                         where number < 8
                         select DoubleIt(number);

            foreach (var item in query4)
                Console.WriteLine(item);
            #endregion

            //Lambda
            #region Lambda Chained
            //var query1 = numbers.OrderByDescending(n => n);

            //var query2 = query1.Where(n => n < 8);

            //var query3 = query2.Select(n => DoubleIt(n));

            //foreach (var item in query3)
            //    Console.WriteLine(item);
            #endregion

            #region Lambda Single
            //var query4 = numbers
            //    .OrderByDescending(n => n)
            //    .Where(n => n < 8)
            //    .Select(n => DoubleIt(n));

            //foreach (var item in query4)
            //    Console.WriteLine(item);
            #endregion

            Console.ReadLine();
        }

        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }
    }
}
