using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Przygody
    {
        private static int licznikPrzygod = 0;
        public static List<int> wybierzPrzygode = new List<int>();
        public static int los = 0;
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
        public static void Zdarzenia()
        {
           if(licznikPrzygod < 5)
            {
                if (wybierzPrzygode[los] == 0)
                {
                    Console.WriteLine("0");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 1)
                {
                    Console.WriteLine("1");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 2)
                {
                    Console.WriteLine("2");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 3)
                {
                    Console.WriteLine("3");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 4)
                {
                    Console.WriteLine("4");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 5)
                {
                    Console.WriteLine("5");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 6)
                {
                    Console.WriteLine("6");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 7)
                {
                    Console.WriteLine("7");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 8)
                {
                    Console.WriteLine("8");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 9)
                {
                    Console.WriteLine("9");
                    licznikPrzygod++;
                }
            }
            if (licznikPrzygod >=5 && licznikPrzygod < 10)
            {
                if (wybierzPrzygode[los] == 10)
                {
                    Console.WriteLine("10");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 11)
                {
                    Console.WriteLine("11");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 12)
                {
                    Console.WriteLine("12");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 13)
                {
                    Console.WriteLine("13");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 14)
                {
                    Console.WriteLine("14");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 15)
                {
                    Console.WriteLine("15");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 16)
                {
                    Console.WriteLine("16");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 17)
                {
                    Console.WriteLine("17");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 18)
                {
                    Console.WriteLine("18");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 19)
                {
                    Console.WriteLine("19");
                    licznikPrzygod++;
                }
            }
            if (licznikPrzygod >= 10 && licznikPrzygod<15)
            {
                if (wybierzPrzygode[los] == 20)
                {
                    Console.WriteLine("20");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 21)
                {
                    Console.WriteLine("2");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 22)
                {
                    Console.WriteLine("22");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 23)
                {
                    Console.WriteLine("23");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 24)
                {
                    Console.WriteLine("24");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 25)
                {
                    Console.WriteLine("25");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 26)
                {
                    Console.WriteLine("26");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 27)
                {
                    Console.WriteLine("27");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 28)
                {
                    Console.WriteLine("28");
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 29)
                {
                    Console.WriteLine("29");
                    licznikPrzygod++;
                }
            }
            if(licznikPrzygod == 15)
            {
                Console.WriteLine("WALKA Z BOSSEM!!!111!!11!!3@!@!!!");
                licznikPrzygod++;
            }
            if(licznikPrzygod == 16)
            {
                Console.WriteLine("EPILOG");
                //Wstawić staty etc
                Environment.Exit(0);
            }
        }
        public static void losujPrzygody()
        {
            Random rand = new Random();
            int number;
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    number = rand.Next(0, 10);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number);
            }
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    number = rand.Next(10, 20);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number);
            }
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    number = rand.Next(20, 30);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number); 
            }
        }
    }
}
