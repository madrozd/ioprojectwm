using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bohater : Arkusz
    {
        public  int PD;
        public  int bierwiono;
        public static int zloto;
        public static int punktacja;
        public static int ruda;
        public static int skora;
        public static int klejnot;
        public string bohaterStatus;

        public Bohater(string imie)
        {
            nazwa = imie;         
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

       public void wyswietlStatystyki()
        {
            Console.WriteLine("Siła: {0}\nZręczność: {1}\nWytrzymałość: {2}\nInteligencja: {3}\nCharyzma: {4}\nPunkty Życia: {5}", sila, zrecznosc, wytrzymalosc, inteligencja, charyzma, PZ); ;
        }
       public void Awans()
        {
            int silaPrzed = sila;
            int zrecznoscPrzed = zrecznosc;
            int wytrzymaloscPrzed = wytrzymalosc;
            int inteligencjaPrzed = inteligencja;
            int charyzmaPrzed = charyzma;
            if (PD >= 10)
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
                            sila++;
                            i++;
                            continue;
                        case "2":
                            zrecznosc++;
                            i++;
                            continue;
                        case "3":
                            wytrzymalosc++;
                            i++;
                            continue;
                        case "4":
                            inteligencja++;
                            i++;
                            continue;
                        case "5":
                            charyzma++;
                            i++;
                            continue;
                        default:
                            Console.WriteLine("Wybierz poprawnie");
                            continue;
                    }
                }
                Console.WriteLine("Siła: {0}\nZręczność: {1}\nWytrzymałość: {2}\nInteligencja: {3}\nCharyzma: {4}", sila, zrecznosc, wytrzymalosc, inteligencja, charyzma);
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
                            PD = PD - 10;
                            PZ = wytrzymalosc * 10;
                            break;
                        case "2":
                            Console.WriteLine("Odrzuciłeś swój wybór. Twoje punkty doświadczenia nie zostaną zabrane");
                            sila = silaPrzed;
                            zrecznosc = zrecznoscPrzed;
                            wytrzymalosc = wytrzymaloscPrzed;
                            inteligencja = inteligencjaPrzed;
                            charyzma = charyzmaPrzed;
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

        public void zarzadzajEkwipunkiem()
        {
            string wyborEkwipunek = " ";
            while (wyborEkwipunek != "3")
            {
                Console.WriteLine("1.Stan ekwipunku\n2.Wytwarzanie przedmiotów\n3.Zakończ");
                wyborEkwipunek = Console.ReadLine();
                switch (wyborEkwipunek)
                {
                    case "1":
                        Console.WriteLine("Stan twojego ekwipunku:\nRuda: {0}\nSkóry: {1}\nKlejnoty: {2}\nZłoto: {3}", ruda, skora, klejnot, zloto);
                        continue;
                    case "2":
                        wytwarzajEkwipunek();
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
        public void wytwarzajEkwipunek()
        {
            string wyborTworz = " ";
            while (wyborTworz != "3")
            {
                Console.WriteLine("1. Magiczny miecz");
                wyborTworz = Console.ReadLine();
                switch (wyborTworz)
                {
                    case "1":
                        Przedmiot magicznymiecz = new Przedmiot("Magiczny miecz", 10,1,5,3,99,100);
                        sila = sila + magicznymiecz.sila;
                        zrecznosc = zrecznosc + magicznymiecz.zrecznosc;
                        wytrzymalosc = wytrzymalosc + magicznymiecz.wytrzymalosc;
                        inteligencja = inteligencja + magicznymiecz.inteligencja;
                        charyzma = charyzma + magicznymiecz.charyzma;
                        Console.WriteLine("Wykułeś magiczny miecz!!!");
                        Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
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


    }
}
