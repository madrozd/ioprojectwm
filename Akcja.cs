using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Akcja
    {
        Bohater bohater = new Bohater("Bezimienny");
        public static int Odpocznij(int bierwiono, int wytrzymalosc)
        {
            
            if (bierwiono >= 1)
            {
               Console.WriteLine("Odpoczywasz");
               int maxPZ = wytrzymalosc * 10;
               return maxPZ; 
            }
            else
            {
                Console.WriteLine("Nie masz bierwiona");
                return 0;
            }
        }
        public static void wyswietlPunktacje(int punktacja)
        {
            Console.WriteLine(punktacja);
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
                                Console.WriteLine("Nie możesz sprzedać minusowej ilości rudy");
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
    }
        //public static void zmienStatystyki(ref Bohater b)
        //{
        //    b = new Bohater("Bezimienny");
        //     b.sila = 3;
        //}

    
}
