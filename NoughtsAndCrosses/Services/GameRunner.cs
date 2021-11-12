using NoughtsAndCrosses.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NoughtsAndCrosses.Services
{
    public class GameRunner : IGameRunner
    {
        private readonly IGameBoardPrinter _gamePrinter;
        private readonly IOptionsSelector _optionsSelector;
        private readonly ISelectionProcessor _selectionProcessor;
        private readonly IGameAdjudicator _gameAdjudicator;
        Dictionary<int, Player> BoardSquareSelections = new Dictionary<int, Player>();
        private Player _nextTurnPlayer;
        private List<Player> _players;

        public GameRunner(IGameBoardPrinter gameBoardPrinter, IOptionsSelector optionsSelector,
            ISelectionProcessor selectionProcessor, IGameAdjudicator gameAdjudicator)
        {
            _gamePrinter = gameBoardPrinter;
            _optionsSelector = optionsSelector;
            _selectionProcessor = selectionProcessor;
            _gameAdjudicator = gameAdjudicator;
        }

        public bool IsGameOver => _gameAdjudicator.IsGameOver(BoardSquareSelections);

        public void Initialise(IEnumerable<Player> players)
        {
            _players = players.ToList();
            _nextTurnPlayer = _players[0];
        }

        public void SetNextTurnPlayer()
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

        public void ProcessTurn()
        {
            _gamePrinter.PrintBoard(BoardSquareSelections);
            _gamePrinter.PrintOptions(BoardSquareSelections);
            var selection = _optionsSelector.SelectOption(BoardSquareSelections, _nextTurnPlayer);
            _selectionProcessor.ProcessSelection(BoardSquareSelections, _nextTurnPlayer, selection);
            _gamePrinter.PrintBoard(BoardSquareSelections);
        }
    }
}