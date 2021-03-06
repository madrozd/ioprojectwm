using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Gra
{
    /// <summary>
    /// Klasa publiczna <c>Bohater</c>. Klasa ta dziedziczy z klasy Arkusz. W klasie istnieją metody<c>Bohater</c>, <c>wyswietlStatystyki</c>, <c>Awans</c>, <c>zarzadzajEkwipunkiem</c>, 
    /// <c>wytwarzajEkwipunek</c>, <c>nazwijPostać</c>, <c>wyswietlStat</c>, <c>wyswietlPunktacje</c>.
    /// </summary>
    public class Bohater : Arkusz
    {
        public int PD;
        public int bierwiono;
        public int zloto;
        public int punktacja;
        public int ruda;
        public int skora;
        public int klejnot;
        public string bohaterStatus;
        public int drugieZakonczenie = 0;
        private  int postepMiecz = 0;
        private  int postepZbroja = 0;
        private  int postepHelm = 0;
        private  int postepPas = 0;

        /// <summary>
        /// Konstruktor <c>Bohater</c>, służący do utworzenia bohatera. 
        /// </summary>
        public Bohater()
        {
            nazwa = "Bezimienny";
            sila = 1;
            zrecznosc = 1;
            PZ = 10;
            wytrzymalosc = 1;
            inteligencja = 1;
            charyzma = 1;
            PD = 10;
            bierwiono = 1;
            zloto = 0;
            punktacja = 0;
            ruda = 0;
            skora = 0;
            klejnot = 0;
            bohaterStatus = "Nieznany";
        }
        /// <summary>
        /// Metoda <c>wyswietlStatystyki</c> w której poprzez instrukcję <c>switch</c> można wywołać dwie inne metody opisane poniżej. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public void wyswietlStatystyki(Bohater b)
        {
            string wybor = "";
            while (!(wybor == "3"))
            {
                Console.WriteLine("1.Wyświetl statystyki\n2.Awansuj na kolejny poziom (wymaga 10PD)\n3.Opuśc menu");
                wybor = Console.ReadLine();
                switch (wybor)
                {
                    case "1":
                        b.wyswietlStat(b);
                        break;
                    case "2":
                        b.Awans(b);
                        break;
                    default:
                        {
                            Console.WriteLine("Niepoprawny znak");
                            break;
                        }

                }
            }
            Console.Clear();
        }
        /// <summary>
        /// Metoda <c>Awans</c> pozwalająca graczowi na zmianę statystyk postaci. W metodzie tej zostają utworzone zmienne, które przechowują wartości statystyk postaci przed ich zwiększaniem.
        /// Gracz wybiera, którą cechę chce zwiększyć, po czym następuje jej zwiększenie. Jesli gracz zrezygnuje ze zwiększania statystyk zostają one przywrócone do poprzednich wartości. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public void Awans(Bohater b)
        {
            int silaPrzed = b.sila;
            int zrecznoscPrzed = b.zrecznosc;
            int wytrzymaloscPrzed = b.wytrzymalosc;
            int inteligencjaPrzed = b.inteligencja;
            int charyzmaPrzed = b.charyzma;
            if (b.PD >= 10)
            {
                int punktyStatystyk = 5;
                Console.WriteLine("Gratulacje pora na awans!");
                Console.WriteLine("1.Siła\n2.Zręcznosć\n3.Wytrzymałość\n4.Inteligencja\n5.Charyzma");
                for (int i = 0; i < punktyStatystyk;)
                {
                    string wyborStat = Console.ReadLine();
                    switch (wyborStat)
                    {
                        case "1":
                            b.sila++;
                            i++;
                            continue;
                        case "2":
                            b.zrecznosc++;
                            i++;
                            continue;
                        case "3":
                            b.wytrzymalosc++;
                            i++;
                            continue;
                        case "4":
                            b.inteligencja++;
                            i++;
                            continue;
                        case "5":
                            b.charyzma++;
                            i++;
                            continue;
                        default:
                            Console.WriteLine("Wybierz poprawnie");
                            continue;
                    }
                }
                Console.WriteLine("Siła: {0}\nZręczność: {1}\nWytrzymałość: {2}\nInteligencja: {3}\nCharyzma: {4}", b.sila, b.zrecznosc, b.wytrzymalosc, b.inteligencja, b.charyzma);
                Console.WriteLine("1. Zaakceptuj wybór statystyk");
                Console.WriteLine("2. Zrezygnuj");
                string Potwierdzenie = " ";
                while (!(Potwierdzenie == "1") && !(Potwierdzenie == "2"))
                {
                    Potwierdzenie = Console.ReadLine();

                    switch (Potwierdzenie)
                    {
                        case "1":
                            Console.WriteLine("Twój wybór został potwierdzony");
                            b.PD = b.PD - 10;
                            b.PZ = b.wytrzymalosc * 10;
                            break;
                        case "2":
                            Console.WriteLine("Odrzuciłeś swój wybór. Twoje punkty doświadczenia nie zostaną zabrane");
                            b.sila = silaPrzed;
                            b.zrecznosc = zrecznoscPrzed;
                            b.wytrzymalosc = wytrzymaloscPrzed;
                            b.inteligencja = inteligencjaPrzed;
                            b.charyzma = charyzmaPrzed;
                            break;

                        default:
                            Console.WriteLine("Wybierz poprawnie");
                            break;
                    }

                }

            }
            else
            {
                Console.WriteLine("Nie jestes gotowy");
            }
        }
        /// <summary>
        /// Metoda <c>zarzadzajEkwipunkiem</c>, w której gracz poprzez instrukcję <c>switch</c> może wybrać czy chce wyświetlić zawartość ekwipunku, czy też wywołać opisaną poniżej 
        /// metodę odpowiedzialną za wytwarzanie przedmiotów.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        /// <param name="m">Parametr <c>m</c> jest odniesieniem do elementu <c>Miecz</c> z klasy <c>Bohater</c></param>
        /// <param name="z">Parametr <c>z</c> jest odniesieniem do elementu <c>Zbroja</c> z klasy <c>Bohater</c></param>
        /// <param name="h">Parametr <c>h</c> jest odniesieniem do elementu <c>Hełm</c> z klasy <c>Bohater</c></param>
        /// <param name="p">Parametr <c>p</c> jest odniesieniem do elementu <c>Pas</c> z klasy <c>Bohater</c></param>
        public static void zarzadzajEkwipunkiem(Bohater b, Przedmiot m, Przedmiot z, Przedmiot h, Przedmiot p)
        {
            string wyborEkwipunek = " ";
            while (wyborEkwipunek != "3")
            {
                Console.WriteLine("1.Stan ekwipunku\n2.Wytwarzanie przedmiotów\n3.Zakończ");
                wyborEkwipunek = Console.ReadLine();
                switch (wyborEkwipunek)
                {
                    case "1":
                        Console.WriteLine("Stan twojego ekwipunku:\nRuda: {0}\nSkóry: {1}\nKlejnoty: {2}\nZłoto: {3}\nUlepszenie miecza: {4}\nUlepszenie zbroi: {5}\nUlepszenie hełmu: {6}\nUlepszenie pasa: {7}\n", b.ruda, b.skora, b.klejnot, b.zloto, b.postepMiecz, b.postepZbroja, b.postepHelm, b.postepPas);
                        continue;
                    case "2":
                        wytwarzajEkwipunek(b, m, z, h, p);
                        continue;
                    case "3":
                        Console.WriteLine("Wyjście z menu ekwipunku");
                        continue;
                    default:
                        Console.WriteLine("Wybierz poprawną opcję");
                        continue;
                }
            }
            Console.Clear();
        }
        /// <summary>
        /// Metoda<c>wytwarzajEkwipunek</c> dzięki której bohater poprzez zmniejszanie ilości przedmiotów w posiadanym ekwipunku może dokonać ulepszenia ekwipunku. 
        /// Metoda sprawdza czy bohater posiada odpowienią ilość zasobów oraz na jakim poziomie ulepszenia znajduje się dany element wyposażenia.
        /// Jeśli bohater posiada już ulepszone elementy wyposażenia bądź nie posiada odpowiedniej ilości zasobów, to wyświetlany jest komunikat o braku możliwości wykonania ulepszenia.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        /// <param name="m">Parametr <c>m</c> jest odniesieniem do elementu <c>Miecz</c> z klasy <c>Bohater</c></param>
        /// <param name="z">Parametr <c>z</c> jest odniesieniem do elementu <c>Zbroja</c> z klasy <c>Bohater</c></param>
        /// <param name="h">Parametr <c>h</c> jest odniesieniem do elementu <c>Hełm</c> z klasy <c>Bohater</c></param>
        /// <param name="p">Parametr <c>p</c> jest odniesieniem do elementu <c>Pas</c> z klasy <c>Bohater</c></param>
        public static void wytwarzajEkwipunek(Bohater b, Przedmiot m, Przedmiot z, Przedmiot h , Przedmiot p)
        {
            string wyborTworz = " ";
            while (wyborTworz != "5")
            {
                Console.WriteLine("1.Ulepsz miecz\n2.Ulepsz zbroję\n3.Ulepsz hełm\n4.Ulepsz pas\n5.Wyjdź");
                wyborTworz = Console.ReadLine();
                switch (wyborTworz)
                {
                    case "1":
                        if (b.postepMiecz == 0)
                        {
                            if (b.ruda >= 5 && b.skora >= 3 && b.klejnot >= 1)
                            {
                                m.sila = m.sila + 2;
                                m.zrecznosc = m.zrecznosc + 2;
                                m.stan = "ulepszony";
                                b.sila = b.sila + m.sila;
                                b.zrecznosc = b.zrecznosc + m.zrecznosc;            
                                b.ruda = b.ruda - 5;
                                b.skora = b.skora - 3;
                                b.klejnot = b.klejnot - 1;
                                b.postepMiecz++;
                                b.punktacja = b.punktacja + 10;
                                Console.WriteLine("Wykułeś ulepszony miecz !!!");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco materiałów do ulepszenia");
                            }
                        }
                        if (b.postepMiecz == 1)
                        {
                            if (b.ruda >= 10 && b.skora >= 6 && b.klejnot >= 2)
                            {
                                m.sila = m.sila + 4;
                                m.zrecznosc = m.zrecznosc + 4;
                                m.stan = "mistrzowski";
                                b.sila = (b.sila - 2) + m.sila;
                                b.zrecznosc = (b.zrecznosc -2) + m.zrecznosc;
                                b.ruda = b.ruda - 10;
                                b.skora = b.skora - 6;
                                b.klejnot = b.klejnot - 2;
                                b.postepMiecz++;
                                b.punktacja = b.punktacja + 30;
                                Console.WriteLine("Wykułeś magiczny miecz!!!");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco materiałów do ulepszenia");
                            }

                        }
                        if (b.postepMiecz == 2)
                        {
                            Console.WriteLine("Twój miecz jest już maksymalnie ulepszony.");
                        }
                        break;
                    case "2":
                        if (b.postepZbroja == 0)
                        {
                            if (b.ruda >= 5 && b.skora >= 3)
                            {
                                z.wytrzymalosc = z.wytrzymalosc + 3;
                                z.stan = "ulepszony";
                                b.wytrzymalosc = b.wytrzymalosc + z.wytrzymalosc;
                                b.ruda = b.ruda - 5;
                                b.skora = b.skora - 3;
                                b.postepZbroja++;
                                Console.WriteLine("Wykułeś ulepszoną zbroję");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                Console.ReadKey();
                                b.punktacja = b.punktacja + 10;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco materiałów do ulepszenia");
                            }
                        }
                        if (b.postepZbroja == 1)
                        {
                            if (b.ruda >= 15 && b.skora >= 10)
                            {
                                z.zrecznosc = z.zrecznosc + 1;
                                z.wytrzymalosc = z.wytrzymalosc + 6;
                                z.stan = "mistrzowska";
                                b.zrecznosc = b.zrecznosc + z.zrecznosc;
                                b.wytrzymalosc = (b.wytrzymalosc - 3) + z.wytrzymalosc;
                                b.ruda = b.ruda - 15;
                                b.skora = b.skora - 10;
                                b.postepZbroja++;
                                b.punktacja = b.punktacja + 30;
                                Console.WriteLine("Wykułeś magiczną zbroję!!!");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                Console.ReadKey();
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco materiałów do ulepszenia");
                            }

                        }
                        if (b.postepZbroja == 2)
                        {
                            Console.WriteLine("Twój miecz jest już maksymalnie ulepszony.");
                        }
                        break;
                    case "3":
                        if (b.postepHelm == 0)
                        {
                            if (b.ruda >= 5 && b.skora >= 1 && b.klejnot >= 2)
                            {
                                h.wytrzymalosc = h.wytrzymalosc + 2;
                                h.inteligencja = h.inteligencja + 2;
                                h.stan = "ulepszony";
                                b.wytrzymalosc = b.wytrzymalosc + h.wytrzymalosc;
                                b.inteligencja = b.inteligencja + h.inteligencja;
                                b.ruda = b.ruda - 5;
                                b.skora = b.skora - 1;
                                b.klejnot = b.klejnot - 2;
                                b.postepHelm++;
                                b.punktacja = b.punktacja + 10;
                                Console.WriteLine("Wykułeś ulepszony hełm!!!");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                Console.ReadKey();
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco materiałów do ulepszenia");
                            }
                        }
                        if (b.postepHelm == 1)
                        {
                            if (b.ruda >= 10 && b.skora >= 2 && b.klejnot >= 4)
                            {
                                h.wytrzymalosc = h.wytrzymalosc + 6;
                                h.inteligencja = h.inteligencja + 6;
                                h.stan = "mistrzowski";
                                b.wytrzymalosc = (b.wytrzymalosc - 2) + h.wytrzymalosc;
                                b.inteligencja = (b.inteligencja - 2) + h.inteligencja;
                                b.ruda = b.ruda - 10;
                                b.skora = b.skora - 2;
                                b.klejnot = b.klejnot - 4;
                                b.postepHelm++;
                                b.punktacja = b.punktacja + 30;
                                Console.WriteLine("Wykułeś magiczny hełm!!!");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco materiałów do ulepszenia");
                            }

                        }
                        if (b.postepHelm == 2)
                        {
                            Console.WriteLine("Twój miecz jest już maksymalnie ulepszony.");
                        }
                        break;
                    case "4":
                        if (b.postepPas == 0)
                        {
                            if (b.ruda >= 5 && b.skora >= 3)
                            {
                                p.stan = "ulepszony";
                                b.ruda = b.ruda - 20;
                                b.skora = b.skora - 2;
                                b.postepPas++;
                                Console.WriteLine("Zmodyfikowałeś swój pas do dalszych ulepszeń");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                Console.ReadKey();
                                b.punktacja = b.punktacja + 10;
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco materiałów do ulepszenia");
                            }
                        }
                        if (b.postepPas == 1)
                        {
                            if (b.klejnot >= 20)
                            {
                                p.sila = p.sila + 10;
                                p.zrecznosc = p.zrecznosc + 10;
                                p.wytrzymalosc = p.wytrzymalosc + 10;
                                p.inteligencja = p.inteligencja + 10;
                                p.charyzma = p.charyzma + 30;
                                p.stan = "mistrzowski";
                                b.sila = b.sila + p.sila;
                                b.zrecznosc = b.zrecznosc + p.zrecznosc;
                                b.wytrzymalosc = b.wytrzymalosc + p.wytrzymalosc;
                                b.inteligencja = b.inteligencja  + p.inteligencja;
                                b.charyzma = b.charyzma + p.charyzma;
                                b.klejnot = b.klejnot - 20;
                                b.postepPas++;
                                Console.WriteLine("Wykułeś magiczny pas");
                                Console.WriteLine("Naciśnij przycisk, aby kontnyuować");
                                Console.ReadKey();
                                b.punktacja = b.punktacja + 30;
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Nie masz wystarczająco materiałów do ulepszenia");
                            }

                        }
                        if (b.postepPas == 2)
                        {
                            Console.WriteLine("Twój miecz jest już maksymalnie ulepszony.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Wyjście z menu ekwipunku");
                        continue;
                    default:
                        Console.WriteLine("Wybierz poprawną opcję");
                        continue;
                }
            }
            Console.Clear();
        }
        /// <summary>
        /// Metoda <c>nazwijPostać</c> odpowiedzialna za nazwanie bohatera na początku rozgrywki. Sprawdza ona czy imię wprowadzone przez gracza spełnia wymagania. 
        /// Jeśli wymogi dotyczące imienia nie są spełnione, wyświetlany jest komunikat o niepoprawnych znakach. 
        /// </summary>
        /// <param name="imie">Parametr <c>imie</c> używany celem nazwania postaci gracza.</param>
        /// <returns>W przypadku powodzenia metoda zwraca wartość <c>true</c>, w przypadku przeciwnym - <c>false</c>.</returns>
        public bool nazwijPostac(string imie)
        {
                if ((Regex.IsMatch(imie, @"^[a-zA-Z]+$")) == true)
                {
                Console.WriteLine("Poprawne imię");
                nazwa = imie;
                return true;
                }
                else
                {
                Console.WriteLine("Niepoprawne znaki");
                return false;
                }
        }
        /// <summary>
        /// Metoda <c>wyswietlStat</c>, której celem jest wyświetlenie obecnych statystyk posiadanych przez gracza.
        /// </summary>
        /// <param name="b">Parametr <c>b</c> jest odniesieniem do klasy <c>Bohater</c></param>
        public void wyswietlStat(Bohater b)
        {
            Console.WriteLine("Statystyki {0}\nSiła: {1}\nZręczność: {2}\nWytrzymałość: {3}\nInteligencja: {4}\nCharyzma: {5}\nPunkty Życia: {6},\nStatus bohatera: {7}\nPD: {8}", b.nazwa, b.sila, b.zrecznosc, b.wytrzymalosc, b.inteligencja, b.charyzma, b.PZ, b.bohaterStatus, b.PD);
        }
        /// <summary>
        /// Metoda <c>wyswietlPunktacje</c>, wywoływana jest na końcu rozgrywki. Pokazuje ona ile punktów osiągnał gracz na koniec gry. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        /// <param name="punktacja">Parametr <c>punktacja</c> zawiera ilośc punktów, które osiągnął gracz.</param>
        /// <returns>Jeśli punktacja jest większa od 40 do innej metody przekazywana jest wartość <c>true</c>, która odblokowuje sekretne zakończenie. 
        /// W przeciwnym wypadku przekazywane jest <c>false</c>.</returns>
        public bool wyswietlPunktacje(int punktacja)
        { 
        Console.WriteLine("Twoja ilośc punktów na zakończenie przygody: {0}", punktacja);
        if ( punktacja >= 40)
            {
                return true;
            }
        else
            {
                return false;
            }
        
        }
    }
}
