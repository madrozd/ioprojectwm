﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
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
            Console.WriteLine("Przemierzając osadę natrafiasz na rynek. Na rynku dostrzegasz tablicę z trzema symbolami: kupieckim wozem, wojowniczymi mieczem z tarczą oraz religijnym kołowrotem. Oznaczają one, że gildie przyjmują nowych chętnych. Postanawiasz dołączyć do jednej z nich.\n");
            while (!(gildia == "1") && !(gildia == "2") && !(gildia == "3"))
            {
                Console.WriteLine("Decydujesz się na:\n1.Kupcy\n2.Wojownicy\n3.Mnisi ");
                gildia = Console.ReadLine();
                switch (gildia)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Wybrałeś gildię kupców");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Zdecydowałeś się dołączyć do gildii wojowników");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Obrałeś drogę mnicha");
                        break;
                    default:
                        Console.WriteLine("Niepoprawny znak");
                        break;
                }
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
                    b.bohaterStatus = "Targowy handlarz";
                }
                if ((zarobioneZloto >= 500) && (postep2 == 0))
                {
                    b.inteligencja = b.inteligencja + 2;
                    b.zrecznosc = b.zrecznosc + 1;
                    postep2 = 1;
                    b.bohaterStatus = "Kupiec";
                }
                if ((zarobioneZloto >= 1000) && (postep3 == 0))
                {
                    b.ruda = b.ruda + 20;
                    b.skora = b.skora + 20;
                    b.klejnot = b.klejnot + 10;
                    postep3 = 1;
                    b.bohaterStatus = "Mistrz kupiecki";
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
                    b.bohaterStatus = "Giermek";
                }
                if ((pokonaniPrzeciwnicy >= 2) && (postep2 == 0))
                {
                    b.sila = b.sila + 2;
                    b.zrecznosc = b.zrecznosc + 2;
                    postep2 = 1;
                    b.bohaterStatus = "Wojownik";
                }
                if ((pokonaniPrzeciwnicy >= 3) && (postep3 == 0))
                {
                    b.ruda = b.ruda + 20;
                    b.skora = b.skora + 20;
                    b.klejnot = b.klejnot + 10;
                    postep3 = 1;
                    b.bohaterStatus = "Rycerz";
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
                    b.bohaterStatus = "Nowicjusz";
                }
                if ((uznanieBostwo >= 50) && (postep2 == 0))
                {
                    Console.WriteLine("Osiagnięto 2 rangę w zakonie");
                    b.wytrzymalosc = b.wytrzymalosc + 2;
                    b.inteligencja = b.inteligencja + 2;
                    postep2 = 1;
                    b.bohaterStatus = "Mnich";
                }
                if ((uznanieBostwo >= 100) && (postep3 == 0))
                {
                    Console.WriteLine("Osiagnięto 3 rangę w zakonie");
                    b.wytrzymalosc = b.wytrzymalosc + 3;
                    b.inteligencja = b.inteligencja + 3;
                    postep3 = 1;
                    b.bohaterStatus = "Przeor";
                }
            }
            else
            {
                Console.WriteLine("Przykro nam nie możemy nic ci zaoferować");
            }
        }
    }
}
