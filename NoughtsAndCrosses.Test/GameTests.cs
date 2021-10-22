using NUnit.Framework;
using System.Linq;

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

        [Test]
        public void Can_Add_A_Player()
        {
            // Arrange
            var game = new Game();

            // Act
            game.AddPlayer("John Player");

            // Assert
            Assert.IsTrue(game.Players.Count() > 0);
        }

        [Test]
        public void Can_Add_A_Named_Player()
        {
            // Arrange
            var game = new Game();
            var addPlayerName = "John Player";
            // Act
            game.AddPlayer(addPlayerName);

            // Assert
            var player = game.Players.FirstOrDefault();
            Assert.AreEqual(player.Name, addPlayerName);
        }
    }
}