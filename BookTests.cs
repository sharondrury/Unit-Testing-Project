// all together works fine - use all code for reference and to help with other unit testing projects

using GradeBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankTests
{
    [TestClass]
    public class BookTests
    {
        // this is an attribute [TestMethod]
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
           
            // act
            var result = book.GetStatistics();

            // assert
            Assert.AreEqual(85.6, result.Average, 1);
            Assert.AreEqual(90.5, result.High, 1);
            Assert.AreEqual(77.3, result.Low, 1);
        }
    }
}
