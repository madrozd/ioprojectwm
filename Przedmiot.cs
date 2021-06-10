using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
   public class Przedmiot : Arkusz
    {
        public string stan;
        public Przedmiot(string nazwa, int sila, int zrecznosc, int wytrzymalosc, int inteligencja, int charyzma)
        {
            this.nazwa = nazwa;
            this.sila = sila;
            this.zrecznosc = zrecznosc;
            this.wytrzymalosc = wytrzymalosc;
            this.inteligencja = inteligencja;
            this.charyzma = charyzma;    
            stan = "podstawowy";
            PZ = 0;
        }
    }
}
