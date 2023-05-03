using System;
using Xunit;

namespace MathsTutor.MathsTutorTests
{
    public class PackTests
    {
        [Fact]
        public void Pack_CreatesFullPack()
        {
            // Arrange & Act
            Pack pack = new Pack();

            // Assert
            Assert.Equal(52, pack.Count);
        }

        [Fact]
        public void Pack_Shuffle_ShufflesCards()
        {
            // Arrange
            Pack pack = new Pack();
            Pack shuffledPack = new Pack();

            // Act
            shuffledPack.Shuffle();

            // Assert
            Assert.NotEqual(pack.ToString(), shuffledPack.ToString());
        }


        [Fact]
        public void Pack_Deal_RemovesAndReturnsCard()
        {
            // Arrange
            Pack pack = new Pack();

            // Act
            Card dealtCard = pack.Deal();

            // Assert
            Assert.Equal(51, pack.Count);
            Assert.NotNull(dealtCard);
        }

        [Fact]
        public void Pack_Deal_EmptyPack_ThrowsInvalidOperationException()
        {
            // Arrange
            Pack pack = new Pack();
            for (int i = 0; i < 52; i++)
            {
                pack.Deal();
            }

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => pack.Deal());
        }
    }
}
