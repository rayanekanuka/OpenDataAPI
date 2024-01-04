﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OpenDataLibrary;

namespace OpenDataTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SingleJson()
        {
            FakeRequest fake = new FakeRequest();
            MetroAPI api = new MetroAPI(fake);
            // ici faire le test avec Assert
            List<TransportLine> result = api.GetLines();
            Assert.AreEqual("SEM:1696", result[0].id);
            Assert.AreEqual("Grenoble, Chavant", result[0].name);
            Assert.AreNotEqual("Je suis le faux", "Grenoble, Chavant");
        }
    }
}