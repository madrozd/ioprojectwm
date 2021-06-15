using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
   /// <summary>
   /// Klasa publiczna <c>Przeciwnik</c> jest klasą dziedziczącą z klasy <c>Arkusz</c>.
   /// </summary>
    public class Przeciwnik : Arkusz
    {
        public int maxPZ;
        public int nagrodaZ;
        public int nagrodaP;
        /// <summary>
        /// Konstruktor <c>Przeciwnik</c> służący do stworzenia przeciwników.
        /// </summary>
        /// <param name="nazwa">Parametr <c>nazwa</c> odpowiedzialny jest za nazwanie przeciwnika.</param>
        /// <param name="sila">Parametr <c>sila</c> określa siłę przeciwnika.</param>
        /// <param name="zrecznosc">Parametr <c>zrecznosc</c> służy do określenia zręczności przeciwnika.</param>
        /// <param name="wytrzymalosc">Parametr <c>wytrzymalosc</c> pokazuje jaką wytrzymałość posiada przeciwnik.</param>
        /// <param name="nagrodaZ">Parametr <c>nagrodaZ</c> określa ile złota gracz otrzyma za pokonanie przeciwnika.</param>
        /// <param name="nagrodaP">Parametr <c>nagrodaP</c> służy do pokazania ile punktów doświadczenia otrzyma gracz za pokonanie przeciwnika.</param>
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
        /// <summary>
        /// Dekonstruktor <c>Przeciwnik</c>
        /// </summary>
        ~Przeciwnik()
        { 

        }
    }
}
