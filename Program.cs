using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{


    class Program
    {



        static void Main(string[] args)
        {
            Przygody.losujPrzygody();
            Przedmiot miecz = new Przedmiot("Miecz", 0, 0, 0, 0, 0);
            Przedmiot zbroja = new Przedmiot("Zbroja", 0, 0, 0, 0, 0);
            Przedmiot helm = new Przedmiot("Helm", 0, 0, 0, 0, 0);
            Przedmiot pas = new Przedmiot("Pas", 0, 0, 0, 0, 0);
            Bohater bohater = new Bohater();
            bohater.sila = 10;
            bohater.zrecznosc = 10;
            bohater.wytrzymalosc = 10;
            bohater.inteligencja = 10;
            bohater.charyzma = 10;
            bohater.PZ = 100;
            Przygody.Poczatek(bohater);
            Console.WriteLine(bohater.nazwa);
            while (true)
            {
                Akcja.Menu(bohater, miecz, zbroja, helm, pas);    
            } 
            
           

        }
    }
}
