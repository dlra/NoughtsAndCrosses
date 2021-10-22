using System;
using System.Collections.Generic;

namespace NoughtsAndCrosses
{
    public class Game : IGame
    {
        private bool _isGameOver = false;
        private bool _isStarted = false;
        private bool _canAddPlayers = true;
        private List<Player> _players = new List<Player>();

        public IEnumerable<Player> Players => _players;

        public void AddPlayer(string name)
        {
            if (!_canAddPlayers)
            {
                Console.WriteLine("Unable to add another player.");
                return;
            }

            _players.Add(new Player { Name = name });

            if (_players.Count == 2) _canAddPlayers = false;
        }

        public void Run()
        {
            if (_players.Count != 2)
            {
                Console.WriteLine("Unable to proceed without two players");
                return;
            }

            Start();

            while (!_isGameOver)
            {
                _isGameOver = true;
            }
        }

        private void Start()
        {
            _isStarted = true;
            _canAddPlayers = false;
        }
    }
}