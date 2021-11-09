using System;
using System.Threading;

namespace ThreadsScrape
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ScrapingThreads scraping = new ScrapingThreads();//instancia clase de  con hilo
            Thread itla = new Thread(new ThreadStart(scraping.hiloItla));//hilo 1 de ITLA
            Thread h2 = new Thread(new ThreadStart(scraping.hiloDos));//hilo 2 de 
            itla.Start();
            h2.Start();
        }
    }
}
