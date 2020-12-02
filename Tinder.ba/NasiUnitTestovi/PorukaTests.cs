using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.ba;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tinder.ba.Tests
{
    [TestClass()]//Testove uradila Elvira Alic
    public class PorukaTests
    {

        [TestMethod]
        public void TestPoruka()
        {
            Korisnik k1 = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Korisnik k2 = new Korisnik("user2", "user2*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);

            String content = "Twinkle Twinkle Little Star bježi volim ljubav,hoću oženjen"; // 40 potencijal
            Poruka poruka = new Poruka(k1, k2, content);

            int potencijal = poruka.IzračunajPotencijalPoruke();

            Assert.AreEqual(potencijal, 40);

        }

        [TestMethod]
        public void TestPoruka2()
        {
            Korisnik k1 = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Korisnik k2 = new Korisnik("user2", "user2*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);

            String content = "Twinkle Twinkle Little Star bježi ljubav,hoću oženjen"; // 40 potencijal
            Poruka poruka = new Poruka(k1, k2, content);

            int potencijal = poruka.IzračunajPotencijalPoruke();

            Assert.AreEqual(potencijal, 20);

        }

    }
}