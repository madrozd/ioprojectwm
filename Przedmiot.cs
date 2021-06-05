using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Przedmiot : Arkusz
    {
        public int wartosc;
        public Przedmiot(string nazwa, int sila, int zrecznosc, int wytrzymalosc, int inteligencja, int charyzma, int wartosc)
        {
            this.nazwa = nazwa;
            this.sila = sila;
            this.zrecznosc = zrecznosc;
            this.wytrzymalosc = wytrzymalosc;
            this.inteligencja = inteligencja;
            this.charyzma = charyzma;
            this.wartosc = wartosc;
            PZ = 0;
        }
    }
}
