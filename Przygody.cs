using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Gra
{
    /// <summary>
    /// Klasa <c>Przygody</c> w której zapisana jest metoda ze zdarzeniami, które czekają na gracza. 
    /// Jest w niej również metoda ze wstępem do świata gry oraz metoda odpowiedzialna za losowanie przygód. 
    /// </summary>
    class Przygody
    {
        public static int licznikPrzygod = 0;
        public static List<int> wybierzPrzygode = new List<int>();
        private static bool wskazowska = false;
        public static int los = 0;
        /// <summary>
        /// Metoda <c>Początek</c> w której za pomocą instrukcji <c>switch</c> gracz może zdecydować czy chce ominąć prolog do przygody. 
        /// Po przeczytaniu bądź pominięciu prologu wywoływana jest metoda odpowiedzialna za wybór gildii.
        /// </summary>
        public static void Poczatek()
        {
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
                        Console.WriteLine("Po pewnym czasie budzisz się. Otacza Cię krąg ludzi. 'Witamy w naszej osadzie' mówi jeden z nich. 'Jestem Mieszko, kmieć tej osady i miło Cię tu widzieć. Jak zbierzesz siły odwiedź mnie!' Odpowiadasz mu jedynie 'Niech Ci bogi darzą', po czym zapadasz w dalszy sen.");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nMija pewien czas. W końcu masz siłę wstać. Dziękujesz raz jeszcze mieszkańcom chaty za przyjęcie i udajesz się na zwiedzanie osady.\n");
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
        /// <summary>
        /// Metoda <c>Zdarzenia</c> zawierająca zaplanowane dla gracza zdarzenia podczas rozgrywki. Wybór zdarzeń odbywa się przy użyciu opisanej niżej metody <c>losujPrzygody</c>.
        /// W zależnosci od wartości zmiennej <c>licznikPrzygod</c> wywoływane są zdarzenia z innego etapu rozgrywki. Gdy <c>licznikPrzygod</c> wskaże 9 wywoływana jest walka z tzw. Bossem - najtrudniejszym przeciwnikiem w rozgrywce. Natomiast gdy <c>licznikPrzygod</c> wskaże wartość 10 graczowi ukazuje się zakończenie. 
        /// W grze zaplanowano sekretną walkę z Bossem oraz sekretne zakończenie. Jeśli gracz podczas rozgrywki znajdzie sekret zostaje ono wywołane zamiast standardowego. 
        /// W standardowym zakończeniu jeśli gracz osiągnie mniej niż 40 punktów na zakończenie przygody wyświetlany jest mu komunikat o istniejącym sekrecie, którego nie odblokował. 
        /// </summary>
        /// <param name="b">Parametr <c>b</c> służy do przesłania do funkcji obiektu klasy<c>Bohater</c>.</param>
        public static void Zdarzenia(Bohater b)
        {
           string wybor = "";
           if(licznikPrzygod < 3)
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
                    wybor = "";
                    Console.ReadKey();
                    Console.Clear();
                }

                if (wybierzPrzygode[los] == 1)
                {
                    Console.WriteLine("Zawędrowałeś do lasu. Dookoła otaczają Cię drzewa, ptaki śpiewają, cykady cykają. Ale zaraz, to nie brzmi jak cykada! Nagle z za krzaka wyskakuje i atakuje Cię Bożątko! Rozpoczyna się walka.");
                    Przeciwnik Bozatko = new Przeciwnik("Bożątko", 1, 2, 2, 10, 15);
                    Walka.Pojedynek(b, Bozatko);
                    Console.WriteLine("Bożątko padło. Postanawiasz usiąść na pobliskim pniu. Podchodzisz do niego i w oczy razi Cię blask. Za pniem znajduje się skrzynia z błyszczącymi okuciami. Znalazłeś skarb Bożątka!");
                    Console.WriteLine("Otrzymujesz: 10 klejnotów, 20 sztuk złota oraz 5 skór");
                    b.klejnot = b.klejnot + 10;
                    b.zloto = b.zloto + 20;
                    b.skora = b.skora + 5;
                    Console.ReadKey();
                    Console.Clear();
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
                                if (b.charyzma > 3)
                                {
                                    Console.WriteLine("'Kici, kici, kici, chodź koteczku do mnie, kici, kici, kici, no chodź kiciusiu.' Kot słysząc Twoje słowa schodzi powoli z drzewa, po czym zaczyna się łasić do Twoich nóg.");
                                    Console.WriteLine("W podziękowaniu za uratowanie kota otrzymujesz exp a dziewczynka daje Ci klejnot\n");
                                    Console.WriteLine("Otrzymałeś 1 klejnot oraz 10 punktów doświadczneia");
                                    b.klejnot++;
                                    b.PD = b.PD + 10;
                                }
                                else
                                {
                                    Console.WriteLine("Wspinasz się na drzewo. Powoli o ostrożnie stawiasz kolejne kroki. Nagle gałąź się pod Tobą załamuje, ale na szczęście udało Ci się złapać.");
                                    Console.WriteLine("Na dźwięk łamanej gałęzi, przerażony kot zeskakuje z drzewa wprost w ramiona dziewczynki. Uradowana dziewczynka w podziękowaniu za wykonane zadanie podarowuje Ci jeden kryształ.\n");
                                    Console.WriteLine("Otrzymałeś jeden klejnot.");
                                    b.klejnot++;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Mówisz: 'Niestety, nie mogę Ci pomóc. To za wysoko. Miejmy nadzieję, że kotek sam zejdzie z drzewa.', po czym odchodzisz dalej.\n");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                        
                    }
                    wybor = "";
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 3)
                {
                    Console.WriteLine("Przechadzając się wieczorem przez wioskę, słyszysz dziecięce krzyki. Zaciekawiony tym podbiegłeś do chaty, z której dobiegały. 'Ratunku, pomocy, pod łóżkiem mojego dziecka siedzi Bobo!' woła kobieta, z progu domu. Na Twój widok, Bobo wyskakuje spod łóżka i zaczyna się walka.");
                    Przeciwnik Bobo = new Przeciwnik("Bobo", 1, 1, 3, 10, 10);
                    Walka.Pojedynek(b, Bobo);
                    Console.WriteLine("Dziękuję Ci, dziękuję! Uratowałeś moje dziecko i mnie. Nie mogę Ci za wiele ofiarować, mam jedynie stary kufer po moim mężu kupcu, którego wciąż nie udało mi się otworzyć. Proszę weź!");
                    Console.WriteLine("Wewnątrz skrzyni znajdujesz 5 skór oraz 10 klejnotów\n");
                    b.skora = b.skora + 5;
                    b.klejnot = b.klejnot + 10;
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 4)
                {
                    Console.WriteLine("Przy polanie na skraju lasu, dzieci wypasają owce. Owce skubią trawę, dzieci w coś się bawią. Wtem zwierzęta się rozbiegają, a dzieci zaczynają krzyczeć. Okazuje się, że owce zaatakował Jaroszek. Rozpoczyna się walka!");
                    Przeciwnik Jaroszek = new Przeciwnik("Jaroszek", 3, 2, 2, 10, 15);
                    Walka.Pojedynek(b, Jaroszek);
                    Console.ReadKey();
                    Console.Clear();
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
                                Console.WriteLine("Dla wielu to widowisko było szybkie i niewarte uwagi. Jednakże Ciebie bardzo zainteresowało. Zainteresowało Cię tak bardzo, że nie zauważyłeś kiedy...");
                                if (b.zloto >= 10)
                                {
                                    b.zloto = b.zloto - 10;
                                    Console.WriteLine("ktoś ukradł Ci część złota\n");
                                }
                                else
                                {
                                    b.zloto = 0;
                                    Console.WriteLine("ukradziono Ci całe twoje złoto\n");
                                }
                                break;
                            case "2":
                                Console.WriteLine("'Nie interesują mnie takie wydarzenia.'- mówisz sam do siebie i idziesz dalej.\n");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    wybor = "";
                    Console.ReadKey();
                    Console.Clear();
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
                                if (b.sila > 5)
                                {
                                    Console.WriteLine("Podchodzisz do wozu, nie zwracając uwagi na to, co mówi chłop. Zapierasz się nogami o ziemię i starasz się wypchać wóz. Po chwili udaje Ci się to zrobić. 'No, jak że ja bym miał takiego syna to bym miał, to bym złoty dwór miał już tu na Ziemii.'");
                                    Console.WriteLine("W podziękowaniu chłop daje Ci 10 skór, bierwono oraz otrzymujesz 10 punktow doświadczenia.\n");
                                    b.bierwiono++;
                                    b.skora = b.skora + 10;
                                    b.PD = b.PD + 10;
                                }
                                else
                                {
                                    Console.WriteLine("'No, to ja poganiam wołu i pchamy razem'. Chłop strzelił z bicza i zaczęliście pchać wóz. Po dłuższej chwili i kilku upadkach w końcu udało się wypchać wóz. 'Nooo, niech Ci się darzy! Niech bogi mają Cię w swojej opiece.'");
                                    Console.WriteLine("Za pomoc w pchaniu wozu otrzymujesz bierwiono oraz  10 punktów doświadczenia.\n");
                                    b.PD = b.PD + 10;
                                    b.bierwiono++;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Udajesz, że nie zauważasz chłopa i idziesz w swoją stronę.\n");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    wybor = "";
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 7)
                {
                    Console.WriteLine("Zapadła noc. Przechadzając się nad jeziorem słyszysz piękny śpiew i muzykę graną na gęślach. Zaciekawiony tym, zbliżasz się do zarośli. Wtem Twoim oczom ukazuje się Wiła. Natychmiastowo pochylasz głowę, byleby nie spojżeć jej w oczy i zaczynasz walkę!");
                    Przeciwnik Wiła = new Przeciwnik("Wiła", 3, 4, 5, 15, 20);
                    Walka.Pojedynek(b, Wiła);
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 8)
                {
                    Console.WriteLine("W poszukiwaniu dalszych przygód udałeś się do małej wioski pod lasem. Jednak zdaje się, że nikogo w niej nie ma. Wtem z jednej z chat wychodzi kobieta i mówi 'Uciekaj jeśli Ci życie miłe! Zostaliśmy zaatakowani przez Licho i wszyscy zachorowaliśmy'. Postanawiasz rozprawić się z potworem.");
                    Przeciwnik Licho = new Przeciwnik("Licho", 4, 2, 5, 20, 15);
                    Walka.Pojedynek(b, Licho);
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 9)
                {
                    Console.WriteLine("W poszukiwaniu ziół udajesz się na bagna. Miejscowi chłopi ostrzegają Cię jednak, że na bagnach spotkać można okropnego stwora, lecz jeśli go pokonasz i przyniesiesz jego śluz, dostaniesz sporo pieniędzy od miejscowej zielarki. Będąc już blisko moczar, zauważasz bulgocącą wodę, z której zaczyna coś wypełzać. Czas na walkę. ");
                    Przeciwnik Bagiennik = new Przeciwnik("Bagiennik", 3, 2, 7, 30, 10);
                    Walka.Pojedynek(b, Bagiennik);
                    Console.ReadKey();
                    Console.Clear();
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
                            case "1":
                                Console.WriteLine("'O dobrze, dobrze żeś tu przylazł. Słyszał Ty kiedy opowieść o Sielawowym Królu? Nie? No to siadaj, siadaj, już Ci opowiadam!'");
                                Console.WriteLine("Wiele lat temu, w naszej wiosce mieszkał rybak z dziećmi - synem Mikołajkiem i najpiękniejszą w okolicy córką Złotką. Któregoś dnia rybacy zauważyli, że wszyskie ryby, które łowią są martwe. Rybacy myśleli, że to sprawka złej siły - Króla Sielaw - będącego wielką rybą. Ojciec Mikołajka wyjaśnił mu, że zdarza się to raz na sto lat, bowiem Król jest żądny ofiary w postaci najpiękniejszej dziewczyny w wiosce. Mikołajek chcąc uratować swoją siostrę wpadł na pomysł aby ją ocalić. Przebrał się w dziewczęce szaty, po czym przywołał Króla Sielaw. Obiecał mu koronę, jeśli tylko wypłynie na brzeg. Gdy ryba wypłynęła, rybacy ją przechwycili i uwięzli. Dzięki temu już żadna dziewczyna nie musiała już być poświęcana. ");
                                Console.WriteLine("Za wysłuchanie opowieści otrzymujesz 10 punktów doświadczenia\n");
                                b.PD = b.PD + 10;
                                break;
                            case "2":
                                Console.WriteLine("Całkowicie ignorujesz babuszkę i idziesz w swoją stronę.\n");
                                break;
                            default:
                                Console.WriteLine("Niepoprawny znak");
                                continue;
                        }
                    }
                    wybor = "";
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 11)
                {
                    Console.WriteLine("Wieczorem odwiedzasz Kmiecia z nadzieją, że pomoże Ci w znalezieniu roboty. Kmieć przyjmuje Cię z gościnnością. Gdy nastała północ, na zewnątrz słychać jakieś odgłosy. Wybiegacie z chaty i okazuje się, że spod płotu coś wychodzi. To Poroniec! 'Miał jako dobry duch strzec domostwa' mówi zapłakany Kmieć. Rozpoczyna się walka");
                    Przeciwnik Poroniec = new Przeciwnik("Poroniec", 8, 5, 5, 30, 35);
                    Walka.Pojedynek(b, Poroniec);
                    Console.WriteLine("'Do tej pory nic się nie działo. Widocznie pełnia księżyca tak na niego zadziałała.' mówi już spokojny Kmieć. W podziękowaniu za Twoją pomoc otrzymujesz 10 skór.\n");
                    b.skora = b.skora + 10;
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 12)
                {
                    Console.WriteLine("Podczas rozmów w gospodzie, usłyszałeś opowieść dwóch chłopów. Opowiadali oni o skarbie ukrytym pod starą wierzbą nad rzeką. Udajesz się tam wieczorem. Po chwili poszukiwań znajdujesz opisywaną przez chłopów wierzbę. Wtem z wody, powolnym krokiem wyskakuje Utopiec. Rozpoczyna się walka!");//dokończyć
                    Przeciwnik Utopiec = new Przeciwnik("Utopiec", 7, 8, 5, 35, 30);
                    Walka.Pojedynek(b, Utopiec);
                    Console.WriteLine("Gdy w końcu udało Ci się pokonać Utopca, zabierasz się za otwieranie skrzyni. Skrzynia okazała się być pusta.");
                    Console.WriteLine("Otrzymujesz 15 punktów doświadczenia.\n");
                    b.PD = b.PD + 15;
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 13)
                {
                    Console.WriteLine("W wiosce niedawno odbyła się egzekucja. Rzezimieszka, z obawy że mogą nim rządzić siły nieczyste, pochowano za wioską. Jednakże on powrócił pod postacią Strzygonia. I postanowił się zemścić. Niestety pierwszą napotkaną osobą jesteś Ty. Rozpoczyna się walka!");
                    Przeciwnik Strzyga = new Przeciwnik("Strzygoń", 5, 5, 8, 30, 35);
                    Walka.Pojedynek(b, Strzyga);
                    Console.WriteLine("Z truchła Strzygonia wypada 5 klejnotów i 10 rudy.\n");
                    b.klejnot = b.klejnot + 5;
                    b.ruda = b.ruda + 10;
                    Console.ReadKey();
                    Console.Clear();
                }
                if (wybierzPrzygode[los] == 14)
                {
                    Console.WriteLine("Miejscowi chłopi opowiedzieli Ci legendę o ukrytym w okolicznej grocie skarbie, którego strzeże Mamuna. Zaintrygowany tematem postanawiasz udać się do tej groty. Po dłuższym zwiedzaniu znajdujesz kufer pełen złota, klejnotów i rudy. Wtem jednak Twoja pochodnia gaśnie. Słyszysz tylko przerażający śmiech Mamuny. Rozpoczyna się walka!");
                    Przeciwnik Mamuna = new Przeciwnik("Mamuna", 8, 5, 5, 35, 30);
                    Walka.Pojedynek(b, Mamuna);
                    Console.WriteLine("Po pokonaniu potwora udaje Ci się uciec ze skarbem.\n");
                    Console.WriteLine("Otrzymujesz 15 klejnotów, 10 rudy i 20 złota.");
                    b.klejnot = b.klejnot + 15;
                    b.ruda = b.ruda +10;
                    b.zloto = b.zloto + 20;
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            if(licznikPrzygod == 9)
            {
                if (b.drugieZakonczenie == 0)
                {
                    Console.WriteLine("Życie, które zacząłeś wieść po opuszczeniu swoich ziomków to jakaś katastrofa. Przed dotarciem do osady niemal zginąłeś. Po wyzdrowieniu nie jest lepiej.\n Prawie dzień w dzień walczysz o swoje życie. Możesz zapomnieć o wyprawie do lasu po grzyby. Każde wejście do głuszy kończy się atakiem kolejnej krwiożerczej bestii chcącej pozbawić cię życia. Udało ci się wzbogacić to prawda, ale co z tego jeżeli kolejny dzień, może okazać się twoim ostatnim.\n Sfrustrowany postanowiłeś udać się do pobliskiej gospody odreagować złą passę. Znajdując się w środku okazało się, że zdobyłeś niemałą sławę w okolicy. Ludzie chętnie do ciebie zagadywali, a co niektórzy postawili nawet trunek. Po miło spędzonych paru godzinach postanowiłeś przespać się, jednak wszystkie miejsca w gospodzie były zajęte. Wyszedłeś na zewnątrz z nadzieją, że znajdziesz jakieś drzewo, pod którym się zdrzemniesz. Idąc ścieżką zauważyłeś niewyraźny kształt przed sobą. Na początku zrzuciłeś to na ilość wypitego alkoholu. Po paru krokach okazało się, że twoje oczy cię nie zawodzą, coś było przed tobą i zbliżało się w twoim kierunku. Wstrzymałeś oddech, sięgnałeś po swój miecz i uważnie przypatrzyłeś się obiektowi przed tobą. Wcześniejszy niewyraźny kształt okazał się upiorem... Nie siląc się nawet na dyskrecję zaryczałeś i barwnie zacząłeś przeklinać swój los. Twój ryk obudził ludzi w pobliskich domach, którzy wybiegli ze swoich chat z nienawiścią w oczach, jednak nim zdążyli zacząć przekrzykiwać się, zobaczyli nadciągającą zjawę. Każdy zamarł, a na tobie znowu ciązył obowiązek ratowania niewinnych ludzi przed groźnym potworem. Wyciągnąłeś swoje ostrze i ruszyłeś w kierunku bestii...");
                    
                    Przeciwnik Upior = new Przeciwnik("Upiór", 5, 5, 5, 5, 5);
                    Walka.Pojedynek(b, Upior);
                    Console.WriteLine();
                    wskazowska = b.wyswietlPunktacje(b.punktacja);
                    if (wskazowska == true)
                    {
                        Console.WriteLine("Następnym razem odwiedź tego, kto cię uratował.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    
                }
                if (b.drugieZakonczenie == 1)
                { 
                    Console.WriteLine("Pamiętając problem, o którym wspomniał ci Mieszko postanawiasz odwdzięczyć się za jego dobroć, ratując Lesławę.\nCodziennie w nocy, gdy wszyscy już śpią, ty pilnujesz chaty miejscowej zielarki, wypatrując gnieciucha.\nPewnej nocy dopadło cię wreszcie zmęczenie i zasnąłeś.Na twoje nieszczęście w tym czasie gnieciuch postanowił spróbować pozbyć się ciebie.\n Poczułeś ogromny ciężar na swojej piersi.W momencie, gdy próbował chwycić twoje gardło na swoje szczęście otworzyłeś oczy... ");
                    if (b.sila >= 20 && b.zrecznosc >= 10)
                    {
                        Console.WriteLine("Wykorzystując swoją nadludzką siłę bez problemu zrzuciłes małego demona na ziemię i chwyciłeś błyskawicznie swój miecz, który obok ciebie leżał.W tym momemencie było po walce. Nieporadny gruby stwór próbował pozbierać się z ziemi, ale cios twojego miecza nadszedł szybciej i zakończył jego żywot.");
                    }
                    else
                    {
                        Console.WriteLine("Mimo niskiego wzrostu jego waga cię przytłoczyła. Nie miałeś czasu zastanawiać się jak to możliwe, ze tak mała kreatura może tyle ważyć.\n Dzięki doświadczeniu, które nabyłeś po wszystkim co się spotkało od przybycia do osady, zachowałeś zimną krew.\n Odtrąciłeś zbliżające się ręce. Bestia wpadła w furię, że jej plan się nie powiódł. Spróbowała jeszcze raz, jednak ty tym razem wyprowadziłeś celny cios pięścią w głowę. Zamroczyło go to i dało okazję, żeby zrzucić niepozornego demona na ziemię.\nKrzątania na ziemi jednak cię osłabiła.Chwilę zajęło nim udało ci się sięgnąć po swój miecz.W tym czasie twój przeciwnik stanął na nogi i był gotów do walki...  ");
                        Przeciwnik Gnieciuch = new Przeciwnik("Gnieciuch", 7, 6, 6, 40, 40);
                        Walka.Pojedynek(b, Gnieciuch);
                    }
                    b.wyswietlPunktacje(b.punktacja);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (licznikPrzygod == 10)
            {
                if (b.drugieZakonczenie == 0)
                {
                    Console.WriteLine("'Niech żyje! Niech żyje!' zaczęli krzyczeć ludzie stojący w progach domostw.\n'Pokonałeś upiora, który nas dręczył nocami!' mówili inni.\nPo chwili pojawił się knaź Mieszko, który wraz z grupą chłopów ciągnął ogromny kufer.\n 'Przysłużyłeś się naszej osadzie! Postanowiliśmy Cię za to wynagrodzić.'. W kufrze znajduje się spora ilość złota, klejnotów, rud, skór oraz kilka innych przedmiotów, które przydałyby Ci się do dalszej drogi.\n'Ten kufer należy do Ciebie. Możesz go wykorzystać, jeśli chciałbyś ruszyć w dalszą drogę.'\nDroga zabójcy potworów spodobała Ci się, więc faktycznie rozważałeś wyruszenie w dalszą drogę.\n'Jeśli chciałbyś kiedyś do nas wrócić, to wrota osady zawsze będą dla Ciebie otwarte'.\nDecydujesz się jednak na obranie drogi łowcy potworów. Zabierasz kufer ze sobą i odchodzisz ze słowami: 'Niech wam bogi darzą dobrzy ludzie!' \n KONIEC");
                    b.wyswietlStat(b);
                    Environment.Exit(0);
                }
                if (b.drugieZakonczenie == 1)
                {
                    Console.WriteLine("Nawet nie zauważyłeś, kiedy zielarka wybiegła z chaty i popędziła po kmiecia. Dopiero po chwili zobaczyłeś go w progu, gdy patrzył to na Ciebie, to na leżące obok truchło gnieciucha.\n'Udało Ci się! Naprawdę Ci się udało uratować Lesławę!' powiedział Mieszko, po czym Cię uścisnął. \n'Taka rzecz nie może obejść się bez nagrody. Przyjdź w południe na rynek'.\n...\nNastało południe. Na placu na rynku stoi mnóstwo ludzi. 'To chyba knaź ich tu zwołał' myślisz sobie.\n Gdy próbujesz się dostać na środek, zauważasz że wszystkie szmery ucichły i nikt się nie odzywa. W końcu docierasz na środek do knazia Mieszka.\n'Z uwagi na Twoje liczne zasługi oraz uratowane mojej córki Lesławy, chciałbym Ci podziękować' zaczął mówić Mieszko.\n'Mój dar dla Ciebie nie wyrazi pełni wdzięczności jaką czuję do Ciebie, ale proszę przyjmij ode mnie rękę mojej córki oraz spory kawał pola, tu w tej osadzie!'.\nNiedowierzasz własnym uszom. Naprawdę Ty, człowiek, który przyszedł z nikąd, nieznany przez nikogo, stałeś się bohaterem dla Mieszkańców osady!\nDziękujesz knaziowi, zabierasz ze sobą Lesławę i zaczynacie wieść razem spokojne, wspólne życie. \nKONIEC");
                    b.wyswietlStat(b);
                    Environment.Exit(0);
                }
            }
            
        }
        /// <summary>
        /// Metoda <c>losujPrzygody</c> wykorzystująca losowanie liczb celem wybrania przygód dla gracza. 
        /// Dla kolejnych etapów rozgrywki przygotowane są odpowienie pętle. 
        /// </summary>
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
