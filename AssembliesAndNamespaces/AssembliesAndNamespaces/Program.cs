using System;
using System.Net;

// namespace is primarily a way to disambiguate class names in a library
namespace AssembliesAndNamespaces
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Writing html page to console
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            Console.WriteLine(reply);

        }
    }
}
