using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4.CountsOfSameNum;

namespace TestCountOfSameNum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] myArray = { 0, 2, 7, 7, 2, 2 };
            int res=CountsOfSameNum.GetCount(myArray,5, 2) ;
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] myArray = { 0, 2, 7, 7, 2, 2 };
            int res = CountsOfSameNum.GetCount(myArray, 5, 1);
            Assert.AreEqual(0, res);
        }  
    }
}

