using Moq;
using NoughtsAndCrosses.Interfaces;
using NoughtsAndCrosses.Services;
using NUnit.Framework;
using System.Linq;

namespace NoughtsAndCrosses.Test
{
    public class GameTests
    {
        private Mock<IGameRunner> _gameRunnerMock;

        [SetUp]
        public void Setup()
        {
            _gameRunnerMock = new Mock<IGameRunner>();
        }

        [Test]
        public void Game_Runs_Successfully()
        {
            // Arrange
            var game = new Game(_gameRunnerMock.Object);

            // Assert
            Assert.DoesNotThrow(game.Run);
        }

        [Test]
        public void Can_Add_A_Player()
        {
            // Arrange
            var game = new Game(_gameRunnerMock.Object);

            // Act
            game.AddPlayer("John Player");

            // Assert
            Assert.IsTrue(game.Players.Count() > 0);
        }

        [Test]
        public void Can_Add_A_Named_Player()
        {
            // Arrange
            var game = new Game(_gameRunnerMock.Object);
            var addPlayerName = "John Player";
            // Act
            game.AddPlayer(addPlayerName);

            // Assert
            var player = game.Players.FirstOrDefault();
            Assert.AreEqual(player.Name, addPlayerName);
        }
    }
}