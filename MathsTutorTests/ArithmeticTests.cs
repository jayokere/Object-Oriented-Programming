using System;
using Xunit;

namespace MathsTutor.MathsTutorTests
{
    public class ArithmeticTests
    {
        [Fact]
        public void TestAddition()
        {
            // Arrange
            Card card1 = new Card(5, 0);
            Card card3 = new Card(3, 0);

            // Act
            int result = card1.Value + card3.Value;

            // Assert
            Assert.Equal("5 + 3 = 8", $"{card1.Value} + {card3.Value} = {result}");
        }

        [Fact]
        public void TestSubtraction()
        {
            // Arrange
            Card card1 = new Card(5, 0);
            Card card3 = new Card(3, 0);

            // Act
            int result = card1.Value - card3.Value;

            // Assert
            Assert.Equal("5 - 3 = 2", $"{card1.Value} - {card3.Value} = {result}");
        }

        [Fact]
        public void TestMultiplication()
        {
            // Arrange
            Card card1 = new Card(5, 0);
            Card card3 = new Card(3, 0);

            // Act
            int result = card1.Value * card3.Value;

            // Assert
            Assert.Equal("5 * 3 = 15", $"{card1.Value} * {card3.Value} = {result}");
        }

        [Fact]
        public void TestDivision()
        {
            // Arrange
            Card card6 = new Card(6, 0);
            Card card3 = new Card(3, 0);

            // Act
            int result = card6.Value / card3.Value;

            // Assert
            Assert.Equal("6 / 3 = 2", $"{card6.Value} / {card3.Value} = {result}");
        }
    }
}
