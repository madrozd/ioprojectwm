using System;
using System.Collections.Generic;
namespace ConsoleApp1
{


    class Program
    {



        static void Main(string[] args)
        {
             Bohater bohater = new Bohater("Bezimienny");
             Bohater.ruda = 20;
             Bohater.skora = 20;
             Bohater.klejnot = 20;
            Console.WriteLine("Ruda: {0}", Bohater.ruda);
            Console.WriteLine("Skóra: {0}", Bohater.skora);
            Console.WriteLine("Klejnoty: {0}", Bohater.klejnot);
            Console.WriteLine("Złoto: {0}", Bohater.zloto);
            Akcja.Sprzedaj();
             Console.WriteLine("Ruda: {0}",Bohater.ruda);
             Console.WriteLine("Skóra: {0}",Bohater.skora);
             Console.WriteLine("Klejnoty: {0}",Bohater.klejnot);
             Console.WriteLine("Złoto: {0}",Bohater.zloto);
             Console.ReadKey();
             Akcja.Sprzedaj();
             Console.WriteLine("Ruda: {0}", Bohater.ruda);
             Console.WriteLine("Skóra: {0}", Bohater.skora);
             Console.WriteLine("Klejnoty: {0}", Bohater.klejnot);
             Console.WriteLine("Złoto: {0}", Bohater.zloto);
             Console.ReadKey(); 
        }
    }
}
