using lab_38_northwind_api_client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace lab_38_northwind_api_client
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static Customer customer = new Customer();
        static Uri url = new Uri("https://localhost:44316/api/customers/");

        static void Main(string[] args)
        {
            Thread.Sleep(5000);
            GetCustomers();

            //Console.WriteLine("===\tGetting Customer\t===");
            //GetCustomer("ALFKI");
            //Thread.Sleep(2000);
            //Console.WriteLine($"Customer contact name {customer.ContactName}");

            //var newCustomer = new Customer()
            //{
            //    CustomerId = "CHENU",
            //    ContactName = "Chen Shanmugarajah",
            //    CompanyName = "Sparta Global",
            //    City = "London",
            //    Country = "UK"
            //};
            //AddCustomer(newCustomer);
            //Thread.Sleep(3000);



            Console.WriteLine("===\tGetting All Customers\t===");
            GetCustomers();
            Thread.Sleep(3000);
            customers.ForEach(customer => Console.WriteLine($"Customer contact name {customer.ContactName}"));

            //DeleteCustomerAsync2("CHENU");
        }

        static async Task<HttpResponseMessage> DeleteCustomerAsync2(string customerid)
        {
            if (CustomerExists(customerid))
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.DeleteAsync(url + customerid);
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("===\tSuccessful Async Delete\t===");
                    }
                    return response;
                }
            }
            else
            {
                Console.WriteLine("==\tDoes not exist to be deleted\t===");
                return null;
            }
        }

        static async void DeleteCustomerAsync(string customerid)
        {
            if (CustomerExists(customerid))
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.DeleteAsync(url + customerid);
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("===\tSuccessful Async Delete\t===");
                    }
                }
            }else
            {
                Console.Write("==\tId does not exist\t===");
            }
        }

        static void DeleteCustomer (string customerId)
        {
            if (CustomerExists(customerId))
            {
                using (var httpClient = new HttpClient())
                {
                    var response = httpClient.DeleteAsync(url + customerId);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        Console.Write("==\tSuccess\t===");
                    }
                }
            }
            else
            {
                Console.Write("==\tId does not exist\t===");
            }
        }

        static bool CustomerExists(string customerId)
        {
            var customerExists = customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customerExists != null) return true;
            else return false;
        }

        static async void AddCustomer(Customer newCustomer)
        {
            if (!CustomerExists(newCustomer.CustomerId))
            {
                Console.WriteLine("===\tCustomer Exists\t===");
                return;
            } 
            else
            {
                using (var httpclient = new HttpClient())
                {
                    Console.WriteLine("===\tAdding new customer\t===");
                    var customerObj = JsonConvert.SerializeObject(newCustomer);
                    var httpContent = new StringContent(customerObj);

                    httpContent.Headers.ContentType.MediaType = "application/json";
                    httpContent.Headers.ContentType.CharSet = "UTF-8";

                    var response = await httpclient.PostAsync(url, httpContent);
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("===\tSuccessfully Added\t===");
                    }
                }
            }
        }

        static async void GetCustomer(string id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url + id);
                customer = JsonConvert.DeserializeObject<Customer>(response);
            }
        }

        static async void GetCustomers()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                customers = JsonConvert.DeserializeObject<List<Customer>>(response);
            }
        }
    }
}
