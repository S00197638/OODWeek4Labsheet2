using System;
using System.Linq;

namespace Exercises6To8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };
            string character = "M";

            //Query
            #region Query
            //var outputNames = from name in names
            //                  orderby name ascending //Ordered Alphabetically
            //                  where name.StartsWith(character) //Starts with M
            //                  select name;
            #endregion

            //Lambda
            #region Lambda
            var outputNames = names
                .OrderBy(n => n) //Ordered Alphabetically
                .Where(n => n.StartsWith(character)); //Starts with M
            #endregion

            foreach (string name in outputNames)
                Console.WriteLine(name);
        }
    }
}
