using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Przygody
    {
        private static int licznikPrzygod = 0;
        public static List<int> wybierzPrzygode = new List<int>();
        public static int los = 0;
        public static void Poczatek(Bohater b)
        {
            Bohater.nazwijPostac(b);
            Console.WriteLine("Pominąć prolog?\n1.Nie\n2.Tak");
            string wybierzProlog = "";
            while(!(wybierzProlog == "1")&& !(wybierzProlog=="2"))
            {
                wybierzProlog = Console.ReadLine();
                switch (wybierzProlog)
                {
                    case "1":
                        Console.WriteLine("TUTAJ MA BYĆ WSTĘP");
                        break;
                    case "2":
                        Console.WriteLine("Wstęp został pominięty");
                        break;
                    default:
                        Console.WriteLine("Niepoprawny znak");
                        continue;
                }
            }
            Gildia.wyborGildii();
        }
        public static void Zdarzenia(Bohater b)
        {
            string wybor = "";
           if(licznikPrzygod < 5)
            {
                
                if (wybierzPrzygode[los] == 0)
                {
                    Console.WriteLine("Idąc przez wioskę zauważasz siedzącą babuszkę. Woła Cię: 'Choć chłopczyku, opowiem Ci co nie co o naszych przodkach.'");
                    Console.WriteLine("Co robisz? : \n1.Przysiadam się. \n2. Odchodzę dalej");
                    wybor = "";
                    while (!(wybor == "1") && !(wybor == "2"))
                    {
                        wybor = Console.ReadLine();
                        switch (wybor)
                        {
                            case "1":
                                Console.WriteLine("'O dobrze, dobrze żeś tu przylazł. Słyszał Ty kiedy opowieść o Lechu, Czechu i Rusie? Nie? No to siadaj, siadaj, już Ci opowiadam!'");
                                Console.WriteLine("Dawno temu żyli sobie trzej bracia: Lech, Czech i Rus, którzy mieszkali w ogromnej puszczy. Nad osadą swą opiekę roztaczało bóstwo, które mieszkańcy nazywali Światowidem. Będąc dziećmi, każdy z braci miał sen o koniach. Zdaniem kapłana oznaczało to, że kiedy dorosną, każdy z nich dostanie wierzchowca. Tak istotnie się stało. Bracia odebrawszy swego konia, wyruszyli na poszukiwania Światowida. Mieli dla niego specjalny dar – białego konia, który miał następnie dostać się w ręce kapłanów Północnego Grodu. Braciom udało się szczęśliwie przekazać białego konia, a w zamian otrzymali od kapłanów trzy topory i trzy mieszki z tajnym znakiem. W miechu Lecha znajdowało się białe pióro. Dziwnym trafem takie samo piórko leżało na polanie pod dębem. Wojownik uznał to za pomyślny znak i właśnie w tym miejscu założył swój gród, który nazwał Gniezno.");
                                Console.WriteLine("\nZa wysłuchanie opowieści otrzymujesz puntky doświadczenia");//Bohater.klejnot = Bohater.klejnot + 1;
                                break;
                            case "2":
                                Console.WriteLine("Całkowicie ignorujesz babuszkę i idziesz w swoją stronę.");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    licznikPrzygod++;
                }

                if (wybierzPrzygode[los] == 1)
                {
                    Console.WriteLine("Zawędrowałeś do lasu. Dookoła otaczają Cię drzewa, ptaki śpiewają, cykady cykają. Ale zaraz, to nie brzmi jak cykada! Nagle z za krzaka wyskakuje i atakuje Cię Bożątko! Rozpoczyna się walka.");
                    //Walka.Pojedynek();
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 2)
                {
                    Console.WriteLine("Z oddali słyszysz, że ktoś płacze. Idąc za źródłem dźwięku, zauważasz dziewczynkę pod drzewem. Podchodzisz, a wtedy dziewczynka zauważa Cię i chowa się za drzewo.");
                    Console.WriteLine("Mówisz do niej spokojnym głosem: 'Co się stało? Dlaczego płaczesz?' Dziewczynka odpowiada Ci, że na drzewo wszedł kot i nie może zejść. Po chwili pyta się Ciebie, czy nie mógłbyś jej pomóc.");
                    Console.WriteLine("Co robisz? :\n1.Pomagam jej. \n2.Odchodzę");
                    while (!(wybor == "1") && !(wybor == "2"))
                    {
                        wybor = Console.ReadLine();
                        switch (wybor)
                        {
                            case "1":
                                Console.WriteLine("Wspinasz się na drzewo. Powoli o ostrożnie stawiasz kolejne kroki. Nagle gałąź się pod Tobą załamuje, ale na szczęście udało Ci się złapać.");
                                Console.WriteLine("Na dźwięk łamanej gałęzi, przerażony kot zeskakuje z drzewa wprost w ramiona dziewczynki. Uradowana dziewczynka w podziękowaniu za wykonane zadanie podarowuje Ci jeden kryształ.");
                                b.klejnot++;
                                break;
                            case "2":
                                Console.WriteLine("Mówisz: 'Niestety, nie mogę Ci pomóc. To za wysoko. Miejmy nadzieję, że kotek sam zejdzie z drzewa.', po czym odchodzisz dalej.");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 3)
                {
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 4)
                {
                    licznikPrzygod++;
                }

            }
            if (licznikPrzygod >=3 && licznikPrzygod < 6)
            {
                if (wybierzPrzygode[los] == 5)
                {
                    Console.WriteLine("Zauważasz, że ludzie zaczynają się schodzić na środek wioski. Zaciekawiony tym, podążasz za nimi. Okazuje się, że ma zostać stracony lokalny rzezimieszek.");//egzekucja
                    Console.WriteLine("Co robisz? : \n1.Idę zobaczyć co się dzieje. \n2. Odchodzę dalej");
                    wybor = "";
                    while (!(wybor == "1") && !(wybor == "2"))
                    {
                        wybor = Console.ReadLine();
                        switch (wybor)
                        {
                            case "1":
                                Console.WriteLine("Tu opis egzekucji");
                                if (b.zloto >= 10)
                                {
                                    b.zloto = b.zloto - 10;
                                    Console.WriteLine("\nOdchodząc z placu czujesz się odrobinę lżejszy. Aż za lżejszy! Okazało się, że gdy Ty oglądałeś egzekucję, to ktoś ukradł Ci część złota");
                                }
                                else
                                {
                                    b.zloto = 0;
                                    Console.WriteLine("Ukradziono ci całe twoje złoto");
                                }
                                break;
                            case "2":
                                Console.WriteLine("'Nie interesują mnie takie wydarzenia.'- mówisz sam do siebie i idziesz dalej.");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 6)
                {
                    Console.WriteLine("Podczas swej wędrówki, zblżyłeś się na skraj lasu. Zauważasz chłopa z wozem drewna, który utknął w błocie. Chłop woła 'Ej Ty! Pomógłbyś, a nie patrzył się jak chłop w Mamunę'!");
                    Console.WriteLine("Co robisz? : \n1.Idę pomóc. \n2. Odchodzę dalej");
                    wybor = "";
                    while (!(wybor == "1") && !(wybor == "2"))
                    {
                        wybor = Console.ReadLine();
                        switch (wybor)
                        {
                            case "1"://
                                Console.WriteLine("'No, to ja poganiam wołu i pchamy razem'. Chłop strzelił z bicza i zaczęliście pchać wóz. Po dłuższej chwili i kilku upadkach w końcu udało się wypchać wóz. 'Nooo, niech Ci się darzy! Niech bogi mają Cię w swojej opiece'");
                                Console.WriteLine("\nZa pomoc w pchaniu wozu otrzymujesz bierwiono bądź exp");//Bohater.klejnot = Bohater.klejnot + 1;
                                break;
                            case "2":
                                Console.WriteLine("Całkowicie ignorujesz babuszkę i idziesz w swoją stronę.");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 7)
                {
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 8)
                {
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 9)
                {
                    licznikPrzygod++;
                }
            }
            if (licznikPrzygod >= 6 && licznikPrzygod<9)
            {
                if (wybierzPrzygode[los] == 10)
                {
                    Console.WriteLine("Idąc przez wioskę zauważasz siedzącą babuszkę. Woła Cię: 'Choć chłopczyku, opowiem Ci co nie co o naszych przodkach.'");
                    Console.WriteLine("Co robisz? : \n1.Przysiadam się. \n2. Odchodzę dalej");
                    wybor = "";
                    while (!(wybor == "1") && !(wybor == "2"))
                    {
                        wybor = Console.ReadLine();
                        switch (wybor)
                        {
                            case "1"://Sielawowy Król
                                Console.WriteLine("'O dobrze, dobrze żeś tu przylazł. Słyszał Ty kiedy opowieść o Sielawowym Królu? Nie? No to siadaj, siadaj, już Ci opowiadam!'");
                                Console.WriteLine("Wiele lat temu, w naszej wiosce mieszkał rybak z dziećmi - synem Mikołajkiem i najpiękniejszą w okolicy córką Złotką. Któregoś dnia rybacy zauważyli, że wszyskie ryby, które łowią są martwe. Rybacy myśleli, że to sprawka złej siły - Króla Sielaw - będącego wielką rybą. Ojciec Mikołajka wyjaśnił mu, że zdarza się to raz na sto lat, bowiem Król jest żądny ofiary w postaci najpiękniejszej dziewczyny w wiosce. Mikołajek chcąc uratować swoją siostrę wpadł na pomysł aby ją ocalić. Przebrał się w dziewczęce szaty, po czym przywołał Króla Sielaw. Obiecał mu koronę, jeśli tylko wypłynie na brzeg. Gdy ryba wypłynęła, rybacy ją przechwycili i uwięzli. Dzięki temu już żadna dziewczyna nie musiała już być poświęcana. ");
                                Console.WriteLine("\nZa wysłuchanie opowieści otrzymujesz puntky doświadczenia");//Bohater.klejnot = Bohater.klejnot + 1;
                                break;
                            case "2":
                                Console.WriteLine("Całkowicie ignorujesz babuszkę i idziesz w swoją stronę.");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 11)
                {
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 12)
                {
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 13)
                {
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 14)
                {
                    licznikPrzygod++;
                }

            }
            if(licznikPrzygod == 9)
            {
                Console.WriteLine("WALKA Z BOSSEM!!!111!!11!!3@!@!!!");
                licznikPrzygod++;
            }
            if(licznikPrzygod == 10)
            {
                Console.WriteLine("EPILOG");
                //Wstawić staty etc
                Environment.Exit(0);
            }
        }
        public static void losujPrzygody()
        {
            Random rand = new Random();
            int number;
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    number = rand.Next(0, 10);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number);
            }
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    number = rand.Next(10, 20);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number);
            }
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    number = rand.Next(20, 30);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number); 
            }
        }
    }
}
