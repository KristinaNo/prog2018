using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddThreeElements()
        {
            var hashTab = new HashTable(3);
            hashTab.PutPair(1, "one");
            hashTab.PutPair(2, "two");
            hashTab.PutPair(3, "three");
            Assert.AreEqual(hashTab.GetValueByKey(1), "one");
            Assert.AreEqual(hashTab.GetValueByKey(2), "two");
            Assert.AreEqual(hashTab.GetValueByKey(3), "three");
        }

        [TestMethod]
        public void TestAddTwoElements()
        {
            var hashTab = new HashTable(2);
            hashTab.PutPair(1, "one");
            hashTab.PutPair(1, "two");
            Assert.AreEqual(hashTab.GetValueByKey(1), "two");
        }

        [TestMethod]
        public void TestManyElements()
        {
            var hashTab = new HashTable(100000);
            for (int i=0; i<100000; i++)
            hashTab.PutPair(i, i+2);
            Assert.AreEqual(hashTab.GetValueByKey(7905), 7907);
        }

        [TestMethod]
        public void TestOtherManyElements()
        {
            var hashTab = new HashTable(100000);
            for (int i = 0; i < 100000; i++)
                hashTab.PutPair(i, i + 2);
            for (int i = 0; i < 100000; i++)
            Assert.AreEqual(hashTab.GetValueByKey(i), i+2);
        }
    }


    
        
    
}
