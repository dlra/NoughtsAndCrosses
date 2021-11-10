using NoughtsAndCrosses.Interfaces;
using System.Collections.Generic;

namespace NoughtsAndCrosses.Services
{
    public class SelectionProcessor : ISelectionProcessor
    {
        private readonly IConsole _console;
        private const int TOTAL_COLUMNS = 3;
        private const int TOTAL_ROWS = 3;

        public SelectionProcessor(IConsole console)
        {
            _console = console;
        }

        public void ProcessSelection(Dictionary<int, Player> previousSelections, Player player, int squareIndex)
        {
            if (squareIndex < 1 || squareIndex > TOTAL_COLUMNS * TOTAL_ROWS)
            {
                _console.WriteLine("Index of square is out of range.");
                return;
            }

            if (previousSelections.ContainsKey(squareIndex))
            {
                _console.WriteLine("Square has already been played.");
                return;
            }

            previousSelections.Add(squareIndex, player);
        }
    }
}