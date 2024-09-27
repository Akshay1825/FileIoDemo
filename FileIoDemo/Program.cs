using FileIoDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileIoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile readFile = new ReadFile();
            ReadFile.ReadTextFile();                 //Reading Text File
            ReadFile.ReadHtmlFile();                 //Reading Html File
            ReadFile.ReadXmlFile();                  //Reading XML File

            WriteFile writeFile = new WriteFile();
            WriteFile.WriteTextFile();               //Writing Text File
            WriteFile.WriteHtmlFile();               //Writing Html File
            WriteFile.WriteXmlFile();                //Writing XML File

            AcceptUser acceptUser = new AcceptUser();
            AcceptUser.InputUser();                  //Accepting user and adding to the file
        }  
    }
}
