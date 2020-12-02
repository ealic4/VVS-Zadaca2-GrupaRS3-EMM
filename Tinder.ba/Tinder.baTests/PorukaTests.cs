using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.ba;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tinder.ba.Tests
{
    [TestClass()]
    public class PorukaTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIzuzetkaPorukaSadrzaj()
        {
            Korisnik k = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Korisnik k2 = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Poruka p = new Poruka(k, k2, "riječ");
            p.Sadrzaj = null;
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestIzuzetkaPorukaKonstruktor()
        {
            Korisnik k = new Korisnik();
            Korisnik k2 = null;
            Poruka p = new Poruka(k, k2, "abc");
        }
    }
}