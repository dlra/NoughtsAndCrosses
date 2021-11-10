using System.Collections.Generic;

namespace NoughtsAndCrosses.Interfaces
{
    public interface IOptionsSelector
    {
        int SelectOption(Dictionary<int, Player> previousSelections, Player player);
    }
}