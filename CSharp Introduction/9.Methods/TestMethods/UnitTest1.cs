using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.PrintName;

namespace TestMethods
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            string res=Name.PrintName("Penka");
            Assert.AreSame("Penka", res);
        }
    }
}
