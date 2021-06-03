using System;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            Bohater bohater = new Bohater("Bezimienny");
            bohater.PD = 21;
            bohater.Awans();
            Console.WriteLine("Punkty doświadczenia twojego bohatera: " + bohater.PD);
            bohater.Awans();
            Console.WriteLine("Punkty doświadczenia twojego bohatera: " + bohater.PD);
            bohater.Awans();
            Console.ReadKey();
        }

    }
}
