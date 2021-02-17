using System;
using System.IO;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousQuery();
            //AnonymousLambda();
        }

        private static void AnonymousQuery()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new //No Class Name Here this time
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };

            Console.WriteLine("Filename\tSize\t\tCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine("{0} \t{1} bytes, \t{2}",
                    item.Name, item.Length, item.CreationTime);
            }

            Console.ReadLine();
        }

        private static void AnonymousLambda()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = files
                .Where(f => f.Length > 10000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new //No Class Name Here this time
                {
                    Name = f.Name,
                    Length = f.Length,
                    CreationTime = f.CreationTime
                });

            Console.WriteLine("Filename\tSize\t\tCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine("{0} \t{1} bytes, \t{2}",
                    item.Name, item.Length, item.CreationTime);
            }

            Console.ReadLine();
        }
    }
}
