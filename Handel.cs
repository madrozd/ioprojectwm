using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    /// <summary>
    /// Klasa <c>Handel</c> odpowiedzialna za metody umożliwiające graczowi kupno oraz sprzedaż przedmiotów z ekwipunku.
    /// </summary>
    class Handel
    {
        /// <summary>
        /// Metoda <c>wyborHandel</c>, która z użyciem instrukcji <c>switch</c> wywołuje opisane niżej metody odpowiedzialne za kupno i sprzedaż przedmiotów.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void wyborHandel(Bohater b)
        {
            string wyborOpcja = "";
            while (!(wyborOpcja == "3"))
            {
                Console.WriteLine("Odwiedziłeś targowisko\n1.Kupuj\n2.Sprzedawaj\n3.Opuść targowisko\n");
                wyborOpcja = Console.ReadLine();
                switch (wyborOpcja)
                {
                    case "1":
                        Handel.Kup(b);
                        continue;
                    case "2":
                        Handel.Sprzedaj(b);
                        continue;
                    case "3":
                        Console.WriteLine("Opuszczasz targowisko");
                        break;
                    default:
                        Console.WriteLine("Niepoprawny znak");
                        continue;

                }
            }

}
        /// <summary>
        /// Metoda <c>Sprzedaj</c> dzięki której bohater może zmniejszyć ilość posiadanych w ekwipunku przedmiotów. W momencie, gdy gracz zdecyduje się sprzedać przedmioty, 
        /// metoda sprawdza czy gracz posiada ilość pozwalającą na dokończenie transakcji.
        /// Jeśli posiada, to zwiększana jest wartość parametru <c>zloto</c> adekwatnie do iloczynu ilości przedmiotów, które gracz chce sprzedać i wartości pojedynczej sztuki. 
        /// Pomniejszana jest ilość danego przedmiotu odpowiednio do ilości wybranej przez gracza. Zmianie ulega również parametr <c>zarobioneZloto</c> - 
        /// do jego wartości dodawana jest ilość zarobionych na operacji pieniędzy.
        /// Jeśli nie posiada wyświetlany jest komunikat informujący, że nie można sprzedać.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void Sprzedaj(Bohater b)
        {

            int ilosc2;
            int zloto = 0;
            string wyborSprzedaj = " ";
            while (wyborSprzedaj != "4")
            {
                Console.WriteLine("1. Sprzedaj rudę\n2. Sprzedaj skórę\n3. Sprzedaj klejnoty\n4. Wyjście");
                wyborSprzedaj = Console.ReadLine();
                string ilosc = " ";
                string potwierdz = " ";
                switch (wyborSprzedaj)
                {
                    case "1":
                        Console.WriteLine("Posiadasz {0} rudy", b.ruda);
                        Console.WriteLine("Ile chcesz sprzedać? Jedna sztuka rudy kosztuje 10 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && ilosc2 <= b.ruda)
                            {
                                Console.WriteLine("Na pewno chcesz sprzedać {0} rudy?", ilosc2);
                                Console.WriteLine("1.Tak\n2.Nie");

                                while (!(potwierdz == "1") && !(potwierdz == "2"))
                                {
                                    potwierdz = Console.ReadLine();
                                    switch (potwierdz)
                                    {
                                        case "1":
                                            zloto = ilosc2 * 10;
                                            Gildia.zarobioneZloto = Gildia.zarobioneZloto + zloto;
                                            b.zloto = b.zloto + zloto;
                                            b.ruda = b.ruda - ilosc2;
                                            Console.WriteLine("Sprzedałeś {0} rudy za {1} złota.", ilosc2, zloto);
                                            continue;
                                        case "2":
                                            Console.WriteLine("Zrezygnowałeś");
                                            continue;
                                        default:
                                            Console.WriteLine("Niepoprawny znak");
                                            continue;
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("Nie możesz sprzedać minusowej oraz większej niż posiadana ilości rudy");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna wartość");
                        }
                        continue;
                    case "2":
                        Console.WriteLine("Posiadasz {0} skóry", b.skora);
                        Console.WriteLine("Ile chcesz sprzedać? Jedna sztuka skóry kosztuje 20 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && ilosc2 <= b.skora)
                            {
                                Console.WriteLine("Na pewno chcesz sprzedać {0} skór?", ilosc2);
                                Console.WriteLine("1.Tak\n2.Nie");

                                while (!(potwierdz == "1") && !(potwierdz == "2"))
                                {
                                    potwierdz = Console.ReadLine();
                                    switch (potwierdz)
                                    {
                                        case "1":
                                            zloto = ilosc2 * 20;
                                            Gildia.zarobioneZloto = Gildia.zarobioneZloto + zloto;
                                            b.zloto = b.zloto + zloto;
                                            b.skora = b.skora - ilosc2;
                                            Console.WriteLine("Sprzedałeś {0} skór za {1} złota.", ilosc2, zloto);
                                            continue;
                                        case "2":
                                            Console.WriteLine("Zrezygnowałeś");
                                            continue;
                                        default:
                                            Console.WriteLine("Niepoprawny znak");
                                            continue;
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("Nie możesz sprzedać minusowej oraz większej niż posiadana ilości skóry");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna wartość");
                        }
                        continue;
                    case "3":
                        Console.WriteLine("Posiadasz {0} klejnotów", b.klejnot);
                        Console.WriteLine("Ile chcesz sprzedać? Jeden klejnot kosztuje 50 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && ilosc2 <= b.klejnot)
                            {
                                Console.WriteLine("Na pewno chcesz sprzedać {0} klejnotów?", ilosc2);
                                Console.WriteLine("1.Tak\n2.Nie");

                                while (!(potwierdz == "1") && !(potwierdz == "2"))
                                {
                                    potwierdz = Console.ReadLine();
                                    switch (potwierdz)
                                    {
                                        case "1":
                                            zloto = ilosc2 * 50;
                                            Gildia.zarobioneZloto = Gildia.zarobioneZloto + zloto;
                                            b.zloto = b.zloto + zloto;
                                            b.klejnot = b.klejnot - ilosc2;
                                            Console.WriteLine("Sprzedałeś {0} klejnotów za {1} złota.", ilosc2, zloto);
                                            continue;
                                        case "2":
                                            Console.WriteLine("Zrezygnowałeś");
                                            continue;
                                        default:
                                            Console.WriteLine("Niepoprawny znak");
                                            continue;
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("Nie możesz sprzedać minusowej oraz większej niż posiadasz ilości klejnotów");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna wartość");
                        }
                        continue;
                    case "4":
                        Console.WriteLine("Wyjście");
                        continue;
                    default:
                        Console.Write("Wybierz poprawną opcję");
                        continue;

                }

            }
            Console.Clear();

        }
        /// <summary>
        /// Metoda <c>Kup</c> odpowiedzialna za kupno przedmiotu. Gracz wybiera co chce kupić, następnie wpisuje interesującą go ilość. Metoda sprawdza czy gracz posiada odpowiednią ilość złota 
        /// potrzebną do zakupu. Jeśli gracz akceptuje ofertę zakupu, zwiększeniu ulega ilość towaru w ekwipunku,zmniejszona zostaje natomiast ilość posiadanego złota odpowiednio 
        /// do iloczynu ilości przedmiotów, które gracz chce kupić i wartości pojedynczej sztuki. Jeśli gracz nie akceptuje oferty wyświetla się komunikat o tym, że gracz zrezygnował z zakupu. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void Kup(Bohater b)
        {

            int ilosc2;
            int zloto = 0;
            string wyborKup = " ";
            while (wyborKup != "4")
            {
                Console.WriteLine("1. Kup rudę\n2. Kup skórę\n3. Kup klejnoty\n4. Wyjście");
                wyborKup = Console.ReadLine();
                string ilosc = " ";
                string potwierdz = " ";
                switch (wyborKup)
                {
                    case "1":
                        Console.WriteLine("Posiadasz {0} rudy", b.ruda);
                        Console.WriteLine("Ile chcesz kupić? Jedna sztuka rudy kosztuje 20 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && b.zloto >= ilosc2 * 20)
                            {
                                Console.WriteLine("Na pewno chcesz kupić {0} rudy za {1}?", ilosc2, ilosc2 * 20);
                                Console.WriteLine("1.Tak\n2.Nie");

                                while (!(potwierdz == "1") && !(potwierdz == "2"))
                                {
                                    potwierdz = Console.ReadLine();
                                    switch (potwierdz)
                                    {
                                        case "1":
                                            zloto = ilosc2 * 20;
                                            b.zloto = b.zloto - zloto;
                                            b.ruda = b.ruda + ilosc2;
                                            Console.WriteLine("Kupiłeś {0} rudy za {1} złota.", ilosc2, zloto);
                                            continue;
                                        case "2":
                                            Console.WriteLine("Zrezygnowałeś");
                                            continue;
                                        default:
                                            Console.WriteLine("Niepoprawny znak");
                                            continue;
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("Nie możesz kupić minusowej ilości rudy lub cię nie stać.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna wartość");
                        }
                        continue;
                    case "2":
                        Console.WriteLine("Posiadasz {0} skór", b.skora);
                        Console.WriteLine("Ile chcesz kupić? Jedna sztuka skóry kosztuje 40 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && b.zloto >= ilosc2 * 40)
                            {
                                Console.WriteLine("Na pewno chcesz kupić {0} skór za {1}?", ilosc2, ilosc2 * 40);
                                Console.WriteLine("1.Tak\n2.Nie");

                                while (!(potwierdz == "1") && !(potwierdz == "2"))
                                {
                                    potwierdz = Console.ReadLine();
                                    switch (potwierdz)
                                    {
                                        case "1":
                                            zloto = ilosc2 * 20;
                                            b.zloto = b.zloto - zloto;
                                            b.skora = b.skora + ilosc2;
                                            Console.WriteLine("Kupiłeś {0} skór za {1} złota.", ilosc2, zloto);
                                            continue;
                                        case "2":
                                            Console.WriteLine("Zrezygnowałeś");
                                            continue;
                                        default:
                                            Console.WriteLine("Niepoprawny znak");
                                            continue;
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("Nie możesz kupić minusowej ilości skór lub cię nie stać.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna wartość");
                        }
                        continue;
                    case "3":
                        Console.WriteLine("Posiadasz {0} klejnotów", b.klejnot);
                        Console.WriteLine("Ile chcesz kupić? Jedna sztuka klejnotów kosztuje 100 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && b.zloto >= ilosc2 * 100)
                            {
                                Console.WriteLine("Na pewno chcesz kupić {0} klejnotów za {1}?", ilosc2, ilosc2 * 100);
                                Console.WriteLine("1.Tak\n2.Nie");

                                while (!(potwierdz == "1") && !(potwierdz == "2"))
                                {
                                    potwierdz = Console.ReadLine();
                                    switch (potwierdz)
                                    {
                                        case "1":
                                            zloto = ilosc2 * 100;
                                            b.zloto = b.zloto - zloto;
                                            b.klejnot = b.klejnot + ilosc2;
                                            Console.WriteLine("Kupiłeś {0} rudy za {1} złota.", ilosc2, zloto);
                                            continue;
                                        case "2":
                                            Console.WriteLine("Zrezygnowałeś");
                                            continue;
                                        default:
                                            Console.WriteLine("Niepoprawny znak");
                                            continue;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie możesz kupić minusowej ilości klejnotów lub cię nie stać.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna wartość");
                        }
                        continue;
                }
            }
            Console.Clear();
        }
    }
}
