using NoughtsAndCrosses.Interfaces;
using System.Collections.Generic;

namespace NoughtsAndCrosses.Services
{
    public class GameRunner : IGameRunner
    {
        private readonly IGameBoardPrinter _gamePrinter;
        private readonly IOptionsSelector _optionsSelector;
        private readonly ISelectionProcessor _selectionProcessor;
        private readonly IGameAdjudicator _gameAdjudicator;
        Dictionary<int, Player> BoardSquareSelections = new Dictionary<int, Player>();

        public GameRunner(IGameBoardPrinter gameBoardPrinter, IOptionsSelector optionsSelector,
            ISelectionProcessor selectionProcessor, IGameAdjudicator gameAdjudicator)
        {
            _gamePrinter = gameBoardPrinter;
            _optionsSelector = optionsSelector;
            _selectionProcessor = selectionProcessor;
            _gameAdjudicator = gameAdjudicator;
        }

        public bool IsGameOver => _gameAdjudicator.IsGameOver(BoardSquareSelections);

        public void ProcessTurn(Player player)
        {
            _gamePrinter.PrintBoard(BoardSquareSelections);
            _gamePrinter.PrintOptions(BoardSquareSelections);
            var selection = _optionsSelector.SelectOption(BoardSquareSelections, player);
            _selectionProcessor.ProcessSelection(BoardSquareSelections, player, selection);
            _gamePrinter.PrintBoard(BoardSquareSelections);
        }
    }
}