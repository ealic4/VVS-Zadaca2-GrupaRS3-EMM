using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tinder.ba;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tinder.ba.Tests
{
    [TestClass()]//Testove uradio Muhamed Drinjak
    public class TinderTests
    {

        [TestMethod]
        public void TestDajSveKompatibilneKorisnike()
        {
            Korisnik k1 = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Korisnik k2 = new Korisnik("user2", "user2*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Korisnik k3 = new Korisnik("user3", "user3*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Korisnik k4 = new Korisnik("user4", "user4*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);

            List<Korisnik> korisnici = new List<Korisnik>();

            korisnici.Add(k1);
            korisnici.Add(k2);
            korisnici.Add(k3);
            korisnici.Add(k4);

            List<Tuple<Korisnik, Korisnik>> parovi = new List<Tuple<Korisnik, Korisnik>>();

            Tinder tinder = new Tinder();

            tinder.RadSaKorisnikom(k1, 0);
            tinder.RadSaKorisnikom(k2, 0);
            tinder.RadSaKorisnikom(k3, 0);
            tinder.RadSaKorisnikom(k4, 0);

            parovi = tinder.DajSveKompatibilneKorisnike();

            List<Tuple<Korisnik, Korisnik>> koris = new List<Tuple<Korisnik, Korisnik>>();

            koris.Add(new Tuple<Korisnik, Korisnik>(k1, k2));
            koris.Add(new Tuple<Korisnik, Korisnik>(k1, k3));
            koris.Add(new Tuple<Korisnik, Korisnik>(k1, k4));
            koris.Add(new Tuple<Korisnik, Korisnik>(k2, k3));
            koris.Add(new Tuple<Korisnik, Korisnik>(k2, k4));
            koris.Add(new Tuple<Korisnik, Korisnik>(k3, k4));

            Assert.AreEqual(parovi.Count, koris.Count);

        }


        [TestMethod]
        [ExpectedException(typeof(Exception), "Prazna lista")]
        public void testIzuzetakTuple()
        {
            Korisnik k1 = new Korisnik("user1", "user1*+", Lokacija.Sarajevo, Lokacija.Sarajevo, 20, false, 15, 30);
            Korisnik k2 = new Korisnik("user2", "user2*+", Lokacija.Sarajevo, Lokacija.Mostar, 20, false, 15, 30);
            Korisnik k3 = new Korisnik("user3", "user3*+", Lokacija.Sarajevo, Lokacija.Mostar, 20, false, 15, 30);
            Korisnik k4 = new Korisnik("user4", "user4*+", Lokacija.Sarajevo, Lokacija.Zenica, 20, false, 15, 30);

            Tinder tinder = new Tinder();

            tinder.RadSaKorisnikom(k1, 0);
            tinder.RadSaKorisnikom(k2, 0);
            tinder.RadSaKorisnikom(k3, 0);
            tinder.RadSaKorisnikom(k4, 0);

            List<Tuple<Korisnik, Korisnik>> parovi = tinder.DajSveKompatibilneKorisnike();


        }

    }
}