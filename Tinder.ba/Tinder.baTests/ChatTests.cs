using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.ba;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tinder.ba.Tests
{
    [TestClass()]
    public class ChatTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIzuzetkaPocetakChata()
        {
            Chat c = new Chat();
            var date1 = new DateTime(2030, 3, 1, 7, 0, 0);
            c.PocetakChata = date1;

        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIzuzetkaNajnovijaPoruka()
        {
            Chat c = new Chat();
            var date1 = new DateTime(2030, 3, 1, 7, 0, 0);
            c.NajnovijaPoruka = date1;

        }


    }
}