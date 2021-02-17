using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises9To10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = GetCustomers();

            //Query
            #region Query
            //var outputCustomers = from customer in customers
            //                      orderby customer.Name ascending //Ordered Alphabetically
            //                      where customer.City.Equals("Dublin") //City = Dublin
            //                      select customer;
            #endregion

            //Lambda
            #region Lambda
            var outputCustomers = customers
                .OrderBy(c => c.Name) //Ordered Alphabetically
                .Where(c => c.City.Equals("Dublin")); //City = Dublin
            #endregion

            foreach (Customer customer in outputCustomers)
                Console.WriteLine(customer.Name);
        }

        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Jow", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            return customers;
        }
    }

    public class Customer
    {
        public string Name;
        public string City;
    }
}
