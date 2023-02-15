using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice_10_Example.Papers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPractice10
{
    [TestClass]
    public class TestPaperCounterWhenNoneCreated
    {
        [TestMethod]
        public void TestPaperCounter_NoCreated_ZeroExpected()
        {
            // Arrange
            // Do nothing

            // Act
            var counter = Paper.GetPaperCount();

            // Assert
            Assert.AreEqual(0, counter);
        }
    }
}
