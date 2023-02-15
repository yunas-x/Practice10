using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Practice_10_Example.Papers.Comparers;
using Practice_10_Example.Papers;

namespace TestPractice10
{
    [TestClass]
    public class TestDefaultComparer
    {

        [TestMethod]
        public void TestDefaultPaperComparer_WhenNotPapersPassed_RaiseError()
        {
            // Arange
            var papers = new object[] { new Paper(1, "A"), new Book(1, "AA"), "Some thing" };
            bool raised = false;

            // Act
            try
            {
                Array.Sort(papers);
                
            }
            catch (Exception)
            {
                raised = true;
            }

            // Assert
            finally
            {
                Assert.IsTrue(raised);
            }
        }

    }
}
