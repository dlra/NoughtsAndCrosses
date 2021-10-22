using NUnit.Framework;

namespace NoughtsAndCrosses.Test
{
    public class GameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Game_Runs_Successfully()
        {
            // Arrange
            var game = new Game();

            // Assert
            Assert.DoesNotThrow(game.Run);
        }
    }
}