﻿using NoughtsAndCrosses.Interfaces;

namespace NoughtsAndCrosses.Services
{
    public class GameRunner : IGameRunner
    {
        private readonly IGameBoardPrinter _gamePrinter;
        private readonly IOptionsSelector _optionsSelector;

        public GameRunner(IGameBoardPrinter gameBoardPrinter, IOptionsSelector optionsSelector)
        {
            _gamePrinter = gameBoardPrinter;
            _optionsSelector = optionsSelector;
        }

        public bool IsGameOver => throw new System.NotImplementedException();

        public void ProcessTurn(Player player)
        {
            _gamePrinter.PrintBoard();
            _gamePrinter.PrintOptions();
            _optionsSelector.SelectOption(player);
            _gamePrinter.PrintBoard();
        }
    }
}