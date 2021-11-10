using NoughtsAndCrosses.Interfaces;
using System;
using System.Collections.Generic;

namespace NoughtsAndCrosses.Services
{
    public class GameBoardPrinter : IGameBoardPrinter
    {
        private readonly IConsole _console;
        private const int TOTAL_COLUMNS = 3;
        private const int TOTAL_ROWS = 3;

        public GameBoardPrinter(IConsole console)
        {
            _console = console;
        }

        public void PrintBoard(Dictionary<int, Player> previousSelections)
        {
            _console.WriteLine("The current state of play:" + Environment.NewLine);

            for (var row = 1; row <= TOTAL_ROWS; row++)
            {
                for (var column = 1; column <= TOTAL_COLUMNS; column++)
                {
                    var boardIndex = (row - 1) * TOTAL_COLUMNS + column;
                    if (previousSelections.TryGetValue(boardIndex, out var player))
                    {
                        _console.Write($"{player.Marker}  ");
                    }
                    else _console.Write($"-  ");
                }
                _console.WriteLine(Environment.NewLine);
            }
        }

        public void PrintOptions(Dictionary<int, Player> previousSelections)
        {
            _console.WriteLine("The current board options:" + Environment.NewLine);

            for (var row = 1; row <= TOTAL_ROWS; row++)
            {
                for (var column = 1; column <= TOTAL_COLUMNS; column++)
                {
                    var boardIndex = (row - 1) * TOTAL_COLUMNS + column;
                    if (previousSelections.TryGetValue(boardIndex, out var player))
                    {
                        _console.Write($"-  ");
                    }
                    else _console.Write($"{boardIndex}  ");
                }
                _console.WriteLine(Environment.NewLine);
            }
        }

    }
}