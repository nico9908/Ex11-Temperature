using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex11_Temperature;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        const double delta = 0.00001;

        [TestMethod]
        public void TwoPropertiesUsesOneVariable01()
        {
            Temperature temperature = new Temperature();
            temperature.Celsius = 50.0;

            Assert.AreEqual(50, temperature.Celsius, delta);
            Assert.AreEqual(122.0, temperature.Fahrenheit, delta);
        }

        [TestMethod]
        public void TwoPropertiesUsesOneVariable02()
        {
            Temperature temperature = new Temperature();
            temperature.Fahrenheit = 55.5;

            Assert.AreEqual(55.5, temperature.Fahrenheit, delta);
            Assert.AreEqual(13.05555, temperature.Celsius, delta);
        }

        [TestMethod]
        public void TwoPropertiesUsesOneVariable03()
        {
            Temperature temperature = new Temperature();

            Assert.AreEqual(0.0, temperature.Celsius, delta);
            Assert.AreEqual(32.0, temperature.Fahrenheit, delta);
        }

    }
}
