using NoughtsAndCrosses.Services;
using NUnit.Framework;

namespace NoughtsAndCrosses.Test
{
    public class GameBuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Game_Builds_Successfully()
        {
            // Arrange
            var gameBuilder = new GameBuilder();

            // Act
            var game = gameBuilder.Build();

            // Assert
            Assert.IsNotNull(game);
        }
    }
}