using NoughtsAndCrosses.Interfaces;
using System;
using System.Collections.Generic;

namespace NoughtsAndCrosses.Services
{
    public class Game : IGame
    {
        private bool _isGameOver = false;
        private bool _isStarted = false;
        private bool _canAddPlayers = true;
        private List<Player> _players = new List<Player>();
        private Player _nextTurnPlayer;
        private List<char> _markers = new List<char> { 'X', 'O' };
        private readonly IGameRunner _gameRunner;

        public IEnumerable<Player> Players => _players;

        public Game(IGameRunner gameRunner)
        {
            _gameRunner = gameRunner;
        }

        public void AddPlayer(string name)
        {
            if (!_canAddPlayers)
            {
                Console.WriteLine("Unable to add another player.");
                return;
            }

            var marker = _markers[0];
            _players.Add(new Player { Name = name, Marker = marker });
            _markers.Remove(marker);

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
                _gameRunner.ProcessTurn(_nextTurnPlayer);
                _isGameOver = _gameRunner.IsGameOver;
                SetNextTurnPlayer();
            }
        }

        private void SetNextTurnPlayer()
        {
            var currentTurnPlayerIndex = _players.IndexOf(_nextTurnPlayer);

            if (currentTurnPlayerIndex + 1 == _players.Count)
            {
                _nextTurnPlayer = _players[0];
            }
            else
            {
                _nextTurnPlayer = _players[currentTurnPlayerIndex + 1];
            }
        }

        private void Start()
        {
            _isStarted = true;
            _canAddPlayers = false;
            _nextTurnPlayer = _players[0];
        }
    }
}