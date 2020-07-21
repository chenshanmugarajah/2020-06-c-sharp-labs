using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFNorthwind
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //var orderQuery =
                //from order in db.Orders
                //where order.Freight > 750
                //select order;
                //foreach (var order in orderQuery)
                //{
                //    Console.WriteLine($"{order.CustomerId} paid {order.Freight} for shipping to {order.ShipCity}");
                //}

                //var orderQueryWithCust =
                //    from order in db.Orders.Include(o => o.Customer)
                //    where order.Freight > 750
                //    select order;

                //foreach (var order in orderQueryWithCust)
                //{
                //    if (order.Customer != null)
                //    {
                //        Console.WriteLine($"{order.Customer.ContactName} of {order.Customer.City} paid {order.Freight} for shipping");
                //    }
                //}

                var orderQueryUsingInnerJoin =
                    from order in db.Orders
                    where order.Freight > 750
                    join customer in db.Customers on order.CustomerId equals customer.CustomerId
                    select new { CustomerContactName = customer.ContactName, City = customer.City, Freight = order.Freight };

                foreach (var result in orderQueryUsingInnerJoin)
                {
                    Console.WriteLine($" {result.CustomerContactName} of {result.City} paid {result.Freight} for shipping");
                }
            }
        }
    }
}