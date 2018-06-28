using System;
using System.IO;
using System.Net;

namespace HTMLToString
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a Valid Webpage URL such as http://wwww.google.com, this tool will download the HTML into a .txt file");
            string webPage = Console.ReadLine();
            Uri uriResult;
            bool result = Uri.TryCreate(webPage, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            WebClient client = new WebClient();
            //DownloadsWebpage
            string reply = client.DownloadString(webPage);

            Console.WriteLine(reply);
            //Location of file here
            Console.WriteLine("Please enter a valid address to save the .txt file such as C:\\Users\\Public\\String.txt, then press any button to exit");
            string txtDir = Console.ReadLine();
            File.WriteAllText(txtDir, reply);
            Console.ReadLine();
       
        }
    }
}
