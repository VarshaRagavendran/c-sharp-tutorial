using System;
using ScrapeLibrary;
namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Scrape scrape = new Scrape();
            string value = scrape.ScrapeWebpage("http://msdn.microsoft.com");
            Console.WriteLine(value);
        }
    }
}
