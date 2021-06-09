using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Akcja
    {
        private static int odwiedzinyKmiec = 0;
        public static void Menu(Bohater b, Przedmiot m, Przedmiot z, Przedmiot h, Przedmiot p)
        {
            Console.WriteLine("1.Dalej\n2.Wyświetl statystyki\n3.Odpocznij\n4.Handel\n5.Gildia kupców\n6.Gildia Wojowników\n7.Zakon mnichów\n8.Świątynia\n9.Zarządzaj ekwipunkiem\n10.Wyświetl punktację");
            string wyborAkcji = "";
            wyborAkcji = Console.ReadLine();
            switch (wyborAkcji)
            {
                case "1":
                    Console.Clear();
                    Przygody.Zdarzenia(b);
                    if (Przygody.los < 15)
                    {
                        Przygody.los++;
                    }
                    break;
                case "2":
                    Console.Clear();
                    b.wyswietlStatystyki(b);
                    break;
                case "3":
                    Console.Clear();
                    Akcja.Odpocznij(b);
                    break;
                case "4":
                    Console.Clear();
                    Handel.wyborHandel(b);
                    break;
                case "5":
                    Console.Clear();
                    Gildia.gildiaKupcow(b);
                    break;
                case "6":
                    Console.Clear();
                    Gildia.gildiaWojownikow(b);
                    break;
                case "7":
                    Console.Clear();
                    Gildia.gildiaMnichow(b);
                    break;
                case "8":
                    Console.Clear();
                    Swiatynia.wyborSwiatynia(b);
                    break;
                case "9":
                    Console.Clear();
                    Bohater.zarzadzajEkwipunkiem(b, m, z, h, p);
                    break;
                case "10":
                    Console.Clear();
                    Akcja.wyswietlPunktacje(b);
                    break;
                case "Kmiec":
                    if (Akcja.odwiedzinyKmiec == 0)
                    {
                        Console.WriteLine("Kmieć opowiada o swoim problemie ...");
                        b.drugieZakonczenie = 1;
                        Akcja.odwiedzinyKmiec = 1;
                    }
                    else
                    {
                        Console.WriteLine("Drzwi są zamknięte");
                    }
                    break;
                default:
                    Console.WriteLine("Niepoprawny znak");
                    break;
            }
        }
        public static void Odpocznij(Bohater b)
        {
            
            if (b.bierwiono >= 1)
            {
               Console.WriteLine("Odpoczywasz");
               b.PZ = b.wytrzymalosc * 10;
               b.bierwiono--;
                
            }
            else
            {
                Console.WriteLine("Nie masz bierwiona");
            }
        }
        public static void wyswietlPunktacje(Bohater b)
        {
            Console.WriteLine("Twoja punktacja: {0}",b.punktacja);
        }
    }

}
