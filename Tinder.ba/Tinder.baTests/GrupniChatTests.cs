using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.ba;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tinder.ba.Tests
{
    [TestClass()]
    public class GrupniChatTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void TestIzuzetkaPosaljiPorukuViseKorisnika()
        {
            Korisnik k = new Korisnik();
            List<Korisnik> l = new List<Korisnik>();

            GrupniChat c = new GrupniChat(l);
            c.PosaljiPorukuViseKorisnika(k,l,"");
        }
    }
}