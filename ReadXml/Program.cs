using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "ResponseResultLocalization.xml");
            XElement root = XElement.Load(filePath);
            var node = root.Elements("Error").FirstOrDefault(el => el.Attribute("code").Value.Equals("110"));
            if (node != null)
            {
                var englishMessage = node.Element("MessageEn").Value;
                Console.WriteLine(englishMessage);
            }

            Console.Read();
        }
    }
}
