using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileIoDemo.Models
{
    internal class ReadFile
    {
        public static void ReadTextFile()
        {
            string path = "TextFile.txt";
            Console.WriteLine(File.Exists(path) ? "Text File Content:\n" + File.ReadAllText(path) : "Text file does not exist");
            Console.WriteLine();
        }

        public static void ReadHtmlFile()
        {
            string path = "HtmlFile.html";
            Console.WriteLine(File.Exists(path) ? "HTML File Content:\n" + File.ReadAllText(path) : "HTML file does not exist");
            Console.WriteLine();
        }
        public static void ReadXmlFile()
        {
            string path = "XmlFile.xml";
            Console.WriteLine(File.Exists(path) ? "XML File Content:\n" + XDocument.Load(path).ToString() : "XML file does not exist");
            Console.WriteLine();
        }
    }
}
