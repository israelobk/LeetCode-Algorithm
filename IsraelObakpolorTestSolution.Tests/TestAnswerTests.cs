namespace IsraelObakpolorTestSolution.Tests
{
    [TestFixture]
    public class TestAnswerTests
    {

        [Test]
        public void Rob_EmptyArray_ReturnsZero()
        {
            // Arrange
            int[] nums = new int[] { };

            // Act
            int result = TestAnswer.Rob(nums);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Rob_SingleHouse_ReturnsHouseValue()
        {
            // Arrange
            int[] nums = new int[] { 5 };

            // Act
            int result = TestAnswer.Rob(nums);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Rob_ThreeHouses_ReturnsMaximumValue()
        {
            // Arrange
            int[] nums = new int[] { 5, 10, 2 };

            // Act
            int result = TestAnswer.Rob(nums);

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Rob_HousesWithNegativeValues_ReturnsMaximumValue()
        {
            // Arrange
            int[] nums = new int[] { 5, -10, 2, 15, -20 };

            // Act
            int result = TestAnswer.Rob(nums);

            // Assert
            Assert.AreEqual(20, result);
        }

        [Test]
        public void Rob_HousesWithZeroValue_ReturnsMaximumValue()
        {
            // Arrange
            int[] nums = new int[] { 0, 0, 0, 0, 0 };

            // Act
            int result = TestAnswer.Rob(nums);

            // Assert
            Assert.AreEqual(0, result);
        }

    }
}