using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice_10_Example.Papers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPractice10
{
    [TestClass]
    public class TestPaperCounterWhenFourCreated
    {

        [TestMethod]
        public void TestPaperCounter_EveryDescendantCreated_FourExpected()
        {
            // Arrange
            new Paper(1, "A");
            new Book(1, "AA");
            new Magazine(1, "AAA");
            new StudentBook(1, "AAAA");

            // Act
            var counter = Paper.GetPaperCount();

            // Assert
            Assert.AreEqual(4, counter);
        }
    }
}
