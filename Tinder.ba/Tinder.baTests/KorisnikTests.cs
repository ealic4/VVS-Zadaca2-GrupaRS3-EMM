using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.ba;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tinder.ba.Tests
{
    [TestClass()]
    public class KorisnikTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void TestIzuzetkaIme()
        {
            Korisnik k = new Korisnik();
            k.Ime = "";
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void TestIzuzetkaPassword()
        {
            Korisnik k = new Korisnik();
            k.Password = "123";
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void TestIzuzetkaGodine()
        {
            Korisnik k = new Korisnik();
            k.Godine = 11;
        }
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void TestIzuzetkaZeljeneMinGodine()
        {
            Korisnik k = new Korisnik();
            k.Godine = 40;
            k.ZeljeniMinGodina = 25;
        }
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void TestIzuzetkaZeljeniMaxGodina()
        {
            Korisnik k = new Korisnik();
            k.Godine = 40;
            k.ZeljeniMaxGodina = 60;
        }

    }
}