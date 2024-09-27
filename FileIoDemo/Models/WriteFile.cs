using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileIoDemo.Models
{
    internal class WriteFile
    {
        public static void WriteTextFile()
        {
            string path = "TextFile.txt";
            File.WriteAllText(path, "This is a Updated text file");
            Console.WriteLine("Text file updated Succesfully\n");
        }

        public static void WriteHtmlFile()
        {
            string path = "HtmlFile.html";
            string htmlContent = "<html>\n<body>\nThis is a Updated HTML file\n</body>\n</html>\n";
            File.WriteAllText(path, htmlContent);
            Console.WriteLine("HTML file updated Succesfully\n");
        }

        public static void WriteXmlFile()
        {
            var doc = new XDocument(
                new XElement("root", new XElement("message", "This is a Updated XML file"))
            );

            doc.Save("XmlFile.xml");
            Console.WriteLine("XML file written successfully\n");
        }
    }
}
