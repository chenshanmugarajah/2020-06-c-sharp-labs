using System;
using System.Xml;
using System.Xml.Linq;

namespace lab_41_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            // main element
            var xml01 = new XElement("test", 1);
            //Console.WriteLine(xml01);

            // sub element
            var xml02 = new XElement("root",
                new XElement("level1",
                    new XAttribute("width", 22),
                    new XElement("level2", 200),
                    new XElement("level2", 200)
                ),
                new XElement("level1",
                    new XAttribute("width", 22),
                    new XElement("level2", 200),
                    new XElement("level2", 200)
                ),
                new XElement("level1",
                    new XAttribute("width", 22),
                    new XElement("level2", 200),
                    new XElement("level2", 200)
                )
            );
            //Console.WriteLine(xml02);

            // write to disk
            var doc02 = new XDocument(xml02);
            doc02.Save("XMLdoc02.xml");

            // read doc
            var readdoc02 = new XmlDocument();
            readdoc02.Load("XMLdoc02.xml");

            Console.WriteLine(readdoc02.InnerXml);
        }
    }
}
