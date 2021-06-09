using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Walka
    {
        public static void Pojedynek(Bohater b, Przeciwnik p)
        {

            Console.WriteLine("Rozpoczynasz walkę z {0}", p.nazwa);
            Console.WriteLine("Twoje PZ: {0}\n", b.PZ);
            Console.WriteLine("Statystyki {0}\nSiła: {1}\nZręczność: {2}\nPZ: {3}\n", p.nazwa, p.sila, p.zrecznosc, p.PZ);
            string wybor = "";
            while (b.PZ > 0 && p.PZ > 0)
            {
                Console.WriteLine("1. Atak\n2. Obrona");
                wybor = Console.ReadLine();
                switch (wybor)
                {
                    case "1":
                        Walka.Atak(b, p);
                        continue;
                    case "2":
                        Walka.Obrona(b, p);
                        continue;
                    default:
                        Console.WriteLine("Niepoprawny znak");
                        continue;
                }
            }
            Gildia.pokonaniPrzeciwnicy++;
            b.PD = b.PD + p.nagrodaP + (b.inteligencja / 2);
            b.zloto = b.zloto + p.nagrodaZ;
            p.PZ = p.maxPZ;


        }
        public static void Atak( Bohater b, Przeciwnik p)
        {
            int obrazenia = 0;
            int trafienieSprawdz = 0;
            int krytSprawdz = 0;
            Random szansaTrafienie = new Random(); 
            Random krytLosowanie = new Random();
            trafienieSprawdz = (b.zrecznosc / 3) + (szansaTrafienie.Next(0, 6));
            Console.WriteLine("Zdecydowałeś się na atak\n{0} Atakuje!", b.nazwa);
            if (trafienieSprawdz > 3)
            {
                krytSprawdz = (b.zrecznosc / 2) + (krytLosowanie.Next(0, 8));
                if (krytSprawdz >= 8)
                {
                    obrazenia = b.sila * 3;
                    Console.WriteLine("CIOS KRYTYCZNY!\n Zadałeś {0} obrażeń!", obrazenia);
                    p.PZ = p.PZ - obrazenia;
                    Console.WriteLine("Życie przeciwnika: {0}",p.PZ);
                    Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                    Console.ReadKey();

                }
                else
                {
                    obrazenia = b.sila * 1;
                    Console.WriteLine("Cios\n Zadałeś {0} obrażeń!", obrazenia);
                    p.PZ = p.PZ - obrazenia;
                    Console.WriteLine("Życie przeciwnika: {0}", p.PZ);
                    Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Chybiony cios");
                Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                Console.ReadKey();
            }
            if (p.PZ > 0)
            {
                obrazenia = 0;
                trafienieSprawdz = 0;
                krytSprawdz = 0;
                trafienieSprawdz = (p.zrecznosc / 3) + (szansaTrafienie.Next(0, 6));
                Console.WriteLine("{0} odpowiada atakiem!", p.nazwa);
                if (trafienieSprawdz > 3)
                {
                    krytSprawdz = (p.zrecznosc / 2) + (krytLosowanie.Next(0, 8));
                    if (krytSprawdz >= 8)
                    {
                        obrazenia = p.sila * 3;
                        Console.WriteLine("CIOS KRYTYCZNY!\n zadał {0} obrażeń!", obrazenia);
                        b.PZ = b.PZ - obrazenia;
                        Console.WriteLine("Twoje życie: {0}", b.PZ);
                        Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                        Console.ReadKey();
                    }
                    else
                    {
                        obrazenia = p.sila * 1;
                        Console.WriteLine("Cios\n zadał {0} obrażeń!", obrazenia);
                        b.PZ = b.PZ - obrazenia;
                        Console.WriteLine("Twoje życie: {0}", b.PZ);
                        Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Chybiony cios");
                    Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                    Console.ReadKey();
                }
            }
            else 
            {
                Console.WriteLine("Przeciwnik pokonany");
            }
            if (b.PZ <= 0)
            {
                Console.WriteLine("Przegrałes.\nKoniec gry.");
                Environment.Exit(0);
            }
        }
        public static void Obrona(Bohater b, Przeciwnik p)
        {
            int maxPZ = b.wytrzymalosc * 10;
            int licznik = 0;
            Console.WriteLine("Zdecydowałeś się na obronę");
            if (b.PZ < maxPZ)
            {
                while (!(licznik == maxPZ/10) && !(b.PZ == maxPZ))
                {
                    licznik++;
                    b.PZ++;
                    Console.WriteLine(b.PZ);
                    Console.ReadKey();
                }
            }
            int obrazenia = 0;
            int trafienieSprawdz = 0;
            int krytSprawdz = 0;
            Random szansaTrafienie = new Random();
            Random krytLosowanie = new Random();
            trafienieSprawdz = (p.zrecznosc / 3) + (szansaTrafienie.Next(0, 6));
            Console.WriteLine("{0} atakuje!", p.nazwa);
            if (trafienieSprawdz > 4)
            {
                krytSprawdz = (p.zrecznosc / 2) + (krytLosowanie.Next(0, 8));
                if (krytSprawdz >= 8)
                {
                    obrazenia = p.sila * 2;
                    Console.WriteLine("CIOS KRYTYCZNY!\n zadał {0} obrażeń!", obrazenia);
                    b.PZ = b.PZ - obrazenia;
                    Console.WriteLine("Twoje życie: {0}", b.PZ);
                    Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                    Console.ReadKey();
                }
                else
                {
                    obrazenia = p.sila * 1;
                    Console.WriteLine("Cios\n zadał {0} obrażeń!", obrazenia);
                    b.PZ = b.PZ - obrazenia;
                    Console.WriteLine("Twoje życie: {0}", b.PZ);
                    Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Chybiony cios");
                Console.WriteLine("Naciśnij klawisz aby kontynuuować");
                Console.ReadKey();
            }
        }
    }   
}
