using System.Collections.Generic;

namespace NoughtsAndCrosses.Interfaces
{
    public interface IGameRunner
    {
        bool IsGameOver { get; }

        void ProcessTurn();
        void Initialise(IEnumerable<Player> _players);
        void SetNextTurnPlayer();
    }
}