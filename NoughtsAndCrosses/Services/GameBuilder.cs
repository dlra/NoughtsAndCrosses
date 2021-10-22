using NoughtsAndCrosses.Interfaces;
using System;

namespace NoughtsAndCrosses.Services
{
    public class GameBuilder : IGameBuilder
    {
        private readonly IGame _game = new Game(new GameRunner());

        public IGameBuilder AddPlayers()
        {
            _game.AddPlayer("Player 1");
            _game.AddPlayer("Player 2");

            return this;
        }

        public IGame Build()
        {
            return _game;
        }
    }
}