using Microsoft.VisualStudio.TestTools.UnitTesting;
using Café;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Café.Tests
{
    [TestClass()]
    public class CafeTests
    {
        [TestMethod()]
        public void PrisTestcafe()
        {
            //arange
            var cafe = new SortKaffe();

            //act
            int pris = cafe.Pris();

            //assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void StyrkeTestcafe()
        {
            //arange
            var cafe = new SortKaffe();

            //act
            string styrke = cafe.Styrke();

            //assert
            Assert.AreEqual("Stærk", styrke);
            }
        }
}