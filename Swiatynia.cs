using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
   /// <summary>
   /// Klasa publiczna <c>Swiatynia</c> w której, bohater należący do gildii mnichów może złożyć ofiarę bądź się pomodlić celem zwiększenia parametru <c>uznanieBostwo</c>.
   /// </summary>
    public class Swiatynia
    {
        private static int modlitwaIlosc = 0;
        /// <summary>
        /// Metoda <c>Swiatynia</c>, która na początku sprawdza czy bohater należy do gildii Mnichów. 
        /// Jesli należy, za pomocą instrukcji <c>switch</c> gracz wybiera czy chce się modlić - wywołując przy tym opisaną niżej metodę <c>Modlitwa</c> - czy też złożyć ofiarę z użyciem metody <c>Ofiara</c>.
        /// Jesli nie należy wywoływany jest komunikat informujący, że bohater nie ma czego tam szukać. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> jest odniesieniem do klasy <c>Bohater</c>.</param>
        public static void wyborSwiatynia(Bohater b)
        {
            if (Gildia.gildia == "3")
            {
                string wyborOpcja = "";
                while (!(wyborOpcja == "3"))
                {
                    Console.WriteLine("Wkroczyłeś do świątyni\n1.Pomódl się\n2.Ofiaruj 100 sztuk złota\n3.Opuść świątynie");
                    wyborOpcja = Console.ReadLine();
                    switch (wyborOpcja)
                    {
                        case "1":
                            Swiatynia.Modlitwa(b);
                            continue;
                        case "2":
                            Swiatynia.Ofiara(b);
                            continue;
                        case "3":
                            Console.WriteLine("Opuszczasz świątynię");
                             break;
                        default:
                            Console.WriteLine("Niepoprawny znak");
                            continue;

                    }
                }
            }

            else
            {
                Console.WriteLine("Nie masz czego szukać za tymi drzwiami");
            }

        }
        /// <summary>
        /// Metoda <c>Modlitwa</c>, która jest dostępna jeśli gracz wybierze modlitwę w świątyni. Każde podejście do modlitwy powoduje inkrementację zmiennej <c>modlitwaIlosc</c>, która jest licznikiem modlitw. 
        /// Jeśli <c>modlitwaIlosc</c> jest mniejsza od 5 następuje losowanie rezultatu modlitwy. W przeciwnym wypadku zostaje wyświetlony komunikat o przekroczonej ilości modlitw. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void Modlitwa(Bohater b)
        {
            Console.WriteLine("Postanowiłeś się pomodlić");
            if(modlitwaIlosc < 5)
            {
                int wynik = 0;
                modlitwaIlosc++;
                Random wynikModlitwa = new Random();
                wynik = wynikModlitwa.Next(1, 7);
                if(wynik == 1)
                {
                    Gildia.uznanieBostwo++;
                    Console.WriteLine("Uznanie bóstwa +1");
                }
                if (wynik == 2)
                {
                    Gildia.uznanieBostwo = Gildia.uznanieBostwo + 3;
                    Console.WriteLine("Uznanie bóstwa +3");
                }
                if (wynik == 3)
                {
                    Gildia.uznanieBostwo = Gildia.uznanieBostwo + 5;
                    Console.WriteLine("Uznanie bóstwa +5");
                }
                if (wynik == 4)
                {
                    Gildia.uznanieBostwo = Gildia.uznanieBostwo + 10;
                    Console.WriteLine("Uznanie bóstwa +10");
                }
                if (wynik == 5)
                {
                    Gildia.uznanieBostwo = Gildia.uznanieBostwo + 20;
                    b.inteligencja++;
                    Console.WriteLine("Uznanie bóstwa +20 oraz inteligencja +1");
                }
                if (wynik == 6)
                {
                    Gildia.uznanieBostwo = Gildia.uznanieBostwo + 20;
                    Console.WriteLine("Uznanie bóstwa +20 oraz siła +1");
                    b.sila++;
                }



            }
            else
            {
                Console.WriteLine("Wyczerpałeś swoją liczbę modlitw");
            }
        }
        /// <summary>
        /// Metoda <c>Ofiara</c>, dzięki której gracz może złożyć ofiarę na rzecz bóstwa. Sprawdzane jest czy bohater posiada odpowiednią ilość złota. 
        /// Jeśli posiada, potrzebna ilość jest odejmowana od zasobów gracza, a licznik modlitw zostaje wyzerowany.
        /// Jeśli nie posiada wyświetla się komunikat o braku odpowiedniej ilości złota. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void Ofiara(Bohater b)
        {
            Console.WriteLine("Zdecydowałeś się złożyć ofiarę");
            if(b.zloto >= 100)
            {
                Console.WriteLine("Złożono ofiarę w postaci 100 sztuk złota");
                modlitwaIlosc = 0;
                b.zloto = b.zloto - 100;
                
            }
            else
            {
                Console.WriteLine("Nie masz wystarczająco złota");
            }
        }
    }
}
