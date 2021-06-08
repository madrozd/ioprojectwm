using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Akcja
    {
        public static void Menu(Bohater b, Przedmiot m, Przedmiot z, Przedmiot h, Przedmiot p)
        {
            Console.WriteLine("1.Dalej\n2.Wyświetl statystyki\n3.Odpocznij\n4.Handel\n5.Gildia kupców\n6.Gildia Wojowników\n7.Zakon mnichów\n8.Świątynia\n9.Zarządzaj ekwipunkiem\n10.Wyświetl punktację");
            string wyborAkcji = "";
            wyborAkcji = Console.ReadLine();
            switch (wyborAkcji)
            {
                case "1":
                    Przygody.Zdarzenia();
                    if (Przygody.los < 15)
                    {
                        Przygody.los++;
                    }
                    break;
                case "2":
                    b.wyswietlStatystyki(b);
                    break;
                case "3":
                    Akcja.Odpocznij(b);
                    break;
                case "4":
                    Handel.wyborHandel(b);
                    break;
                case "5":
                    Gildia.gildiaKupcow(b);
                    break;
                case "6":
                    Gildia.gildiaWojownikow(b);
                    break;
                case "7":
                    Gildia.gildiaMnichow(b);
                    break;
                case "8":
                    Swiatynia.wyborSwiatynia(b);
                    break;
                case "9":
                    Bohater.zarzadzajEkwipunkiem(b, m, z, h, p);
                    break;
                case "10":
                    Akcja.wyswietlPunktacje(b);
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
