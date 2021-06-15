using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    ///<summary>
    ///Klasa publiczna <c>Akcja</c>, w której znajdują się metody odpowiedzialne za menu wyboru, odpoczynek oraz wyświetlenie punktacji. 
    ///</summary>
   public class Akcja
    {
        private static int odwiedzinyMieszko = 0;
        /// <summary>
        /// Metoda <c>Menu</c>. Służy do wybierania kolejnych opcji rozgrywki. Wybór opcji odbywa się poprzez wpisanie wartości zmiennej "wybórAkcji", 
        /// po czym następuje wywołanie odpowiedniej metody. W metodzie tej występuje kilka parametrów. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        /// <param name="m">Parametr <c>m</c> jest odniesieniem do elementu <c>Miecz</c> z klasy <c>Bohater</c></param>
        /// <param name="z">Parametr <c>z</c> jest odniesieniem do elementu <c>Zbroja</c> z klasy <c>Bohater</c></param>
        /// <param name="h">Parametr <c>h</c> jest odniesieniem do elementu "Hełm" z klasy <c>Bohater</c></param>
        /// <param name="p">Parametr <c>p</c> jest odniesieniem do elementu "Pas" z klasy <c>Bohater</c></param>
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
                    if (Przygody.los < 11)
                    {
                        Przygody.los++;
                        Przygody.licznikPrzygod++;
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
                case "Mieszko":
                    Console.Clear();
                    if (Akcja.odwiedzinyMieszko == 0)
                    {
                        Console.WriteLine("'Widzę, że już Ci się polepszyło. No to dobrze, bogi mają Cię w opiece.' Po chwili rozmowy, Kmieć postanowił się podzielić z Tobą swoimi problemami. Okazuje się, że jego córka Lesława jest dręczona przez Gnieciucha - dosyć często męczył ją w nocy. Obecnie przebywa w chatce miejscowej zielarki, która stara się pomóc dziewczynie.");
                        Console.WriteLine("Zaintrygowany opowieścią zastanawiasz się, czy byłaby jakaś szansa, abyś pomógł dziewczynie i tym samym odwdzięczył się Kmieciowi Mieszkowi za pomoc.");
                        b.drugieZakonczenie = 1;
                        Akcja.odwiedzinyMieszko = 1;
                    }
                    else
                    {
                        Console.WriteLine("Kmiecia Mieszka nie ma w domu.");
                    }
                    break;
                default:
                    Console.WriteLine("Niepoprawny znak");
                    break;
            }
        }
        /// <summary>
        /// Metoda <c>Odpocznij</c>, powoduje zmianę wartości zmiennej "bierwiono" czego rezultatem jest zmiana wartości zmiennej "PZ". 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
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
        /// <summary>
        /// Metoda <c>wyswietlPunktację</c>, mająca na celu wyświetlenie ilości punktów osiągniętych przez gracza. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void wyswietlPunktacje(Bohater b)
        {
            Console.WriteLine("Twoja punktacja: {0}",b.punktacja);
        }
    }

}
