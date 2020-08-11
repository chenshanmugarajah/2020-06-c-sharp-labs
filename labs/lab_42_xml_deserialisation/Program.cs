using lab_42_xml_deserialisation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab_42_xml_deserialisation
{
    class Program : DbContext
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            var xmlFromInternet = new List<Product>();
            var deProducts = new Products();

            using (var db = new NorthwindContext())
            {
                products = db.Products.Take(5).ToList();
            }

            // products.ForEach(product => Console.WriteLine(product.ProductName));

            var xmlProducts = new XElement(
                "Products",
                    from p in products 
                    select new XElement ("Product", 
                        new XElement("ProductId", p.ProductId),
                        new XElement("ProductName", p.ProductName),
                        new XElement("UnitPrice", p.UnitPrice)
                    )
            );

            // save document
            var xmlProductsDoc = new XDocument(xmlProducts);
            xmlProductsDoc.Save("XMLProducts.xml");

            var XMLProducts = new Products();
            using (var reader = new StreamReader("XMLProducts.xml"))
            {
                // deserialize from xml to Northwind Products
                var serializer = new XmlSerializer(typeof(Products));
                XMLProducts = (Products)serializer.Deserialize(reader);
            }
            Console.WriteLine("\n\nProducts Deserialized");
            XMLProducts.ProductList.ForEach(p => Console.WriteLine($"{p.ProductId,-15}{p.ProductName,-40}{p.UnitPrice}"));
        }

        
    }
}
