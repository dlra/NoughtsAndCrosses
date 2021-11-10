using System.Collections.Generic;

namespace NoughtsAndCrosses.Interfaces
{
    public interface IGameBoardPrinter
    {
        void PrintBoard(Dictionary<int, Player> previousSelections);
        void PrintOptions(Dictionary<int, Player> previousSelections);
    }
}