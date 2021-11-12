using NoughtsAndCrosses.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace NoughtsAndCrosses.Services
{
    public class Game : IGame
    {
        private int NUMBER_OF_PLAYERS = 2;

        private bool _isGameOver = true;
        private bool _canAddPlayers = true;
        private List<Player> _players = new List<Player>();
        private List<char> _markers = new List<char> { 'X', 'O' };
        private readonly IGameRunner _gameRunner;
        private readonly IConsole _console;

        public IEnumerable<Player> Players => _players;

        public Game(IGameRunner gameRunner, IConsole console)
        {
            _gameRunner = gameRunner;
            _console = console;
        }

        public void AddPlayer(string name)
        {
            if (!_canAddPlayers)
            {
                _console.WriteLine("Unable to add another player.");
                return;
            }

            if (_players.Any(x => x.Name == name))
            {
                _console.WriteLine("Players must have different names");
                return;
            }

            var marker = _markers[0];
            _players.Add(new Player { Name = name, Marker = marker });
            _markers.Remove(marker);

            if (_players.Count == NUMBER_OF_PLAYERS) _canAddPlayers = false;
        }

        public void Run()
        {
            if (_players.Count != NUMBER_OF_PLAYERS)
            {
                _console.WriteLine("Unable to proceed without two players");
                return;
            }

            Start();

            while (!_isGameOver)
            {
                _gameRunner.ProcessTurn();
                _isGameOver = _gameRunner.IsGameOver;
                _gameRunner.SetNextTurnPlayer();
            }
        }

        private void Start()
        {
            _isGameOver = false;
            _canAddPlayers = false;
            _gameRunner.Initialise(_players);
        }
    }
}