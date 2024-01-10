using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OpenDataLibrary;

namespace OpenDataTEST
{
    [TestClass]
    public class UnitTest1
    {
        private double lat = 0;
        private double lon = 0;
        private int radius = 0;

        [TestMethod]
        public void SingleJson()
        {
            FakeRequest fake = new FakeRequest();
            MetroAPI api = new MetroAPI(fake);
            // ici faire le test avec Assert
            List<TransportLine> result = api.GetLines(lat, lon, radius) ;
            Assert.AreEqual("SEM:1696", result[0].Id);
            Assert.AreEqual("Grenoble, Chavant", result[0].Name);
            Assert.AreNotEqual("Je suis le faux", "Grenoble, Chavant");
        }
    }
}
