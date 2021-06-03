using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bohater : Arkusz
    {
        public int PD;
        public int bierwiono;
        public int zloto;
        public int punktacja;
        public Bohater(string imie)
        {
            nazwa = imie;
            PZ = 10;
            sila = 1;
            zrecznosc = 1;
            wytrzymalosc = 1;
            inteligencja = 1;
            charyzma = 1;
            PD = 0;
            bierwiono = 1;
            zloto = 0;
            punktacja = 0;
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
                for (int i = 0; i < punktyStatystyk; i++)
                {
                    string wyborStatystyk = Console.ReadLine();
                    int wyborStat = int.Parse(wyborStatystyk);
                    switch (wyborStat)
                    {
                        case 1:
                            sila++;
                            continue;
                        case 2:
                            zrecznosc++;
                            continue;
                        case 3:
                            wytrzymalosc++;
                            continue;
                        case 4:
                            inteligencja++;
                            continue;
                        case 5:
                            charyzma++;
                            continue;
                    }
                }
                Console.WriteLine("Siła: {0}\nZręczność: {1}\nWytrzymałość: {2}\nInteligencja: {3}\nCharyzma: {4}", sila, zrecznosc, wytrzymalosc, inteligencja, charyzma);
                Console.WriteLine("1. Zaakceptuj wybór statystyk");
                Console.WriteLine("2. Zrezygnuj");
                string Potwierdz = Console.ReadLine();
                int Potwierdzenie = int.Parse(Potwierdz);
                switch (Potwierdzenie)
                {
                    case 1:
                        Console.WriteLine("Twój wybór został potwierdzony");
                        PD = PD - 10;
                        break;
                    case 2:
                        Console.WriteLine("Odrzuciłeś swój wybór. Twoje punkty doświadczenia nie zostaną zabrane");
                        sila = silaPrzed;
                        zrecznosc = zrecznoscPrzed;
                        wytrzymalosc = wytrzymaloscPrzed;
                        inteligencja = inteligencjaPrzed;
                        charyzma = charyzmaPrzed;
                        break;
                    default:
                        Console.WriteLine("Wybierz poprwną opcję");
                        break;

                }        
            }
            else
            {
                Console.WriteLine("Nie jestes gotowy");
            }
        }
    }
}
