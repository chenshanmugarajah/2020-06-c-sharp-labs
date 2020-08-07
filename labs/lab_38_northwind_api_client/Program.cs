using lab_38_northwind_api_client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_38_northwind_api_client
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static Customer customer = new Customer();
        static Uri url = new Uri("https://localhost:44316/api/customers/");
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Thread.Sleep(2000);
            GetCustomers();
            Thread.Sleep(2000);

            GetCustomer("ALFKI");
            Thread.Sleep(2000);
            var original = customer;
            Console.WriteLine(original.ContactName);

            UpdateCustomer("ALFKI", "Jason Bourne");
            Thread.Sleep(2000);

            GetCustomer("ALFKI");
            Thread.Sleep(2000);
            var updated = customer;
            Console.WriteLine(updated.ContactName);

        }

        // UPDATE customer detail
        static async void UpdateCustomer(string targetId, string contactName)
        {
            GetCustomer(targetId);
            Thread.Sleep(2000);

            Console.WriteLine("===\tUpdating Customer\t===");
            
            customer.ContactName = contactName;

            var customerObj = JsonConvert.SerializeObject(customer);
            var httpContent = new StringContent(customerObj);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using (var httpclient = new HttpClient())
            {
                var response = await httpclient.PutAsync(url + targetId, httpContent);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("===\tSuccessfully Updated\t===");
                }
                else
                {
                    Console.WriteLine(response);
                }
                customer = null;
            }
        }



        // DELETE customer async with response
        static async Task<HttpResponseMessage> DeleteCustomerAsyncWithResponse(string customerid)
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

        // DELETE customer async
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

        // DELETE customer
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
        

        
        // CREATE customer into database
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



        // GET customer
        static async void GetCustomer(string id)
        {
            if (!CustomerExists(id))
            {
                Console.WriteLine("===\tCustomer does not exist\t===");
                return;
            }
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url + id);
                customer = JsonConvert.DeserializeObject<Customer>(response);
            }
        }

        // GET all customers
        static async void GetCustomers()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                customers = JsonConvert.DeserializeObject<List<Customer>>(response);
            }
        }



        // ========================== HELPER FUNCTIONS ==============================

        // Check if customer exists in database
        static bool CustomerExists(string customerId)
        {
            var customerExists = customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customerExists != null) return true;
            else return false;
        }

        // Generate customer key based on contactname
        static string GenerateCustomerKey(string contactname)
        {
            string uppercaseName = Regex.Replace(contactname, @"\s+", "").ToUpper();
            string key = new string(Enumerable.Repeat(uppercaseName, 5)
            .Select(s => s[random.Next(s.Length)]).ToArray());

            customers.ForEach(c =>
            {
                if (c.CustomerId == key)
                {
                    GenerateCustomerKey(contactname);
                } 
            });
            return key;
        }
    }
}
