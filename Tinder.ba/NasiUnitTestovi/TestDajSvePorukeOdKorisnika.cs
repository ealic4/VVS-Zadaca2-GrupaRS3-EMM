using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace NasiUnitTestovi
{
    [TestClass]//Testove uradio Mirnes Patkovic
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestMethod1()
        {
            
            Tinder.ba.Korisnik k = new Tinder.ba.Korisnik();
            Tinder.ba.Chat chat = new Tinder.ba.Chat();
            chat.DajSvePorukeOdKorisnika(k);
        }
        [TestMethod]
        
        public void TestMethod2()
        {

            Tinder.ba.Korisnik k = new Tinder.ba.Korisnik();
            Tinder.ba.Korisnik k2 = new Tinder.ba.Korisnik();
            Tinder.ba.Chat chat = new Tinder.ba.Chat(k,k2);
            chat.Poruke.Add(new Tinder.ba.Poruka(k, k2, "Poruka1"));
            chat.Poruke.Add(new Tinder.ba.Poruka(k2, k, "Poruka2"));
            chat.Poruke.Add(new Tinder.ba.Poruka(k, k2, "Poruka3"));
            List<Tinder.ba.Poruka> Poruke= chat.DajSvePorukeOdKorisnika(k);
            Assert.AreEqual(Poruke[0].Sadrzaj, "Poruka1");
            Assert.AreEqual(Poruke[1].Sadrzaj, "Poruka3");
        }
    }
}
