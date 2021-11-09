using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace ThreadsScrape
{
    class ScrapingThreads
    {
        public void hiloItla()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            HtmlWeb htmlWeb = new HtmlWeb();
            string url = "https://itla.edu.do/";
            string pathFile = @"C:\Users\Elian\source\repos\ThreadsScrape\ThreadsScrape\img\itla\";
            HtmlDocument htmlDoc = htmlWeb.Load(url);

            int i = 1;

            Console.WriteLine($"SCRAPING CON HILO DEL ITLA:");

            foreach (var nodo in htmlDoc.DocumentNode.CssSelect("img"))
            {
                Console.WriteLine($"IMAGEN DEL ITLA #{i} OBTENIDA: {nodo.GetAttributeValue("src")}");
                using (WebClient webClient = new WebClient())
                {
                    string urlImg = nodo.GetAttributeValue("src");
                    webClient.DownloadFile(new Uri(urlImg), pathFile + i + ".jpg");
                }
                i++;
                Thread.Sleep(100);
            }
            Console.WriteLine($"SCRAPING CON HILO DEL ITLA TERMINADO");
            Console.ResetColor();
        }
        public void hiloDos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            HtmlWeb htmlWeb = new HtmlWeb();
            string url = "https://hdeleon.net/";
            string pathFile = @"C:\Users\Elian\source\repos\ThreadsScrape\ThreadsScrape\img\hilo2\";
            HtmlDocument htmlDoc = htmlWeb.Load(url);

            int iDos = 1;

            Console.WriteLine($"SCRAPING CON HILO DOS:");

            foreach (var nodo in htmlDoc.DocumentNode.CssSelect("img"))
            {
                Console.WriteLine($"IMAGEN DEL HILO DOS #{iDos} OBTENIDA: {nodo.GetAttributeValue("src")}");
                using (WebClient webClient = new WebClient())
                {
                    string urlImgOrbi = nodo.GetAttributeValue("src");
                    webClient.DownloadFile(new Uri(urlImgOrbi), pathFile + iDos + ".jpg");
                }
                iDos++;
                Thread.Sleep(100);
            }
            Console.WriteLine($"SCRAPING CON HILO DOS TERMINADO");
            Console.ResetColor();
        }
    }
}
