using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NasiUnitTestovi
{
    [TestClass]
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
    }
}
