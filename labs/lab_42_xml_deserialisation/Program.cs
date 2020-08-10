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
    [Serializable, XmlRoot("Products")]
    public class Products
    {
        [XmlElement("ProductId")]
        public int ProductId { get; set; }

        [XmlElement("ProductName")]
        public string ProductName { get; set; }

        [XmlElement("ProductUnitPrice")]
        public decimal ProductUnitPrice { get; set; }

        [XmlElement("Product")]
        public List<Products> ProductProducts { get; set; }
    }

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
                        new XElement("ProductUnitPrice", p.UnitPrice)
                    )
            );

            // save document
            var xmlProductsDoc = new XDocument(xmlProducts);
            xmlProductsDoc.Save("XMLProducts.xml");

            // to send large data over internet, stream data from internet
            using (var reader = new StreamReader("XMLProducts.xml"))
            {
                // deserialize from XML to Products instance
                var serialiser = new XmlSerializer(typeof(Products));
                deProducts = (Products)serialiser.Deserialize(reader);
            }

        }

        
    }
}
