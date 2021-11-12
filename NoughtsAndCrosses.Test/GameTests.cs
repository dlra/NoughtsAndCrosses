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
        private Mock<IConsole> _consoleMock;

        [SetUp]
        public void Setup()
        {
            _gameRunnerMock = new Mock<IGameRunner>();
            _consoleMock = new Mock<IConsole>();
        }

        [Test]
        public void Game_Runs_Successfully()
        {
            // Arrange
            var game = new Game(_gameRunnerMock.Object, _consoleMock.Object);

            // Assert
            Assert.DoesNotThrow(game.Run);
        }

        [Test]
        public void Can_Add_A_Player()
        {
            // Arrange
            var game = new Game(_gameRunnerMock.Object, _consoleMock.Object);

            // Act
            game.AddPlayer("John Player");

            // Assert
            Assert.IsTrue(game.Players.Count() > 0);
        }

        [Test]
        public void Can_Add_A_Named_Player()
        {
            // Arrange
            var game = new Game(_gameRunnerMock.Object, _consoleMock.Object);
            var addPlayerName = "John Player";
            // Act
            game.AddPlayer(addPlayerName);

            // Assert
            var player = game.Players.FirstOrDefault();
            Assert.AreEqual(player.Name, addPlayerName);
        }

        [Test]
        public void Cannot_Add_More_Than_Two_Players()
        {
            //_consoleMock.Verify(m => m.);

            // Arrange
            var game = new Game(_gameRunnerMock.Object, _consoleMock.Object);
            var addJohnPlayerName = "John Player";
            var addJanePlayerName = "Jane Player";
            
            // Act
            game.AddPlayer(addJohnPlayerName);
            game.AddPlayer(addJanePlayerName);

            // Assert
            Assert.);
        }

        public void Players_Have_To_Have_Different_Names()
        {
            // Arrange
            var game = new Game(_gameRunnerMock.Object, _consoleMock.Object);
            var addPlayerName = "John Player";
            // Act
            game.AddPlayer(addPlayerName);

            // Assert
            var player = game.Players.FirstOrDefault();
            Assert.AreEqual(player.Name, addPlayerName);
        }
    }
}