using System.Collections.Generic;

namespace NoughtsAndCrosses.Interfaces
{
    internal interface IGameAdjudicator
    {
        bool IsGameOver(Dictionary<int, Player> boardSquareSelections);
    }
}