using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib;

namespace UnitTestModelLib
{
    [TestClass]
    public class UnitTest1
    {
        private Book book;
        [TestInitialize]
        public void Initalize()
        {
            book = new Book("The Ugly Duckling","HC Andersen", 10, "9362124123312");
        }

        [TestMethod]
        public void TestAuthor()
        {
            string _validAuthor = "HC Andersen";
            string _validAuthor2 = "Bo";

            Assert.AreEqual(_validAuthor, book.Author);
            book.Author = _validAuthor2;
            Assert.AreEqual(_validAuthor2, book.Author);
        }

        [TestMethod]
        public void TestTitle()
        {
            string _validTitle = "The Ugly Duckling";
            string _validTitle2 = "Op";

            Assert.AreEqual(_validTitle, book.Title);
            book.Title = _validTitle2;
            Assert.AreEqual(_validTitle2, book.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitleNull()
        {
            book.Title = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitleEmpty()
        {
            book.Title = "   ";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitleInvalid()
        {
            book.Title = "i";
        }

        [TestMethod]
        public void TestPagenumber()
        {
            int _validPagenumber = 10;
            int _validPagenumber2 = 1000;

            Assert.AreEqual(_validPagenumber, book.Pagenumber);
            book.Pagenumber = _validPagenumber2;
            Assert.AreEqual(_validPagenumber2, book.Pagenumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPagenumberMinValid()
        {
            book.Pagenumber = -52;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPagenumberMinValid2()
        {
            book.Pagenumber = 53123;
        }

        [TestMethod]
        public void TestIsbn13()
        {
            string _validIsbn13 = "9362124123312";
            string _validIsbn13_2 = "9182367132713";

            Assert.AreEqual(_validIsbn13, book.Isbn13);
            book.Isbn13 = _validIsbn13_2;
            Assert.AreEqual(_validIsbn13_2, book.Isbn13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsbn13Invalid()
        {
            book.Isbn13 = "321";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsbn13Invalid2()
        {
            book.Isbn13 = "523871263561237123";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsbn13Invalid3()
        {
            book.Isbn13 = "abhsuejkmn12u";
        }
    }
}
