using System;
using System.Threading;

namespace ThreadsScrape
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NORMAL*/
            //Scraping scraping = new Scraping();
            //scraping.hiloItla();
            //scraping.hiloDos();
            /*CON HILO*/
            ScrapingThreads scrapingThreads = new ScrapingThreads();//instancia clase de  con hilo
            Thread itla = new Thread(new ThreadStart(scrapingThreads.hiloItla));//hilo 1 de ITLA
            Thread h2 = new Thread(new ThreadStart(scrapingThreads.hiloDos));//hilo 2 de 
            itla.Start();
            h2.Start();
        }
    }
}
