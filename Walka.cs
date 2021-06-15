using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    /// <summary>
    /// Klasa publiczna <c>Walka</c> odpowiedzialna jest za walkę z przeciwnikami. Istnieją w niej metody odpowiedzialne za wywołanie pojedynku, za atakowanie oraz za obronę.  
    /// </summary>
    class Walka
    {
        /// <summary>
        /// Metoda <c>Pojedynek</c> wywoływana, gdy gracz wylosuje walkę z przeciwnikiem podczas przygody. Gracz informowany jest o nazwie przeciwnika z którym będzie walczył. 
        /// Wyświetlana jest też posiadana obecnie przez bohatera ilość punktów życia oraz statystyki bohatera. Z użyciem instrukcji <c>switch</c> gracz wybiera 
        /// czy chce atakować - wywoływana jest metoda <c>Atak</c>, czy też się bronić - z uzyciem metody <c>Obrona</c>.
        /// Wygrana gracza następuje po utracie wszystkich punktów życia przeciwnika. Bohater otrzymuje wtedy przewidzianą nagrodę za pokonanie przeciwnika. 
        /// Następuje również inkrementacja parametru <c>pokonaniPrzeciwnicy</c> oraz zostają przywrócone punkty życia przeciwnika.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        /// <param name="p">Parametr <c>p</c> służy do przesłania do funkcji obiektu klasy <c>Przeciwnik</c>.</param>
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
            Console.WriteLine("Otrzymałeś: {0} punktów doświadczenia oraz {1} złota.", (p.nagrodaP + (b.inteligencja / 2)),p.nagrodaZ);
            p.PZ = p.maxPZ;


        }
        /// <summary>
        /// Metoda <c>Atak</c> wywoływana, jeśli w instrukcji <c>switch</c> metody <c>Pojedynek</c> gracz wybierze, że chce atakować. 
        /// Na początku ataku zostają zainicjowane zmienne losowe <c>szansaTrafienia</c> i <c>krytSprawdź</c>, odpowiedzialne kolejno za obliczenie zmiennej zawierającej szansę na trafienie przeciwnika oraz czy zadane obrażenie jest tzw. obrażeniem krytycznym. 
        /// Jeśli wartość <c>trafienieSprawdz</c> jest mniejsza od 3 zostaje wyświetlony komunikat o chybionym ciosie.
        /// W przypadku gdy wartość <c>trafienieSprawdz<c> jest większa od 3, obliczana jest zmienna odpowiedzialna za szansę na obrażenie krytyczne - jest to suma połowy zręczności gracza i wartości wylosowanej w zmiennej <c>krytSprawdz</c>.
        /// Jeśli <c>krytSprawdź</c> jest większa bądź równa 8, wartość <c>obrazenia</c> staje się siłą pomnożoną razy 3, a przeciwnikowi odejmowana jest taka ilość punktów życia jaką wskazuje <c>obrazenia</c>.
        /// W przeciwnym przypadku  wartość <c>obrazenia</c> to iloczyn siły i 1, a przeciwnikowi odejmowana jest taka ilość punktów życia jaką wskazuje <c>obrazenia</c>.
        /// Jeśli przeciwnik posiada jeszcze punkty życia może zaatakować przeciwnika. Atak w jego przypadku odbywa się podobnie do ataku gracza.
        /// Jeśli bohater utraci punkty życia, wyświetlany jest komunikat o przegranej. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy <c>Bohater</c>.</param>
        /// <param name="p">Parametr <c>p</c> służy do przesłania do funkcji obiektu klasy <c>Przeciwnik</c>.</param>
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
        /// <summary>
        /// Metoda <c>Obrona</c> wywoływana jest jeśli w instrukcji <c>switch</c> metody <c>Pojedynek</c>, gracz wybierze obronę.
        /// Na początku sprawdzone czy punkty życia bohatera są mniejsze od wartości <c>maxPZ</c> będącej maksymalną ilością punktów życia gracza. Jeśli są mniejsze, to punkty życia bohatera zostają odnowione.
        /// Następnie następuje faza ataku przeciwnika wyglądająca tak samo, jak opisane jest w metodzie <c>Atak</c>.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy <c>Bohater</c>.</param>
        /// <param name="p">Parametr <c>p</c> służy do przesłania do funkcji obiektu klasy <c>Przeciwnik</c>.</param>
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
