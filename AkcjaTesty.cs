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
    public class AkcjaTesty
    {
        [TestMethod]
        public void Odpocznij_Poprawne()
        {
            // arrange
            var bohater = new Bohater();
            bohater.bierwiono = 1;
            bohater.wytrzymalosc = 5;
            int oczekiwane = 50;

            // act
            Akcja.Odpocznij(bohater);

            // assert
            Assert.AreEqual(oczekiwane, bohater.PZ);
        }

        [TestMethod]
        public void Odpocznij_Niepoprawne()
        {
            // arrange
            var bohater = new Bohater();
            bohater.bierwiono = 0;
            bohater.wytrzymalosc = 5;
            int oczekiwane = 50;

            // act
            Akcja.Odpocznij(bohater);

            // assert
            Assert.AreNotEqual(oczekiwane, bohater.PZ);
        }
    }
}
