using System;
using System.Collections.Generic;
using DierenAsiel.Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DierenAsiel.Models;

namespace DierenAsiel_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Reservering _r;

        [TestInitialize]
        public void Init()
        {
            _r = new Reservering();
        }

        [TestMethod]
        public void CatTester()
        {
            Cat k = new Cat();
            Persoon p = new Persoon();
            k.ExtraInfo = "hoi";
            k.VorigeEigenaar = p;
            Assert.IsNotNull(k.ExtraInfo);
            Assert.IsNotNull(k.VorigeEigenaar);
        }

        [TestMethod]
        public void DogTester()
        {
            Dog d = new Dog();
            Persoon p = new Persoon();
            d.UitlaatDateTime = DateTime.Now;
            d.VorigeEigenaar = p;
            Assert.IsNotNull(d.UitlaatDateTime);
            Assert.IsNotNull(d.VorigeEigenaar);
        }

        [TestMethod]
        public void ReserveringTester()
        {
            Dog d = new Dog();
            Persoon p = new Persoon();

            _r.Persoon = p;
            _r.Dier = d;

            Assert.IsNotNull(_r.Dier);
            Assert.IsNotNull(_r.Persoon);
        }


        [TestMethod]
        public void DalTester()
        { 
            DierMemoryContext dmc = new DierMemoryContext();
            DierRepository dr = new DierRepository(dmc);
            List<Dier> dieren = dr.GetAllDieren();
            Assert.IsTrue(dieren.Count > 1);
        }

    }
}