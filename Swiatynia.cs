using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
   public class Swiatynia
    {
        private static int modlitwaIlosc = 0;
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
