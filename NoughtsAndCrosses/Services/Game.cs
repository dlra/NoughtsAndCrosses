using System;

namespace NoughtsAndCrosses
{
    public class Game : IGame
    {
        private bool _isGameOver;

        public void Run()
        {
            while (!_isGameOver)
            {
                _isGameOver = true;
            }
        }
    }
}