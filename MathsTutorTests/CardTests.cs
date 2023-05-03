using System;
using Xunit;

namespace MathsTutor.MathsTutorTests
{
    public class CardTests
    {
        [Fact]
        public void Card_ToString_ReturnsCorrectRepresentation()
        {
            // Arrange
            Card card = new Card(5, 1);

            // Act
            string result = card.ToString();

            // Assert
            Assert.Equal("5 -", result);
        }

        [Fact]
        public void SpecialCard_ToString_ReturnsCorrectRepresentation()
        {
            // Arrange
            SpecialCard specialCard = new SpecialCard(5, '-');

            // Act
            string result = specialCard.ToString();

            // Assert
            Assert.Equal("5 -", result);
        }

    }
}
