using System;

namespace NoughtsAndCrosses
{
    public class GameBuilder : IGameBuilder
    {
        private readonly IGame _game = new Game();

        public IGame Build()
        {
            throw new NotImplementedException();
        }
    }
}