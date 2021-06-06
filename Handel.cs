using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Handel
    {
        public static void wyborHandel()
        {
            string wyborOpcja = "";
            while (!(wyborOpcja == "3"))
            {
                Console.WriteLine("Odwiedziłeś targowisko\n1.Kupuj\n2.Sprzedawaj\n3.Opuść targowisko\n");
                wyborOpcja = Console.ReadLine();
                switch (wyborOpcja)
                {
                    case "1":
                        Handel.Kup();
                        continue;
                    case "2":
                        Handel.Sprzedaj();
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
        public static void Sprzedaj()
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
                        Console.WriteLine("Posiadasz {0} rudy", Bohater.ruda);
                        Console.WriteLine("Ile chcesz sprzedać? Jedna sztuka rudy kosztuje 10 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && ilosc2 <= Bohater.ruda)
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
                                            Bohater.zloto = Bohater.zloto + zloto;
                                            Bohater.ruda = Bohater.ruda - ilosc2;
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
                        Console.WriteLine("Posiadasz {0} skóry", Bohater.skora);
                        Console.WriteLine("Ile chcesz sprzedać? Jedna sztuka skóry kosztuje 20 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && ilosc2 <= Bohater.skora)
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
                                            Bohater.zloto = Bohater.zloto + zloto;
                                            Bohater.skora = Bohater.skora - ilosc2;
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
                        Console.WriteLine("Posiadasz {0} klejnotów", Bohater.klejnot);
                        Console.WriteLine("Ile chcesz sprzedać? Jeden klejnot kosztuje 50 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && ilosc2 <= Bohater.klejnot)
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
                                            Bohater.zloto = Bohater.zloto + zloto;
                                            Bohater.klejnot = Bohater.klejnot - ilosc2;
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
        public static void Kup()
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
                        Console.WriteLine("Posiadasz {0} rudy", Bohater.ruda);
                        Console.WriteLine("Ile chcesz kupić? Jedna sztuka rudy kosztuje 20 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && Bohater.zloto >= ilosc2 * 20)
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
                                            Bohater.zloto = Bohater.zloto - zloto;
                                            Bohater.ruda = Bohater.ruda + ilosc2;
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
                        Console.WriteLine("Posiadasz {0} skór", Bohater.skora);
                        Console.WriteLine("Ile chcesz kupić? Jedna sztuka skóry kosztuje 40 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && Bohater.zloto >= ilosc2 * 40)
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
                                            Bohater.zloto = Bohater.zloto - zloto;
                                            Bohater.skora = Bohater.skora + ilosc2;
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
                        Console.WriteLine("Posiadasz {0} klejnotów", Bohater.klejnot);
                        Console.WriteLine("Ile chcesz kupić? Jedna sztuka klejnotów kosztuje 100 złota");
                        ilosc = Console.ReadLine();
                        if (int.TryParse(ilosc, out ilosc2))
                        {

                            if (ilosc2 >= 0 && Bohater.zloto >= ilosc2 * 100)
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
                                            Bohater.zloto = Bohater.zloto - zloto;
                                            Bohater.klejnot = Bohater.klejnot + ilosc2;
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
