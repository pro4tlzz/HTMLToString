using System;
using System.IO;
using System.Net;

namespace HTMLToString
{
    class Program
    {
        static void Main(string[] args)
        {

         

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
          
            File.WriteAllText(@"D:\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
