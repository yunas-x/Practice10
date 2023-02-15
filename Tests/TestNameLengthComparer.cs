using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice_10_Example.Papers.Comparers;
using Practice_10_Example.Papers;
using System;

namespace TestPractice10
{
    [TestClass]
    public class TestNameLengthComparer
    {
        [TestMethod]
        public void TestNameLengthComparer_WhenNotPapersPassed_NotPaperIsInFirstPosition()
        {
            // Arange
            var papers = new object[] { new Paper(1, "A"), new Book(1, "AA"), "Some thing" };

            // Act
            Array.Sort(papers, new NameLengthComparer());

            // Assert
            Assert.AreEqual("Some thing", papers[0]);
        }

        [TestMethod]
        public void TestNameLengthComparer_WhenNotPapersPassed_TheLongestNamedPaperIsLast()
        {
            // Arange
            var papers = new object[] { new Paper(1, "A"), new Book(1, "AA"), "Some thing" };

            // Act
            Array.Sort(papers, new NameLengthComparer());

            // Assert
            Assert.AreEqual("AA", ((Paper)papers[2]).Name);
        }
    }
}
