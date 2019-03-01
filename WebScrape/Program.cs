using HtmlAgilityPack;
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
            GetHtmlAsync();



            Console.ReadLine();
        }     


        private static async void GetHtmlAsync()
        {
            var url = "https://github.com/JMicahMan/Weapon-Customizer/wiki";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var HDoc = new HtmlDocument();

            HDoc.LoadHtml(html);

            var WeaponList = HDoc.DocumentNode.Descendants("markdown-body").Where(node => node.GetAttributeValue("p", "").Equals("ListViewInner")).ToList();

            Console.WriteLine();
        }

    }
}
