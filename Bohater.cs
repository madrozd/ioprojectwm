using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Bohater : Arkusz
    {
        public int PD;
        public int bierwiono;
        public int zloto;
        public int punktacja;
        public int ruda;
        public int skora;
        public int klejnot;
        public string bohaterStatus;
        private static int postepMiecz = 0;
        private static int postepZbroja = 0;
        private static int postepHelm = 0;
        private static int postepPas = 0;

        public Bohater()
        {
            nazwa = "Bezimienny";
            sila = 1;
            zrecznosc = 1;
            PZ = 10;
            wytrzymalosc = 1;
            inteligencja = 1;
            charyzma = 1;
            PD = 0;
            bierwiono = 1;
            zloto = 0;
            punktacja = 0;
            ruda = 0;
            skora = 0;
            klejnot = 0;
            bohaterStatus = "Nieznany";
        }

        public void wyswietlStatystyki(Bohater b)
        {
            Console.WriteLine("Statystyki {0}\nSiła: {1}\nZręczność: {2}\nWytrzymałość: {3}\nInteligencja: {4}\nCharyzma: {5}\nPunkty Życia: {6}",b.nazwa, b.sila, b.zrecznosc, b.wytrzymalosc, b.inteligencja, b.charyzma, b.PZ);
        }
        public void Awans(Bohater b)
        {
            int silaPrzed = b.sila;
            int zrecznoscPrzed = b.zrecznosc;
            int wytrzymaloscPrzed = b.wytrzymalosc;
            int inteligencjaPrzed = b.inteligencja;
            int charyzmaPrzed = b.charyzma;
            if (b.PD >= 10)
            {
                int punktyStatystyk = 5;
                Console.WriteLine("Gratulacje pora na awans!");
                Console.WriteLine("1.Siła\n2.Zręcznosć\n3.Wytrzymałość\n4.Inteligencja\n5.Charyzma");
                for (int i = 0; i < punktyStatystyk;)
                {
                    string wyborStat = Console.ReadLine();
                    switch (wyborStat)
                    {
                        case "1":
                            b.sila++;
                            i++;
                            continue;
                        case "2":
                            b.zrecznosc++;
                            i++;
                            continue;
                        case "3":
                            b.wytrzymalosc++;
                            i++;
                            continue;
                        case "4":
                            b.inteligencja++;
                            i++;
                            continue;
                        case "5":
                            b.charyzma++;
                            i++;
                            continue;
                        default:
                            Console.WriteLine("Wybierz poprawnie");
                            continue;
                    }
                }
                Console.WriteLine("Siła: {0}\nZręczność: {1}\nWytrzymałość: {2}\nInteligencja: {3}\nCharyzma: {4}", b.sila, b.zrecznosc, b.wytrzymalosc, b.inteligencja, b.charyzma);
                Console.WriteLine("1. Zaakceptuj wybór statystyk");
                Console.WriteLine("2. Zrezygnuj");
                string Potwierdzenie = " ";
                while (!(Potwierdzenie == "1") && !(Potwierdzenie == "2"))
                {
                    Potwierdzenie = Console.ReadLine();

                    switch (Potwierdzenie)
                    {
                        case "1":
                            Console.WriteLine("Twój wybór został potwierdzony");
                            b.PD = b.PD - 10;
                            b.PZ = b.wytrzymalosc * 10;
                            break;
                        case "2":
                            Console.WriteLine("Odrzuciłeś swój wybór. Twoje punkty doświadczenia nie zostaną zabrane");
                            b.sila = silaPrzed;
                            b.zrecznosc = zrecznoscPrzed;
                            b.wytrzymalosc = wytrzymaloscPrzed;
                            b.inteligencja = inteligencjaPrzed;
                            b.charyzma = charyzmaPrzed;
                            break;

                        default:
                            Console.WriteLine("Wybierz poprawnie");
                            break;
                    }

                }

            }
            else
            {
                Console.WriteLine("Nie jestes gotowy");
            }
        }

        public static void zarzadzajEkwipunkiem(Bohater b)
        {
            string wyborEkwipunek = " ";
            while (wyborEkwipunek != "3")
            {
                Console.WriteLine("1.Stan ekwipunku\n2.Wytwarzanie przedmiotów\n3.Zakończ");
                wyborEkwipunek = Console.ReadLine();
                switch (wyborEkwipunek)
                {
                    case "1":
                        Console.WriteLine("Stan twojego ekwipunku:\nRuda: {0}\nSkóry: {1}\nKlejnoty: {2}\nZłoto: {3}", b.ruda, b.skora, b.klejnot, b.zloto);
                        continue;
                    case "2":
                        wytwarzajEkwipunek(b);
                        continue;
                    case "3":
                        Console.WriteLine("Wyjście z menu ekwipunku");
                        continue;
                    default:
                        Console.WriteLine("Wybierz poprawną opcję");
                        continue;
                }
            }
            Console.Clear();
        }
        public static void wytwarzajEkwipunek(Bohater b)
        {
            string wyborTworz = " ";
            while (wyborTworz != "5")
            {
                Console.WriteLine("1. Magiczny miecz\n5.Wyjdź");
                wyborTworz = Console.ReadLine();
                switch (wyborTworz)
                {
                    case "1":
                        if (postepMiecz == 0)
                        {
                            if (b.ruda >= 5 && b.skora >= 3 && b.klejnot >= 1)
                            {
                                Przedmiot magicznymiecz = new Przedmiot("Magiczny miecz", 2, 2, 2, 2, 2, 100);
                                b.sila = b.sila + magicznymiecz.sila;
                                b.zrecznosc = b.zrecznosc + magicznymiecz.zrecznosc;
                                b.wytrzymalosc = b.wytrzymalosc + magicznymiecz.wytrzymalosc;
                                b.inteligencja = b.inteligencja + magicznymiecz.inteligencja;
                                b.charyzma = b.charyzma + magicznymiecz.charyzma;
                                b.ruda = b.ruda - 5;
                                b.skora = b.skora - 5;
                                b.klejnot = b.klejnot - 1;
                                postepMiecz++;
                                Console.WriteLine("Wykułeś magiczny miecz!!!");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                
                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco do ulepszenia miecza");
                            }
                        }
                        if (postepMiecz == 1)
                        {
                            if (b.ruda >= 20 && b.skora >= 10 && b.klejnot >= 4)
                            {
                                b.sila = b.sila + magicznymiecz.sila;
                                b.zrecznosc = b.zrecznosc + magicznymiecz.zrecznosc;
                                b.wytrzymalosc = b.wytrzymalosc + magicznymiecz.wytrzymalosc;
                                b.inteligencja = b.inteligencja + magicznymiecz.inteligencja;
                                b.charyzma = b.charyzma + magicznymiecz.charyzma;
                                b.ruda = b.ruda - 5;
                                b.skora = b.skora - 5;
                                b.klejnot = b.klejnot - 1;
                                postepMiecz++;
                                Console.WriteLine("Wykułeś magiczny miecz!!!");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");

                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco do ulepszenia miecza");
                            }

                        }
                            continue;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.WriteLine("Wyjście z menu ekwipunku");
                        continue;
                    default:
                        Console.WriteLine("Wybierz poprawną opcję");
                        continue;
                }
            }
            Console.Clear();
        }
        public static void nazwijPostac(Bohater b)
        {
            Console.WriteLine("Nazwij swoją postać.");
            string wybierzImie = "";
            while (!(Regex.IsMatch(wybierzImie, @"^[a-zA-Z]+$")))
            {
                wybierzImie = Console.ReadLine();
                if ((Regex.IsMatch(wybierzImie, @"^[a-zA-Z]+$")) == true)
                {
                    b.nazwa = wybierzImie;
                }
                else
                {
                    Console.WriteLine("Niepoprawne znaki");
                }
            }
                    Console.WriteLine("Witaj {0}", b.nazwa);
        }


    }
}
