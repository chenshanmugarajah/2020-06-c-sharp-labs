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

                //var orderQueryUsingInnerJoin =
                //    from order in db.Orders
                //    where order.Freight > 750
                //    join customer in db.Customers on order.CustomerId equals customer.CustomerId
                //    select new { CustomerContactName = customer.ContactName, City = customer.City, Freight = order.Freight };

                //foreach (var result in orderQueryUsingInnerJoin)
                //{
                //    Console.WriteLine($" {result.CustomerContactName} of {result.City} paid {result.Freight} for shipping");
                //}

                //var customersInParisOrLondon =
                //    from customer in db.Customers
                //    where customer.City == "London" || customer.City == "Paris"
                //    select new { customer.CustomerId, customer.ContactName, customer.Address, customer.City, customer.Country };

                //foreach (var customer in customersInParisOrLondon)
                //{
                //    Console.WriteLine($"CustomerID is {customer.CustomerId} and they live at {customer.Address} in {customer.City}");
                //}

                //var productsStoreInBottles =
                //    from product in db.Products
                //    where product.QuantityPerUnit.Contains("bottle")
                //    select product.QuantityPerUnit;
                //foreach (var product in productsStoreInBottles)
                //{
                //    Console.WriteLine(product);
                //}

                //Exercise 1
                var results1a =
                    from c in db.Customers
                    where c.City == "London" || c.City == "Paris"
                    select c;

                var results1b = db.Customers.Where(c => c.City == "London" || c.City == "Paris");

                //Exercise 2
                var results2a =
                    from p in db.Products
                    where p.QuantityPerUnit.Contains("bottle")
                    select p;

                var results2b = db.Products.Where(p => p.QuantityPerUnit.Contains("bottle"));

                //Exercise 3
                var results3a =
                    from p in db.Products
                    join s in db.Suppliers on p.SupplierId equals s.SupplierId
                    where p.QuantityPerUnit.Contains("bottle")
                    select new
                    {
                        ProductName = p.ProductName,
                        QuantityPerUnit = p.QuantityPerUnit,
                        CompanyName = s.CompanyName,
                        Country = s.Country
                    };

                //todo method

                //Exercise 4
                var results4a =
                    from p in db.Products
                    join c in db.Categories on p.CategoryId equals c.CategoryId
                    group p by c.CategoryName into productAndCount
                    select new { Category = productAndCount.Key, NumberOfProducts = productAndCount.Count() };

                //foreach (var item in results4a)
                //{
                //    Console.WriteLine(item);
                //}

                //todo method

                // Exercise 5
                var results5a =
                    from e in db.Employees
                    where e.Country == "UK"
                    select new { Employee = e.Title + " " + e.FirstName + " " + e.LastName, City = e.City };

                foreach (var person in results5a)
                {
                    Console.WriteLine(person);
                }
            }
        }

    }
}