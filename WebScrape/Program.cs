using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebScrape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Console.BufferWidth, 2000);
            var url = "https://github.com/JMicahMan/Weapon-Customizer/wiki";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url);
            Console.WriteLine(html.Result);
            Console.ReadLine();
        }     
    }
}
