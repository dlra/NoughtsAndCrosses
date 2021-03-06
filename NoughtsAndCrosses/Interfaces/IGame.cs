using System.Collections.Generic;

namespace NoughtsAndCrosses.Interfaces
{
    public interface IGame
    {
        IEnumerable<Player> Players { get; }

        void AddPlayer(string name);
        void Run();
    }
}