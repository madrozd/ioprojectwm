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
    public class SwiatyniaTesty
    {

        [TestMethod]
        public void Ofiara_Rowne100()
        {
            // arrange
            int oczekiwane = 0;
            var bohater = new Bohater();
            bohater.zloto = 100;

            // act
            Swiatynia.Ofiara(bohater);

            // assert
            Assert.AreEqual(oczekiwane, bohater.zloto);
        }

        [TestMethod]
        public void Ofiara_Mniej100()
        {
            // arange
            var bohater = new Bohater();
            bohater.zloto = 90;
            int oczekiwane = 90;

            // act
            Swiatynia.Ofiara(bohater);

            // assert
            Assert.AreEqual(oczekiwane, bohater.zloto);
        }
        
        [TestMethod]
        public void Ofiara_Wiecej100()
        {
            // arrange
            var bohater = new Bohater();
            bohater.zloto = 205;
            int oczekiwane = 105;

            // act
            Swiatynia.Ofiara(bohater);

            // assert
            Assert.AreEqual(oczekiwane, bohater.zloto);

        }
    }
}
