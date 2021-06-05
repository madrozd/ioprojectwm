using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Przeciwnik : Arkusz
    {
        public int maxPZ;
        public int nagrodaZ;
        public int nagrodaP;

        public Przeciwnik(string nazwa, int sila, int zrecznosc, int wytrzymalosc, int nagrodaZ, int nagrodaP)
        {
            this.nazwa = nazwa;
            this.sila = sila;
            this.zrecznosc = zrecznosc;
            this.wytrzymalosc = wytrzymalosc;
            this.nagrodaZ = nagrodaZ;
            this.nagrodaP = nagrodaP;
            PZ = wytrzymalosc * 10;
            maxPZ = wytrzymalosc * 10;
        }
        ~Przeciwnik()
        { 

        }
    }
}
