using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileIoDemo.Models
{
    internal class AcceptUser
    {
        public static void InputUser()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            File.AppendAllText("usernames.txt", username + "\n");

            Console.WriteLine("Username added to the file");
        }
    }
}
