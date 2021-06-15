using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    /// <summary>
    /// Klasa publiczna <c>Przedmiot</c> dziedzicząca z klasy <c>Arkusz</c>.
    /// </summary>
    public class Przedmiot : Arkusz
    {
        public string stan;
        /// <summary>
        /// Konstruktor <c>Przedmiot</c> służący do tworzenia obiektów klasy <c>Przedmiot</c>.
        /// </summary>
        /// <param name="nazwa">Parametr <c>nazwa</c>określający nazwę przedmiotu.</param>
        /// <param name="sila">Parametr <c>sila</c> pokazujący ile dodatkowej siły gracz otrzyma z przedmiotu.</param>
        /// <param name="zrecznosc">Parametr <c>zrecznosc</c> określający jaką wartość zręczności przedmiot doda dla gracza.</param>
        /// <param name="wytrzymalosc">Parametr <c>wytrzymalosc</c> służy do pokazania ile wytrzymałości dodatkowej dla gracza płynie z przedmiotu.</param>
        /// <param name="inteligencja">Parametr <c>inteligencja</c> określa ile dodatkowej inteligencji gracz otrzyma z przedmiotu.</param>
        /// <param name="charyzma">Parametr <c>charyzma</c> pokazuje jaką wartość charyzmy przedmiot dodaje do statystyk gracza.</param>
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
