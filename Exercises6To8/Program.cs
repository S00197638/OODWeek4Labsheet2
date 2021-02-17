using System;
using System.Linq;

namespace Exercises6To8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            #region Exercise6&7
            //Ordered Alphabetically
            //Query
            #region Query
            //var outputNames = from name in names
            //                        orderby name ascending
            //                        select name;
            #endregion

            //Lambda
            #region Lambda
            var outputNames = names.OrderBy(n => n);
            #endregion

            foreach (string name in outputNames)
                Console.WriteLine(name);
            #endregion
        }
    }
}
