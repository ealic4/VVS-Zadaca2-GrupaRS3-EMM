using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.ba;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tinder.ba.Tests
{
    [TestClass()]
    public class TinderTests
    {
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIzuzetkaTnderRadSaKorisnikom()
        {
            Korisnik k = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Korisnik k2 = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Tinder t = new Tinder();
            t.Korisnici.Add(k);
            t.RadSaKorisnikom(k2, 0);

        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIzuzetkaTnderRadSaKorisnikom1()
        {
            Korisnik k2 = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Tinder t = new Tinder();
            t.RadSaKorisnikom(k2, 1);

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIzuzetkaTnderDodajRazgovore()
        {
            List<Korisnik> k= null;
            Tinder t = new Tinder();
            t.DodavanjeRazgovora(k,false);
        }
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void TestIzuzetkaTnderDajSveKompatbilneKorisnike()
        {
            
            Tinder t = new Tinder();
            t.DajSveKompatibilneKorisnike();
        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIzuzetkaTnderDaLiJeSpajanjeUspjesno()
        {
            List<Korisnik> l = new List<Korisnik>();
            IRecenzija r = new Recenzija();
            Chat c = new GrupniChat(l);
            Tinder t = new Tinder();
            t.DaLiJeSpajanjeUspjesno(c,r);
        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIzuzetkaTnderPotencijalChata()
        {
            List<Korisnik> l = new List<Korisnik>();
            Chat c = new GrupniChat(l);
            Tinder t = new Tinder();
            t.PotencijalChata(c);
        }

    }
}