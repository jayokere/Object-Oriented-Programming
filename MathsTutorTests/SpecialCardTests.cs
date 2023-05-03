using System;
using Xunit;

namespace MathsTutor.MathsTutorTests
{
    public class SpecialCardTests
    {
        [Fact]
        public void SpecialCard_CreatesWithOperator()
        {
            // Arrange & Act
            SpecialCard specialCard = new SpecialCard(5, '+');

            // Assert
            Assert.Equal(5, specialCard.Value);
            Assert.Equal('+', specialCard.Operator);
        }

        [Fact]
        public void SpecialCard_InvalidOperator_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new SpecialCard(5, 'x'));
        }

        [Fact]
        public void SpecialCard_ToString_ReturnsCorrectRepresentation()
        {
            // Arrange
            SpecialCard specialCard = new SpecialCard(5, '+');

            // Act
            string result = specialCard.ToString();

            // Assert
            Assert.Equal("5 +", result);
        }
    }
}
