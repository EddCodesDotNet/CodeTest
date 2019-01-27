using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryNumberGenerator.Controllers;

namespace LotteryNumberGenerator.Tests.Controllers
{
    [TestClass]
    public class GenerateControllerTest
    {
        [TestMethod]
        public void ReturnsCorrectNumberOfValues()
        {
            // Arrange
            GenerateController controller = new GenerateController();

            // Act
            IEnumerable<int> result = controller.GetNumbers();

            // Assert
            Assert.AreEqual(result.Count(), 6);
        }

        [TestMethod]
        public void AllReturnedValuesAreUnique()
        {
            // Arrange
            GenerateController controller = new GenerateController();

            // Repeat enough times to verify test
            for (int i = 0; i < 1000; i++)
            {
                // Act
                IEnumerable<int> result = controller.GetNumbers();

                // Assert
                Assert.IsTrue(result.Distinct().Count() == result.Count());
            }
        }
    }
}
