using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.ba;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tinder.ba.Tests
{
    [TestClass()]//Testove uradio Muhamed Drinjak
    public class KorisnikTests
    {
        [TestMethod()]
        public void RazvediSeTest1()
        {
            Korisnik k = new Korisnik();
            k.Godine=23;
            k.Lokacija = Lokacija.Bihać;
            k.RazvediSe();
            Assert.AreEqual(k.ZeljeniMaxGodina, 27);
            Assert.AreEqual(k.ZeljeniMinGodina, 19);
            Assert.AreEqual(k.ZeljenaLokacija, Lokacija.Banja_Luka);
        }
        [TestMethod()]
        public void RazvediSeTest2()
        {
            Korisnik k = new Korisnik();
            k.Godine = 40;
            k.Lokacija = Lokacija.Trebinje;
            k.RazvediSe();
            Assert.AreEqual(k.ZeljeniMaxGodina, 44);
            Assert.AreEqual(k.ZeljeniMinGodina, 36);
            Assert.AreEqual(k.ZeljenaLokacija, Lokacija.Mostar);
        }
    }
}