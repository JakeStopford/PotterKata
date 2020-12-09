using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DahlKata.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Checkout_5UniqueBooks_Returns30()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            List<Book> Basket = new List<Book>();

            Book book1 = new Book { Id = 1 };
            Book book2 = new Book { Id = 2 };
            Book book3 = new Book { Id = 3 };
            Book book4 = new Book { Id = 4 };
            Book book5 = new Book { Id = 5 };

            Basket.Add(book1);
            Basket.Add(book2);
            Basket.Add(book3);
            Basket.Add(book4);
            Basket.Add(book5);

            var result = calculator.Checkout(Basket, 0);

            //Assert
            Assert.AreEqual(result, 30);
        }

        [TestMethod]
        public void Checkout_Test1_Returns51()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            List<Book> Basket = new List<Book>();

            Book book1 = new Book { Id = 1 };
            Book book2 = new Book { Id = 2 };
            Book book3 = new Book { Id = 3 };
            Book book4 = new Book { Id = 4 };
            Book book5 = new Book { Id = 5 };

            Basket.Add(book1);
            Basket.Add(book1);
            Basket.Add(book2);
            Basket.Add(book2);
            Basket.Add(book3);
            Basket.Add(book3);
            Basket.Add(book4);
            Basket.Add(book5);

            var result = calculator.Checkout(Basket, 0);

            //Assert
            Assert.AreEqual(result, 51.6);
        }

        [TestMethod]
        public void Checkout_Test2_Returns70()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            List<Book> Basket = new List<Book>();

            Book book1 = new Book { Id = 1 };
            Book book2 = new Book { Id = 2 };
            Book book3 = new Book { Id = 3 };
            Book book4 = new Book { Id = 4 };
            Book book5 = new Book { Id = 5 };

            Basket.Add(book1);
            Basket.Add(book1);
            Basket.Add(book1);
            Basket.Add(book1);
            Basket.Add(book2);
            Basket.Add(book2);
            Basket.Add(book2);
            Basket.Add(book3);
            Basket.Add(book5);
            Basket.Add(book5);

            var result = calculator.Checkout(Basket, 0);

            //Assert
            Assert.AreEqual(result, 70.4);
        }
    }
}
