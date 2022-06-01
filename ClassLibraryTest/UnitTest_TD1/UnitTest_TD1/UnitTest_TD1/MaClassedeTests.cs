using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTest;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest_TD1
{
    [TestClass]
    public class MaClassedeTests
    {
        [TestMethod]
        public void Test1()
        {
            Mediatheque maMedia = new Mediatheque();
            CD unCD = new CD("30658274", 32);
            maMedia.getMesCD().Add(unCD);
            Assert.AreNotEqual(2, maMedia.getNbCD());

        }
        [TestMethod]
        public void Test2()
        {
            Mediatheque maMedia = new Mediatheque();
            Assert.AreEqual(0, maMedia.getNbCD());
       }
        [TestMethod]
        public void Test3()
        {
            Mediatheque maMedia = new Mediatheque();
            CD unCD = new CD("30658274", 32);
            maMedia.getMesCD().Add(unCD);
            List<CD> liste1 = new List<CD>();
            liste1.Add(unCD);
            CollectionAssert.AreEqual(liste1, maMedia.getMesCD());
        }

        [TestMethod]
        public void Test4()
        {
            Mediatheque media = new Mediatheque();
            CD cd1 = new CD("3066596", 32);
            CD cd2 = new CD("3066596", 33);
            media.getMesCD().Add(cd1);
            media.getMesCD().Add(cd2);
            Assert.AreEqual(2, media.getNbCD());

            Assert.AreEqual(32, media.getMesCD().First());
            Assert.AreEqual(33, media.getMesCD()[1].noCD);
        }
    }
}
