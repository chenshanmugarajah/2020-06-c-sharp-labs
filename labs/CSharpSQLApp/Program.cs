using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CSharpSQLApp
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var customers = new List<Customer>();
        //    using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"))
        //    {
        //        connection.Open();
        //        Console.WriteLine(connection.State);

        //        using (var command = new SqlCommand("select * from customers", connection))
        //        {
        //            SqlDataReader sqlReader = command.ExecuteReader();
        //            // loop while the reader has more data to read
        //            while (sqlReader.Read())
        //            {
        //                var customerID = sqlReader["CustomerID"].ToString();
        //                var contactName = sqlReader["ContactName"].ToString();
        //                var city = sqlReader["City"].ToString();

        //                var customer = new Customer { CustomerId = customerID, ContactName = contactName, City = city };

        //                customers.Add(customer);
        //            }
        //            sqlReader.Close();
        //        }
        //        // iterate over and output all customers
        //        foreach (var c in customers)
        //        {
        //            Console.WriteLine($"Customer {c.GetFullName()} has ID {c.CustomerId} and lives in {c.City}");
        //        }

        //        var newCustomer = new Customer()
        //        {
        //            CustomerId = "BLOG",
        //            ContactName = "Joe Bloggs",
        //            City = "Birmingham",
        //            CompanyName = "ToysRUs"
        //        };
        //        #region delete any existing customer with Id BLOG
        //        // first delete any Customer with Id Blog from database
        //        string sqlDS = $"DELETE FROM CUSTOMERS WHERE CustomerId = '{newCustomer.CustomerId}'";

        //        using (var command = new SqlCommand(sqlDS, connection))
        //        {
        //            // if success this should equal 1
        //            int affected = command.ExecuteNonQuery();
        //        }
        //        #endregion

        //        string sqlString = $"INSERT INTO CUSTOMERS(CustomerID, ContactName, CompanyName, City) VALUES('{newCustomer.CustomerId}', '{newCustomer.ContactName}', '{newCustomer.CompanyName}', '{newCustomer.City}')";
        //        // execute insert SQL command
        //        using (var command = new SqlCommand(sqlString, connection))
        //        {
        //            int affected = command.ExecuteNonQuery();
        //        }
        //        // affected will have the value 1 if the operation succeeds

        //        string sqlUpdateString = $"UPDATE CUSTOMERS SET City = 'Berlin' WHERE CustomerID='{newCustomer.CustomerId}'";

        //        using (var command = new SqlCommand(sqlUpdateString, connection))
        //        {
        //            int affected = command.ExecuteNonQuery();
        //        }

        //        using (var updateCustomerCommand = new SqlCommand("UpdateCustomer", connection))
        //        {
        //            // Using System.Data;
        //            updateCustomerCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //            // add parameters
        //            updateCustomerCommand.Parameters.AddWithValue("ID", newCustomer.CustomerId);
        //            updateCustomerCommand.Parameters.AddWithValue("NewName", "Joe Bloggs Updated Name");
        //            // run the update
        //            int affected = updateCustomerCommand.ExecuteNonQuery();
        //        }

        //        string sqlDeleteString = $"DELETE FROM CUSTOMERS WHERE CustomerId = '{newCustomer.CustomerId}'";

        //        using (var command = new SqlCommand(sqlDeleteString, connection))
        //        {
        //            // if success this should equal 1
        //            int affected = command.ExecuteNonQuery();
        //        }
        //    }

        //}

        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                foreach (var customer in db.Customers)
                {
                    Console.WriteLine($"{customer.GetFullName()} has ID {customer.CustomerId} and lives in {customer.City}");
                }

                var newCustomer = new Customer()
                {
                    CustomerId = "BLOG",
                    ContactName = "Joe Bloggs",
                    CompanyName = "ToysRUs"
                };

                db.Customers.Add(newCustomer);
                db.SaveChanges();

                // obtain your selected customer
                var selectedCustomer = db.Customers.Where(c => c.CustomerId == "BLOG").FirstOrDefault();
                // now update
                selectedCustomer.City = "Paris";
                // save back to database
                db.SaveChanges();

                // select customer
                selectedCustomer = db.Customers.Where(c => c.CustomerId == "BLOG").FirstOrDefault();
                // remove customer from local DbContext copy of database
                db.Customers.Remove(selectedCustomer);
                // update database
                db.SaveChanges();
            }

        }
    }
}
