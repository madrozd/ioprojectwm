using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    /// <summary>
    /// Klasa <c>Gildia</c> zawierająca metodę odpowiedzialną za wybór gildii oraz odpowiednie dla wybranej gildi metody opisane poniżej. 
    /// </summary>
    class Gildia
    {
        public static string gildia;
        public static int zarobioneZloto;
        public static int pokonaniPrzeciwnicy;
        public static int uznanieBostwo;
        private static int postep1 = 0;
        private static int postep2 = 0;
        private static int postep3 = 0;
        /// <summary>
        /// Metoda <c>wyborGildii</c> wywoływana jest na początku gry. Za pomocą instrukcji <c>switch</c> gracz może wybrać jedną z trzech dostępnych gildii. 
        /// Wybór może mieć wpływ na parametr <c>bohaterStatus</c>
        /// </summary>
        public static void wyborGildii()
        {
            Console.WriteLine("Przemierzając osadę natrafiasz na rynek. Na rynku dostrzegasz tablicę z trzema symbolami: kupieckim wozem, wojowniczymi mieczem z tarczą oraz religijnym kołowrotem. Oznaczają one, że gildie przyjmują nowych chętnych. Postanawiasz dołączyć do jednej z nich.\n");
            while (!(gildia == "1") && !(gildia == "2") && !(gildia == "3"))
            {
                Console.WriteLine("Decydujesz się na:\n1.Kupcy\n2.Wojownicy\n3.Mnisi ");
                gildia = Console.ReadLine();
                switch (gildia)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Wybrałeś gildię kupców");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Zdecydowałeś się dołączyć do gildii wojowników");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Obrałeś drogę mnicha");
                        break;
                    default:
                        Console.WriteLine("Niepoprawny znak");
                        break;
                }
            }
        }
        /// <summary>
        /// Metoda <c>gildiaKupców</c> dostępna jest dla gracza jeśli w metodzie <c>wyborGildii</c> wybrał gildię kupców. W zależności od wykonanych przez gracza postępów - 
        /// w tym wypadku odpowiedniej wartości parametru <c>zarobioneZloto</c>, może ona zmienić wartość zmiennej <c>bohaterStatus</c> oraz dodać graczowi przewidziane dla danego "progu" nagrody.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void gildiaKupcow(Bohater b)
        {
            if(gildia == "1")
            {
                Console.WriteLine("Witaj w naszych szeregach");
                if ((zarobioneZloto >= 300) && (postep1 == 0))
                {
                    Console.WriteLine("'W nagrodę za Twoje kupieckie osiągnięcia możesz od dziś nazywać się Targowym handlarzem! Otrzymujesz od nas również 100 szuk złota na dalsze prowadzenie interesów.'");
                    b.zloto = b.zloto + 100;
                    postep1 = 1;
                    b.bohaterStatus = "Targowy handlarz";
                }
                if ((zarobioneZloto >= 500) && (postep2 == 0))
                {
                    Console.WriteLine("'Udało Ci się zarobić jeszcze więcej złota! W nagrodę możesz od teraz nazywać się Kupcem.'");
                    Console.WriteLine("Otrzymujesz bonus do statystyk.");
                    b.inteligencja = b.inteligencja + 2;
                    b.zrecznosc = b.zrecznosc + 1;
                    postep2 = 1;
                    b.bohaterStatus = "Kupiec";
                }
                if ((zarobioneZloto >= 1000) && (postep3 == 0))
                {
                    Console.WriteLine("'Jesteś niczym bóg handlu! Nasz Mistrz kupiecki! Udało Ci się zarobić więcej niż ktokolwiek w naszej gildii Zostaniesz odpowiednio nagrodzony!'");
                    Console.WriteLine("W nagrodę za Twoje osiągnięcia otrzymujesz 20 rud, 20 skór oraz 10 klejnotów.");
                    b.ruda = b.ruda + 20;
                    b.skora = b.skora + 20;
                    b.klejnot = b.klejnot + 10;
                    postep3 = 1;
                    b.bohaterStatus = "Mistrz kupiecki";
                }
            }
            else
            {
                Console.WriteLine("Przykro nam nie możemy nic ci zaoferować");
            }
        }
        /// <summary>
        /// Metoda <c>gildiaWojownikow</c> dostępna jest dla gracza jeśli w metodzie <c>wyborGildii</c> wybrał gildię wojowników. W zależności od wykonanych przez gracza postępów - 
        /// w tym wypadku odpowiedniej ilości pokonanych przeciwników, może ona zmienić wartość zmiennej <c>bohaterStatus</c> oraz dodać graczowi przewidziane dla danego "progu" nagrody.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void gildiaWojownikow(Bohater b)
        {
            if (gildia == "2")
            {
                Console.WriteLine("Witaj w naszych szeregach");
                if ((pokonaniPrzeciwnicy >= 1) && (postep1 == 0))
                {
                    Console.WriteLine("'Jako nagrodę za Twą waleczność od dziś możesz nazywać się Giermkiem. Otrzymasz od nas również złoto na zakup dalszego wyposażenia.'");
                    Console.WriteLine("Otrzymujesz 100 sztuk złota");
                    b.zloto = b.zloto + 100;
                    postep1 = 1;
                    b.bohaterStatus = "Giermek";
                }
                if ((pokonaniPrzeciwnicy >= 2) && (postep2 == 0))
                {
                    Console.WriteLine("Coraz bardziej dowodzisz swojej waleczności. Od dziś gildia Wojowników pozwala Ci tytułować się Wojownikiem. Otrzymujesz również bonus do statystyk.");
                    b.sila = b.sila + 2;
                    b.zrecznosc = b.zrecznosc + 2;
                    postep2 = 1;
                    b.bohaterStatus = "Wojownik";
                }
                if ((pokonaniPrzeciwnicy >= 3) && (postep3 == 0))
                {
                    Console.WriteLine("'Twoja waleczność jest nieoceniona!' Gildia pozwala Ci tytułować się Rycerzem. Dodatkowo otrzymujesz 20 sztuk rudy, 20 skór oraz 10 klejnotów. ");
                    b.ruda = b.ruda + 20;
                    b.skora = b.skora + 20;
                    b.klejnot = b.klejnot + 10;
                    postep3 = 1;
                    b.bohaterStatus = "Rycerz";
                }
            }
            else
            {
                Console.WriteLine("Przykro nam nie możemy nic ci zaoferować");
            }
        }
        /// <summary>
        /// Metoda <c>gildiaMnichow</c> dostępna jest dla gracza jeśli w metodzie <c>wyborGildii</c> wybrał gildię mnichów. W zależności od wykonanych przez gracza postępów - 
        /// w tym wypadku odpowiedniego parametru <c>uznanieBostwo</c> zdobywanego poprzez odwiedzanie świątyni, może ona zmienić wartość zmiennej <c>bohaterStatus</c> 
        /// oraz dodać graczowi przewidziane dla danego "progu" nagrody.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void gildiaMnichow(Bohater b)
        {
            if (gildia == "3")
            {
                Console.WriteLine("Witaj w naszych szeregach");
                if ((uznanieBostwo >= 10) && (postep1 == 0))
                {
                    Console.WriteLine("'Osiągnąłeś pierwszy stopień wtajemniczenia. Od dziś jesteś naszym Nowicjuszem'.");
                    Console.WriteLine("Jako nagrodę za Twoje modlitwy otrzymujesz bonus do statystyk");
                    b.wytrzymalosc = b.wytrzymalosc + 1;
                    b.inteligencja = b.inteligencja + 1;
                    postep1 = 1;
                    b.bohaterStatus = "Nowicjusz";
                }
                if ((uznanieBostwo >= 50) && (postep2 == 0))
                {
                    Console.WriteLine("'Modlisz się bardzo gorliwie. Zostajesz mnichem.'");
                    Console.WriteLine("Otrzymujesz bonus do statystyk");
                    b.wytrzymalosc = b.wytrzymalosc + 2;
                    b.inteligencja = b.inteligencja + 2;
                    postep2 = 1;
                    b.bohaterStatus = "Mnich";
                }
                if ((uznanieBostwo >= 100) && (postep3 == 0))
                {
                    Console.WriteLine("'Twoja rozmowa z bogami oraz Twe chwalebne czyny doprowadziły Cię do zostania Przeorem naszego zakonu.'");
                    Console.WriteLine("Otrzymujesz bonus do statystyk");
                    b.wytrzymalosc = b.wytrzymalosc + 3;
                    b.inteligencja = b.inteligencja + 3;
                    postep3 = 1;
                    b.bohaterStatus = "Przeor";
                }
            }
            else
            {
                Console.WriteLine("Przykro nam nie możemy nic ci zaoferować");
            }
        }
    }
}
