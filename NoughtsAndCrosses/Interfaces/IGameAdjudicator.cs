using System.Collections.Generic;

namespace NoughtsAndCrosses.Interfaces
{
    public interface IGameAdjudicator
    {
        bool IsGameOver(Dictionary<int, Player> boardSquareSelections);
    }
}