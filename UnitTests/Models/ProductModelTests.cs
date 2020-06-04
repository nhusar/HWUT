using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Is_5_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            // by default, rating is 5
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Of_Null_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel { Ratings = null };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Of_Empty_Array_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel { Ratings = new int[] {} };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Computes_Correctly_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel
            {
                Ratings = new int[] { 3, 4, 3, 4, 2, 5 }
            };

            // Assert
            // rounded to int
            Assert.AreEqual(3, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_ToString_IsNotNull_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            // Returns some JSON string
            Assert.IsNotNull(result.ToString());
        }

        [TestMethod]
        public void ProductModel_ToString_Returns_Json_String_Should_Pass()
        {
            // Arrange
            const string productId = "product-id";

            // Act
            var result = new ProductModel()
            {
                Id = productId,
            };

            // Assert
            // Returns some JSON string
            Assert.IsTrue(result.ToString().Contains(productId));
        }
    }
}
