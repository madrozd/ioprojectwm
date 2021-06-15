using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra;

namespace GraTesty
{
    [TestClass]
    public class BohaterTesty
    {
        [TestMethod]
        public void wyswietlPunktacje_Powyzej40()
        {
            // arrange
            bool oczekiwane = true;
            bool sprawdz;
            var bohater = new Bohater();
            bohater.punktacja = 80;

            // act
           sprawdz = bohater.wyswietlPunktacje(bohater.punktacja);

            // assert
            Assert.AreEqual(oczekiwane, sprawdz);
        }

        [TestMethod]
        public void wyswietlPunktacje_Rowne40()
        {
            // arrange
            bool sprawdz;
            var bohater = new Bohater();
            bohater.punktacja = 40;

            // act
            sprawdz = bohater.wyswietlPunktacje(bohater.punktacja);

            // assert
            Assert.IsTrue(sprawdz);
        }

        [TestMethod]
        public void wyswietlPunktacje_Mniej40()
        {
            // arrange
            bool sprawdz;
            var bohater = new Bohater();
            bohater.punktacja = 30;

            // act
           sprawdz = bohater.wyswietlPunktacje(bohater.punktacja);

            // assert
            Assert.IsFalse(sprawdz);
        }
        [TestMethod]
        public void nazwijPostac_Poprawnie()
        {
            // arrange
            string imie = "Bezimienny";
            bool sprawdz;
            var bohater = new Bohater();

            // act
            sprawdz = bohater.nazwijPostac(imie);

            // assert

            Assert.IsTrue(sprawdz);

        }
        [TestMethod]
        public void nazwijPostac_Niepoprawnie()
        {
            // arrange
            string imie = "Be1zim2ienny3";
            bool sprawdz;
            var bohater = new Bohater();

            // act
            sprawdz = bohater.nazwijPostac(imie);

            // assert

            Assert.IsFalse(sprawdz);

        }
    }
}
