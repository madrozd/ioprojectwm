using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Gra
{

    /// <summary>
    /// Klasa <c>Program</c> jest główną klasą programu. Wywoływane są w niej metody, które są odpowiedzialne za losowanie przygód, nazwanie postaci, rozpoczęcie przygody oraz menu. 
    /// Zostają również wywołane konstruktory klas <c>Bohater</c> i <c>Przedmiot</c>, tworząc przy tym obiekty tych klas. Do zmiennych obiektu <c>Bohater</c> zostają przypisane odpowiednie wartości. 
    /// </summary>
    class Program
    {



        static void Main(string[] args)
        {
            
            Przygody.losujPrzygody();
            Przedmiot miecz = new Przedmiot("Miecz", 0, 0, 0, 0, 0);
            Przedmiot zbroja = new Przedmiot("Zbroja", 0, 0, 0, 0, 0);
            Przedmiot helm = new Przedmiot("Helm", 0, 0, 0, 0, 0);
            Przedmiot pas = new Przedmiot("Pas", 0, 0, 0, 0, 0);
            Bohater bohater = new Bohater();
            Console.WriteLine("Podaj imię postaci: ");
            string nazwa = Console.ReadLine();
            while (!(bohater.nazwijPostac(nazwa)))
            {
                Console.WriteLine("Podaj imię postaci: ");
                nazwa = Console.ReadLine();
            }
            bohater.sila = 20;
            bohater.zrecznosc = 20;
            bohater.wytrzymalosc = 10;
            bohater.inteligencja = 10;
            bohater.charyzma = 10;
            bohater.PZ = 100;
            bohater.PD = 20;
            bohater.zloto = 100;
            bohater.ruda = 100;
            bohater.skora = 100;
            bohater.klejnot = 100;

            Przygody.Poczatek();
            Console.WriteLine(bohater.nazwa);
            while (true)
            {
                Akcja.Menu(bohater, miecz, zbroja, helm, pas);    
            } 
        }
    }
}
