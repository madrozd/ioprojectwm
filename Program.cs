using System;
using System.Collections.Generic;
namespace ConsoleApp1
{


    class Program
    {



        static void Main(string[] args)
        {
            Bohater bohater = new Bohater("Bezimienny");
            bohater.wytrzymalosc = 2;
            Przeciwnik topielec = new Przeciwnik("Topielec", 1, 1, 1, 10, 2);
            Walka.Pojedynek(ref bohater, topielec);
            Console.WriteLine("Życie bohatera: {0}", bohater.PZ);
            Console.WriteLine("Życie przeciwnika: {0}", topielec.PZ);  
            
        }
    }
}
