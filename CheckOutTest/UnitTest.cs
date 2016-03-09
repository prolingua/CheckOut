using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckOut.CheckOutClass;
using System.Collections.Generic;

namespace CheckOutTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void UnitTest1()
        {
            // Arrange
            IList<ShoppingModel> shoppingList = new List<ShoppingModel>();
            Checkout checkOut = new Checkout();

            // Act
            int totalPrice = checkOut.GetTotalPrice(shoppingList);

            // Assert
            Assert.IsTrue(totalPrice >= 0);

        }

        [TestMethod]
        [ExpectedException(typeof(SkuNotExistException))]
        public void UnitTest2()
        {
            // Arrange
            IList<ShoppingModel> shoppingList = new List<ShoppingModel>();
            Checkout checkOut = new Checkout();

            // Act
            checkOut.Scan("T", shoppingList);

            // Assert
            // assert is handled by the ExpectedException

        }

        [TestMethod]
        public void UnitTest3()
        {
            // Arrange
            IList<ShoppingModel> shoppingList = new List<ShoppingModel>();
            Checkout checkOut = new Checkout();
            string item = "A";

            // Act
            checkOut.Scan(item, shoppingList);

            // Assert
            Assert.AreEqual(shoppingList[0].Sku, item); 

        }

        [TestMethod]
        public void UnitTest4()
        {
            // Arrange
            IList<ShoppingModel> shoppingList = new List<ShoppingModel>();
            Checkout checkOut = new Checkout();
            string item1 = "A";
            string item2 = "B";

            // Act
            checkOut.Scan(item1, shoppingList);
            checkOut.Scan(item1, shoppingList);
            checkOut.Scan(item2, shoppingList);

            // Assert
            Assert.AreEqual(shoppingList[0].Quantity, 2);
            Assert.AreEqual(shoppingList[1].Quantity, 1);

        }

        [TestMethod]
        public void UnitTest5()
        {
            // Arrange
            IList<ShoppingModel> shoppingList = new List<ShoppingModel>();
            Checkout checkOut = new Checkout();
            string item1 = "A";

            // Act
            checkOut.Scan(item1, shoppingList);
            int totalPrice = checkOut.GetTotalPrice(shoppingList);

            // Assert
            Assert.AreEqual(totalPrice, 50);

        }

    }
}
