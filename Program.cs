using System;
using System.Collections.Generic;
namespace ConsoleApp1
{


    class Program
    {



        static void Main(string[] args)
        {
            Bohater bohater = new Bohater();
            Przygody.Poczatek(bohater);
            Console.WriteLine(bohater.nazwa);
            Akcja.Menu(bohater);

        }
    }
}
