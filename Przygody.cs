using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

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
                        Console.WriteLine("Po wielu księżycach wędrówki docierasz w końcu do osady, o której opowiadali Ci Twoi ziomkowie. 'Tam zaczniesz nowe życie, bez zmartwień o Twoją przeszłość' powiedzieli Ci na odchodne. Wędrowałeś dzień i noc, spałeś w jamach, na drzewach.");
                        Console.WriteLine("Polowałeś na pomniejsze zwierzęta i zbierałeś leśne jagody. Przy bramie osady stajesz obszarpany i zmęczony padasz na twarz. Momentami czujesz jedynie, że ktoś Cię gdzieś ciągnie.");
                        Console.WriteLine("Po pewnym czasie budzisz się. Otacza Cię krąg ludzi. 'Witamy w naszej osadzie' mówi jeden z nich. 'Jestem Kmieciem tej osady i miło Cię tu widzieć.' Odpowiadasz mu jedynie 'Niech Ci bogi darzą', po czym zapadasz w dalszy sen.");
                        Thread.Sleep(5000);
                        Console.WriteLine("\nMija pewien czas. W końcu masz siłę wstać. Dziękując kmieciowi raz jeszcze opuszczasz jego chatę i udajesz się na zwiedzanie osady.\n");
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
                    Console.WriteLine("Idąc przez wioskę zauważasz siedzącą babuszkę. Woła Cię: 'Chodź chłopczyku, opowiem Ci co nie co o naszych przodkach.'");
                    Console.WriteLine("Co robisz? : \n1.Przysiadam się. \n2.Odchodzę dalej");
                    wybor = "";
                    while (!(wybor == "1") && !(wybor == "2"))
                    {
                        wybor = Console.ReadLine();
                        switch (wybor)
                        {
                            case "1":
                                Console.WriteLine("'O dobrze, dobrze żeś tu przylazł. Słyszał Ty kiedy opowieść o Lechu, Czechu i Rusie? Nie? No to siadaj, siadaj, już Ci opowiadam!'");
                                Console.WriteLine("Dawno temu żyli sobie trzej bracia: Lech, Czech i Rus, którzy mieszkali w ogromnej puszczy. Nad osadą swą opiekę roztaczało bóstwo, które mieszkańcy nazywali Światowidem. Będąc dziećmi, każdy z braci miał sen o koniach. Zdaniem kapłana oznaczało to, że kiedy dorosną, każdy z nich dostanie wierzchowca. Tak istotnie się stało. Bracia odebrawszy swego konia, wyruszyli na poszukiwania Światowida. Mieli dla niego specjalny dar – białego konia, który miał następnie dostać się w ręce kapłanów Północnego Grodu. Braciom udało się szczęśliwie przekazać białego konia, a w zamian otrzymali od kapłanów trzy topory i trzy mieszki z tajnym znakiem. W miechu Lecha znajdowało się białe pióro. Dziwnym trafem takie samo piórko leżało na polanie pod dębem. Wojownik uznał to za pomyślny znak i właśnie w tym miejscu założył swój gród, który nazwał Gniezno.");
                                Console.WriteLine("Za wysłuchanie opowieści otrzymujesz puntky doświadczenia");
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
                    wybor = "";
                }

                if (wybierzPrzygode[los] == 1)
                {
                    Console.WriteLine("Zawędrowałeś do lasu. Dookoła otaczają Cię drzewa, ptaki śpiewają, cykady cykają. Ale zaraz, to nie brzmi jak cykada! Nagle z za krzaka wyskakuje i atakuje Cię Bożątko! Rozpoczyna się walka.");
                    Przeciwnik Bożątko = new Przeciwnik("Bożątko", 1, 2, 2, 10, 15);
                    Walka.Pojedynek(b, Bożątko);
                    Console.WriteLine("Bożątko padło. Postanawiasz usiąść na pobliskim pniu. Podchodzisz do niego i w oczy razi Cię blask. Za pniem znajduje się skrzynia z błyszczącymi okuciami. Znalazłeś skarb Bożątka!");
                    b.klejnot = b.klejnot + 10;
                    b.zloto = b.zloto + 20;
                    b.skora = b.skora + 5;
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
                                if (b.charyzma > 12)
                                {
                                    Console.WriteLine("'Kici, kici, kici, chodź koteczku do mnie, kici, kici, kici, no chodź kiciusiu.' Kot słysząc Twoje słowa schodzi powoli z drzewa, po czym zaczyna się łasić do Twoich nóg.");
                                    Console.WriteLine("W podziękowaniu za uratowanie kota otrzymujesz exp a dziewczynka daje Ci klejnot");
                                    b.klejnot++;
                                    b.PD = b.PD + 10;
                                }
                                else
                                {
                                    Console.WriteLine("Wspinasz się na drzewo. Powoli o ostrożnie stawiasz kolejne kroki. Nagle gałąź się pod Tobą załamuje, ale na szczęście udało Ci się złapać.");
                                    Console.WriteLine("Na dźwięk łamanej gałęzi, przerażony kot zeskakuje z drzewa wprost w ramiona dziewczynki. Uradowana dziewczynka w podziękowaniu za wykonane zadanie podarowuje Ci jeden kryształ.");
                                    b.klejnot++;
                                }
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
                    wybor = "";
                }
                if (wybierzPrzygode[los] == 3)
                {
                    Console.WriteLine("Przechadzając się wieczorem przez wioskę, słyszysz dziecięce krzyki. Zaciekawiony tym podbiegłeś do chaty, z której dobiegały. 'Ratunku, pomocy, pod łóżkiem mojego dziecka siedzi Bobo!' woła kobieta, z progu domu. Na Twój widok, Bobo wyskakuje spod łóżka i zaczyna się walka.");
                    Przeciwnik Bobo = new Przeciwnik("Bobo", 1, 1, 3, 10, 10);
                    Walka.Pojedynek(b, Bobo);
                    Console.WriteLine("Dziękuję Ci, dziękuję! Uratowałeś moje dziecko i mnie. Nie mogę Ci za wiele ofiarować, mam jedynie stary kufer po moim mężu kupcu, którego wciąż nie udało mi się otworzyć. Proszę weź!");
                    Console.WriteLine("Wewnątrz skrzyni znajdujesz kilka skór oraz parę klejnotów");
                    b.skora = b.skora + 5;
                    b.klejnot = b.klejnot + 10;
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 4)
                {
                    Console.WriteLine("Przy polanie na skraju lasu, dzieci wypasają owce. Owce skubią trawę, dzieci w coś się bawią. Wtem zwierzęta się rozbiegają, a dzieci zaczynają krzyczeć. Okazuje się, że owce zaatakował Jaroszek. Rozpoczyna się walka!");
                    Przeciwnik Jaroszek = new Przeciwnik("Jaroszek", 3, 2, 2, 10, 15);
                    Walka.Pojedynek(b, Jaroszek);
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
                    wybor = "";
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
                            case "1":
                                if (b.sila > 12)
                                {
                                    Console.WriteLine("Podchodzisz do wozu, nie zwracając uwagi na to, co mówi chłop. Zapierasz się nogami o ziemię i starasz się wypchać wóz. Po chwili udaje Ci się to zrobić. 'No, jak że ja bym miał takiego syna to bym miał, to bym złoty dwór miał już tu na Ziemii.'");
                                    Console.WriteLine("W podziękowaniu chłop daje Ci parę skór i bierwono.");
                                    b.bierwiono++;
                                    b.skora = b.skora + 10;
                                }
                                else
                                {
                                    Console.WriteLine("'No, to ja poganiam wołu i pchamy razem'. Chłop strzelił z bicza i zaczęliście pchać wóz. Po dłuższej chwili i kilku upadkach w końcu udało się wypchać wóz. 'Nooo, niech Ci się darzy! Niech bogi mają Cię w swojej opiece.'");
                                    Console.WriteLine("Za pomoc w pchaniu wozu otrzymujesz bierwiono oraz punkty doświadczenia.");//Bohater.klejnot = Bohater.klejnot + 1;
                                    b.PD = b.PD + 10;
                                    b.bierwiono++;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Udajesz, że nie zauważasz chłopa i idziesz w swoją stronę.");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    licznikPrzygod++;
                    wybor = "";
                }
                if (wybierzPrzygode[los] == 7)
                {
                    Console.WriteLine("Zapadła noc. Przechadzając się nad jeziorem słyszysz piękny śpiew i muzykę graną na gęślach. Zaciekawiony tym, zbliżasz się do zarośli. Wtem Twoim oczom ukazuje się Wiła. Natychmiastowo pochylasz głowę, byleby nie spojżeć jej w oczy i zaczynasz walkę!");
                    Przeciwnik Wiła = new Przeciwnik("Wiła", 3, 4, 5, 15, 20);
                    Walka.Pojedynek(b, Wiła);
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 8)
                {
                    Console.WriteLine("W poszukiwaniu dalszych przygód udałeś się do małej wioski pod lasem. Jednak zdaje się, że nikogo w niej nie ma. Wtem z jednej z chat wychodzi kobieta i mówi 'Uciekaj jeśli Ci życie miłe! Zostaliśmy zaatakowani przez Licho i wszyscy zachorowaliśmy'. Postanawiasz rozprawić się z potworem.");
                    Przeciwnik Licho = new Przeciwnik("Licho", 4, 2, 5, 20, 15);
                    Walka.Pojedynek(b, Licho);
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 9)
                {
                    Console.WriteLine("W poszukiwaniu ziół udajesz się na bagna. Miejscowi chłopi ostrzegają Cię jednak, że na bagnach spotkać można okropnego stwora, lecz jeśli go pokonasz i przyniesiesz jego śluz, dostaniesz sporo pieniędzy od miejscowej zielarki. Będąc już blisko moczar, zauważasz bulgocącą wodę, z której zaczyna coś wypełzać. Czas na walkę. ");
                    Przeciwnik Bagiennik = new Przeciwnik("Bagiennik", 3, 2, 7, 30, 10);
                    Walka.Pojedynek(b, Bagiennik);
                    licznikPrzygod++;
                }
            }
            if (licznikPrzygod >= 6 && licznikPrzygod<9)
            {
                if (wybierzPrzygode[los] == 10)
                {
                    Console.WriteLine("Idąc przez wioskę zauważasz siedzącą babuszkę. Woła Cię: 'Chodź chłopczyku, opowiem Ci co nie co o naszych przodkach.'");
                    Console.WriteLine("Co robisz? : \n1.Przysiadam się. \n2.Odchodzę dalej");
                    wybor = "";
                    while (!(wybor == "1") && !(wybor == "2"))
                    {
                        wybor = Console.ReadLine();
                        switch (wybor)
                        {
                            case "1"://Sielawowy Król
                                Console.WriteLine("'O dobrze, dobrze żeś tu przylazł. Słyszał Ty kiedy opowieść o Sielawowym Królu? Nie? No to siadaj, siadaj, już Ci opowiadam!'");
                                Console.WriteLine("Wiele lat temu, w naszej wiosce mieszkał rybak z dziećmi - synem Mikołajkiem i najpiękniejszą w okolicy córką Złotką. Któregoś dnia rybacy zauważyli, że wszyskie ryby, które łowią są martwe. Rybacy myśleli, że to sprawka złej siły - Króla Sielaw - będącego wielką rybą. Ojciec Mikołajka wyjaśnił mu, że zdarza się to raz na sto lat, bowiem Król jest żądny ofiary w postaci najpiękniejszej dziewczyny w wiosce. Mikołajek chcąc uratować swoją siostrę wpadł na pomysł aby ją ocalić. Przebrał się w dziewczęce szaty, po czym przywołał Króla Sielaw. Obiecał mu koronę, jeśli tylko wypłynie na brzeg. Gdy ryba wypłynęła, rybacy ją przechwycili i uwięzli. Dzięki temu już żadna dziewczyna nie musiała już być poświęcana. ");
                                Console.WriteLine("Za wysłuchanie opowieści otrzymujesz punkty doświadczenia");
                                b.PD = b.PD + 10;
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
                    wybor = "";
                }
                if (wybierzPrzygode[los] == 11)
                {
                    Console.WriteLine("Wieczorem odwiedzasz Kmiecia z nadzieją, że pomoże Ci w znalezieniu roboty. Kmieć przyjmuje Cię z gościnnością. Gdy nastała północ, na zewnątrz słychać jakieś odgłosy. Wybiegacie z chaty i okazuje się, że spod płotu coś wychodzi. To Poroniec! 'Miał jako dobry duch strzec domostwa' mówi zapłakany Kmieć. Rozpoczyna się walka");
                    Przeciwnik Poroniec = new Przeciwnik("Poroniec", 8, 5, 5, 30, 35);
                    Walka.Pojedynek(b, Poroniec);
                    Console.WriteLine("'Do tej pory nic się nie działo. Widocznie pełnia księżyca tak na niego zadziałała.' mówi już spokojny Kmieć. W podziękowaniu za Twoją pomoc otrzymujesz kilka skór.");
                    b.skora = b.skora + 10;
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 12)
                {
                    Console.WriteLine("Podczas rozmów w gospodzie, usłyszałeś opowieść dwóch chłopów. Opowiadali oni o skarbie ukrytym pod starą wierzbą nad rzeką. Udajesz się tam wieczorem. Po chwili poszukiwań znajdujesz opisywaną przez chłopów wierzbę. Wtem z wody, powolnym krokiem wyskakuje Utopiec. Rozpoczyna się walka!");//dokończyć
                    Przeciwnik Utopiec = new Przeciwnik("Utopiec", 7, 8, 5, 35, 30);
                    Walka.Pojedynek(b, Utopiec);
                    Console.WriteLine("Gdy w końcu udało Ci się pokonać Utopca, zabierasz się za otwieranie skrzyni. Skrzynia okazała się być pusta.");
                    Console.WriteLine("Otrzymujesz punkty doświadczenia.");
                    b.PD = b.PD + 15;
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 13)
                {
                    Console.WriteLine("W wiosce niedawno odbyła się egzekucja. Rzezimieszka, z obawy że mogą nim rządzić siły nieczyste, pochowano za wioską. Jednakże on powrócił pod postacią Strzygonia. I postanowił się zemścić. Niestety pierwszą napotkaną osobą jesteś Ty. Rozpoczyna się walka!");
                    Przeciwnik Strzyga = new Przeciwnik("Strzygoń", 5, 5, 8, 30, 35);
                    Walka.Pojedynek(b, Strzyga);
                    Console.WriteLine("Z truchła Strzygonia wypada kilka klejnotów i rud.");
                    b.klejnot = b.klejnot + 5;
                    b.ruda = b.ruda + 10;
                    licznikPrzygod++;
                }
                if (wybierzPrzygode[los] == 14)
                {
                    Console.WriteLine("Miejscowi chłopi opowiedzieli Ci legendę o ukrytym w okolicznej grocie skarbie, którego strzeże Mamuna. Zaintrygowany tematem postanawiasz udać się do tej groty. Po dłuższym zwiedzaniu znajdujesz kufer pełen złota, klejnotów i rudy. Wtem jednak Twoja pochodnia gaśnie. Słyszysz tylko przerażający śmiech Mamuny. Rozpoczyna się walka!");
                    Przeciwnik Mamuna = new Przeciwnik("Mamuna", 8, 5, 5, 35, 30);
                    Walka.Pojedynek(b, Mamuna);
                    Console.WriteLine("Po pokonaniu potwora udaje Ci się uciec ze skarbem.");
                    b.klejnot = b.klejnot + 15;
                    b.ruda = b.ruda +10;
                    b.zloto = b.zloto + 20;
                    licznikPrzygod++;
                }

            }
            if(licznikPrzygod == 9)
            {
                Console.WriteLine("WALKA Z BOSSEM!!!111!!11!!3@!@!!!");
                    /*
                    Przeciwnik Bożątko = new Przeciwnik("Bożątko", 5, 5, 5, 5, 5);
                    Walka.Pojedynek(b, Bożątko);
                    */
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
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    number = rand.Next(0, 5);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number);
            }
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    number = rand.Next(5, 10);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number);
            }
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    number = rand.Next(10, 15);
                } while (wybierzPrzygode.Contains(number));
                wybierzPrzygode.Add(number); 
            }
        }
    }
}
