using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Gildia
    {
        public static string gildia;
        public static int zarobioneZloto;
        public static int pokonaniPrzeciwnicy;
        public static int uznanieBostwo;
        private static int postep1 = 0;
        private static int postep2 = 0;
        private static int postep3 = 0;

        public static void wyborGildii()
        {
            Console.WriteLine("Przemierzając miasto natrafiasz na rynek ...\nDecydujesz się na:\n1.Kupcy\n2.Wojownicy\n3.Mnisi ");
            gildia = Console.ReadLine();
            switch (gildia)
            {
                case"1":
                    Console.WriteLine("Wybrałeś gildię kupców");
                    break;
                case"2":
                    Console.WriteLine("Zdecydowałeś się dołączyć do gildii wojowników");
                    break;
                case "3":
                    Console.WriteLine("Obrałeś drogę mnicha");
                    break;
                default:
                    Console.WriteLine("Niepoprawny znak");
                    break;
            }

        }
        public static void gildiaKupcow(Bohater b)
        {
            if(gildia == "1")
            {
                Console.WriteLine("Witaj w naszych szeregach");
                if ((zarobioneZloto >= 300) && (postep1 == 0))
                {
                    Console.WriteLine("Jako nagrodę za twoje kupieckie osiągnięcia damy ci ...");
                    b.zloto = b.zloto + 100;
                    postep1 = 1;
                    b.bohaterStatus = "1";
                }
                if ((zarobioneZloto >= 500) && (postep2 == 0))
                {
                    b.inteligencja = b.inteligencja + 2;
                    b.zrecznosc = b.zrecznosc + 1;
                    postep2 = 1;
                    b.bohaterStatus = "2";
                }
                if ((zarobioneZloto >= 1000) && (postep3 == 0))
                {
                    b.ruda = b.ruda + 20;
                    b.skora = b.skora + 20;
                    b.klejnot = b.klejnot + 10;
                    postep3 = 1;
                    b.bohaterStatus = "3";
                }
            }
            else
            {
                Console.WriteLine("Przykro nam nie możemy nic ci zaoferować");
            }
        }
        public static void gildiaWojownikow(Bohater b)
        {
            if (gildia == "2")
            {
                Console.WriteLine("Witaj w naszych szeregach");
                if ((pokonaniPrzeciwnicy >= 1) && (postep1 == 0))
                {
                    Console.WriteLine("Jako nagrodę za twoją waleczność ...");
                    b.zloto = b.zloto + 100;
                    postep1 = 1;
                    b.bohaterStatus = "1";
                }
                if ((pokonaniPrzeciwnicy >= 5) && (postep2 == 0))
                {
                    b.sila = b.sila + 2;
                    b.zrecznosc = b.zrecznosc + 2;
                    postep2 = 1;
                    b.bohaterStatus = "2";
                }
                if ((pokonaniPrzeciwnicy >= 10) && (postep3 == 0))
                {
                    b.ruda = b.ruda + 20;
                    b.skora = b.skora + 20;
                    b.klejnot = b.klejnot + 10;
                    postep3 = 1;
                    b.bohaterStatus = "3";
                }
            }
            else
            {
                Console.WriteLine("Przykro nam nie możemy nic ci zaoferować");
            }
        }
        public static void gildiaMnichow(Bohater b)
        {
            if (gildia == "3")
            {
                Console.WriteLine("Witaj w naszych szeregach");
                if ((uznanieBostwo >= 10) && (postep1 == 0))
                {
                    Console.WriteLine("Osiagnięto 1 rangę w zakonie");
                    Console.WriteLine("Jako nagrodę za twoje modlitwy ...");
                    b.wytrzymalosc = b.wytrzymalosc + 1;
                    b.inteligencja = b.inteligencja + 1;
                    postep1 = 1;
                    b.bohaterStatus = "1";
                }
                if ((uznanieBostwo >= 50) && (postep2 == 0))
                {
                    Console.WriteLine("Osiagnięto 2 rangę w zakonie");
                    b.wytrzymalosc = b.wytrzymalosc + 2;
                    b.inteligencja = b.inteligencja + 2;
                    postep2 = 1;
                    b.bohaterStatus = "2";
                }
                if ((uznanieBostwo >= 100) && (postep3 == 0))
                {
                    Console.WriteLine("Osiagnięto 3 rangę w zakonie");
                    b.wytrzymalosc = b.wytrzymalosc + 3;
                    b.inteligencja = b.inteligencja + 3;
                    postep3 = 1;
                    b.bohaterStatus = "3";
                }
            }
            else
            {
                Console.WriteLine("Przykro nam nie możemy nic ci zaoferować");
            }
        }
    }
}
