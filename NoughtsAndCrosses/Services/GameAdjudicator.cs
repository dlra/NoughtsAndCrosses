using NoughtsAndCrosses.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NoughtsAndCrosses.Services
{
    public class GameAdjudicator : IGameAdjudicator
    {
        public GameAdjudicator(IConsole console)
        {
            _console = console;
        }

        private readonly List<IEnumerable<int>> _winningCombinations = new List<IEnumerable<int>>
        {
            // horizontal winning combinations
            new int []{1,2,3},
            new int []{4,5,6},
            new int []{7,8,9},
            // vertical winning combinations
            new int []{1,4,7},
            new int []{2,5,8},
            new int []{3,6,9},
            // diagonal winning combinations
            new int []{1,5,9},
            new int []{3,5,7},
        };
        private readonly IConsole _console;

        public bool IsGameOver(Dictionary<int, Player> boardSquareSelections)
        {
            var players = boardSquareSelections.Values;

            foreach (var player in players)
            {
                var playerSquares = boardSquareSelections
                    .Where(x => x.Value == player)
                    .Select(x => x.Key);

                foreach (var combo in _winningCombinations)
                {
                    if (combo.All(x => playerSquares.Contains(x)))
                    {
                        _console.WriteLine($"Game over! {player.Name} wins!");
                        return true;
                    }
                }
            }

            if (boardSquareSelections.Count() == 9)
            {
                _console.WriteLine($"Game over! It's a draw!");
                return true;
            }

            return false;
        }
    }
}