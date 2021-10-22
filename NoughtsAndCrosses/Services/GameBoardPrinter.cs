using NoughtsAndCrosses.Interfaces;
using System;
using System.Collections.Generic;

namespace NoughtsAndCrosses.Services
{
    public class GameBoardPrinter : IGameBoardPrinter
    {
        private const int TOTAL_COLUMNS = 9;
        private const int TOTAL_ROWS = 9;
        private readonly IConsole _console;
        Dictionary<int, Player> BoardSquareSelections = new Dictionary<int, Player>();

        public GameBoardPrinter(IConsole console)
        {
            _console = console;
        }

        public void PrintBoard()
        {
            for (var row = 1; row <= TOTAL_ROWS; row++)
            {
                for (var column = 1; column <= TOTAL_COLUMNS; column++)
                {
                    var boardIndex = (row - 1) * TOTAL_COLUMNS + column;
                    if (BoardSquareSelections.TryGetValue(boardIndex, out var player))
                    {
                        _console.Write($"{player.Marker}  ");
                    }
                    else _console.Write($"-  ");
                }
                _console.WriteLine(Environment.NewLine);
            }
        }

        public void PrintOptions()
        {
            for (var row = 1; row <= TOTAL_ROWS; row++)
            {
                for (var column = 1; column <= TOTAL_COLUMNS; column++)
                {
                    var boardIndex = (row - 1) * TOTAL_COLUMNS + column;
                    if (BoardSquareSelections.TryGetValue(boardIndex, out var player))
                    {
                        _console.Write($"-  ");
                    }
                    else _console.Write($"{boardIndex}  ");
                }
                _console.WriteLine(Environment.NewLine);
            }
        }

        public void ProcessSelection(Player player, int squareIndex)
        {
            if (squareIndex < 1 || squareIndex > TOTAL_COLUMNS * TOTAL_ROWS)
            {
                _console.WriteLine("Index of square is out of range.");
                return;
            }

            if (BoardSquareSelections.ContainsKey(squareIndex))
            {
                _console.WriteLine("Square has already been played.");
                return;
            }

            BoardSquareSelections.Add(squareIndex, player);
        }
    }
}