using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora_MSTest
{
    [TestClass]
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
