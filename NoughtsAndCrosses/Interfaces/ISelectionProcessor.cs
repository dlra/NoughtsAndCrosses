using System.Collections.Generic;

namespace NoughtsAndCrosses.Interfaces
{
    public interface ISelectionProcessor
    {
        void ProcessSelection(Dictionary<int, Player> previousSelections, Player player, int squareIndex);
    }
}