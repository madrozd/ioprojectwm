using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Przygody
    {
        public static void Poczatek(Bohater b)
        {
            Bohater.nazwijPostac(b);
            Console.WriteLine("Pominąć prolog?\n1.Nie\n2.Tak");
            string wybierzProlog = "";
            while(!(wybierzProlog == "1")&& !(wybierzProlog=="2"))
            {
                wybierzProlog = Console.ReadLine();
                switch (wybierzProlog)
                {
                    case "1":
                        Console.WriteLine("TUTAJ MA BYĆ WSTĘP");
                        break;
                    case "2":
                        Console.WriteLine("Wstęp został pominięty");
                        break;
                    default:
                        Console.WriteLine("Niepoprawny znak");
                        continue;
                }
            }
            Gildia.wyborGildii();
        }
    }
}
