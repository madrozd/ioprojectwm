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
            Bohater bohater = new Bohater();
            Przygody.Poczatek(bohater);
            Console.WriteLine(bohater.nazwa);
            while (true)
            {
                Akcja.Menu(bohater);
            } 

           

        }
    }
}
