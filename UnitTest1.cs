using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            Assert.Equals(Calculator.Add(7, 3), 10);
        }
        [TestMethod]
        public void Substract()
        {
            Assert.Equals(Calculator.Substract(5, 2), 3);
        }
        [TestMethod]
        public void Multiply()
        {
            Assert.Equals(Calculator.Multiply(3, 2), 6);
        }
        [TestMethod]
        public void Divide()
        {
            Assert.Equals(Calculator.Divide(12, 2), 6);
        }
        internal class Calculator
        {
            public static int Add(int a1, int a2)
            {
                return a1 + a2;
            }
            public static int Substract(int a1, int a2)
            {
                return a1 - a2;
            }
            public static int Multiply(int a1, int a2)
            {
                return a1 * a2;
            }
            public static int Divide(int a1, int a2)
            {
                return a1 / a2;
            }
        }
    }
}
