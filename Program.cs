using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив адрес сайтів
        string[] websites = {
            "https://example.com",
            "https://site.ua",
            "https://example.org",
            "https://mysite.ua",
            "https://another-site.net",
            "https://coolwebsite.ua"
        };

        // Запит LINQ для відбору сайтів з доменом .ua
        var uaWebsites = websites.Where(site => site.Contains(".ua"));

        // Виведення результатів на консоль
        Console.WriteLine("Сайти з доменом .ua:");
        foreach (var site in uaWebsites)
        {
            Console.WriteLine(site);
        }
    }
}
